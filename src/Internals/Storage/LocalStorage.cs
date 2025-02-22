namespace BlazorJS.Internals.Storage;

internal class LocalStorage(JSInvoker invoker) 
    : Storage(invoker, StorageType.LocalStorage), ILocalStorage
{
}
