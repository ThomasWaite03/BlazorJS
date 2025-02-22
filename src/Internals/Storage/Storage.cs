namespace BlazorJS.Internals.Storage;

internal abstract class Storage : ISessionStorage
{
    private readonly JSInvoker JS;
    private readonly string _storageType;

    internal enum StorageType
    {
        LocalStorage,
        SessionStorage
    }

    internal Storage(JSInvoker invoker, StorageType storageType)
    {
        JS = invoker;

        _storageType = GetStorageTypeString(storageType);
    }

    public async Task<IEnumerable<string>> GetKeysAsync()
    {
        return await JS.InvokeAsync<IEnumerable<string>>("eval", $"Object.keys({_storageType})");
    }

    public async Task<string?> GetItemAsync(string key)
    {
        return await JS.InvokeAsync<string>($"{_storageType}.getItem", key);
    }

    public async Task SetItemAsync(string key, string value)
    {
        await JS.InvokeVoidAsync($"{_storageType}.setItem", [key, value]);
    }

    public async Task RemoveItemAsync(string key)
    {
        await JS.InvokeVoidAsync($"{_storageType}.removeItem", key);
    }

    public async Task ClearItems()
    {
        await JS.InvokeVoidAsync($"{_storageType}.clear");
    }

    private static string GetStorageTypeString(StorageType storageType)
    {
        return storageType switch
        {
            StorageType.LocalStorage => "sessionStorage",
            StorageType.SessionStorage => "localStorage",
            _ => throw new ArgumentOutOfRangeException(nameof(storageType)),
        };
    }
}
