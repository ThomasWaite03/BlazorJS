namespace BlazorJS.Internals.Storage;

internal class SessionStorage(JSInvoker invoker) 
    : Storage(invoker, StorageType.SessionStorage), ISessionStorage
{
}
