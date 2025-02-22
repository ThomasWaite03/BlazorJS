namespace BlazorJS;

public interface ISessionStorage
{
    /// <summary>
    /// Returns all the keys in the session storage.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<string>> GetKeysAsync();

    /// <summary>
    /// Returns the value for a certain <paramref name="key"/> in the session storage.
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    Task<string?> GetItemAsync(string key);

    /// <summary>
    /// Sets an item in the session storage.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    Task SetItemAsync(string key, string value);

    /// <summary>
    /// Removes an item from the session storage.
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    Task RemoveItemAsync(string key);

    /// <summary>
    /// Clears all items in the session storage.
    /// </summary>
    /// <returns></returns>
    Task ClearItems();
}
