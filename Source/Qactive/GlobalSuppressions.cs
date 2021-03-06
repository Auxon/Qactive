[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Qactive.QbservableServer+CreateServiceProxy`2.#CreateService(System.Net.IPEndPoint,Qactive.QbservableServiceOptions,Qactive.QbservableServer+CreateServiceProxyDelegates`2<!0,!1>)", Justification = "MarshalByRefObject that must be executed in a separate AppDomain having the necessary permissions.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Qactive.QbservableServer+CreateServiceProxy`2.#CreateService(Qactive.QactiveProviderFactory,Qactive.QbservableServiceOptions,Qactive.QbservableServer+CreateServiceProxyDelegates`2<!0,!1>)", Justification = "MarshalByRefObject that must be executed in a separate AppDomain having the necessary permissions.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Qactive.QbservableServer+CreateServiceProxy`2.#CreateService(Qactive.QactiveProviderFactory,Qactive.QbservableServiceOptions,Qactive.QbservableServer+CreateServiceProxyDelegates`2<!0,!1>)", Justification = "We must catch all exception types and log them. The call to observer.OnError is probably a NOP at this point, however.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Qactive.QbservableProtocol.#Qactive.IQbservableProtocol.CreateClientDuplexSink()", Justification = "Exposed as an *Internal variant.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Qactive.QbservableProtocol.#Qactive.IQbservableProtocol.CreateServerDuplexSink()", Justification = "Exposed as an *Internal variant.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "System.Reflection", Justification = "Contains extension classes for types defined in that namespace.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.FormattableString.#Invariant(System.FormattableString)", Justification = "Copied from GitHub.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Qactive.QbservableProtocolSink`2.#.ctor()", Justification = "Sinks cannot be removed and the lifetime of subscriptions to the exceptions subject is equivelent to the sink object's lifetime, which is controlled by the protocol object.")]
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

