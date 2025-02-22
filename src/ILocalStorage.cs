namespace BlazorJS;

public interface ILocalStorage
{
    /// <summary>
    /// Returns all the keys in the local storage.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<string>> GetKeysAsync();

    /// <summary>
    /// Returns the value for a certain <paramref name="key"/> in the local storage.
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    Task<string?> GetItemAsync(string key);

    /// <summary>
    /// Sets an item in the local storage.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    Task SetItemAsync(string key, string value);

    /// <summary>
    /// Removes an item from the local storage.
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    Task RemoveItemAsync(string key);

    /// <summary>
    /// Clears all items in the local storage.
    /// </summary>
    /// <returns></returns>
    Task ClearItems();
}
