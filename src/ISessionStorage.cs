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
    /// <para>Equivalent to <c>sessionStorage.getItem()</c>.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    Task<string?> GetAsync(string key);

    /// <summary>
    /// Sets an item in the session storage.
    /// <para>Equivalent to <c>sessionStorage.setItem()</c>.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    Task SetAsync(string key, string value);

    /// <summary>
    /// Removes an item from the session storage.
    /// <para>Equivalent to <c>sessionStorage.removeItem()</c>.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    Task RemoveAsync(string key);

    /// <summary>
    /// Clears all items in the session storage.
    /// <para>Equivalent to <c>sessionStorage.clear()</c>.</para>
    /// </summary>
    /// <returns></returns>
    Task ClearAsync();
}
