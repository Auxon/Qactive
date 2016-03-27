﻿using System;
using System.Collections.Concurrent;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace Qactive
{
  internal sealed class AsyncConsumerQueue : IDisposable
  {
    private readonly ConcurrentQueue<Tuple<Func<Task>, TaskCompletionSource<bool>>> q = new ConcurrentQueue<Tuple<Func<Task>, TaskCompletionSource<bool>>>();
    private readonly Subject<ExceptionDispatchInfo> unhandledExceptions = new Subject<ExceptionDispatchInfo>();
    private int isDequeueing;

    public IObservable<ExceptionDispatchInfo> UnhandledExceptions => unhandledExceptions.AsObservable();

    public Task EnqueueAsync(Func<Task> actionAsync)
    {
      var task = new TaskCompletionSource<bool>();

      q.Enqueue(Tuple.Create(actionAsync, task));

      EnsureDequeueing();

      return task.Task;
    }

    private async void EnsureDequeueing()
    {
      while (q.Count > 0 && Interlocked.CompareExchange(ref isDequeueing, 1, 0) == 0)
      {
        Tuple<Func<Task>, TaskCompletionSource<bool>> data;

        if (q.TryDequeue(out data))
        {
          try
          {
            try
            {
              await data.Item1().ConfigureAwait(false);
            }
            catch (OperationCanceledException)
            {
              data.Item2.SetCanceled();
              continue;
            }
            catch (Exception ex)
            {
              data.Item2.SetException(ex);
              continue;
            }

            data.Item2.SetResult(true);
          }
          catch (Exception ex)
          {
            unhandledExceptions.OnNext(ExceptionDispatchInfo.Capture(ex));
          }
        }

        isDequeueing = 0;
      }
    }

    public void Dispose()
    {
      unhandledExceptions.Dispose();
    }
  }
}