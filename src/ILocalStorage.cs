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
    /// <para>Equivalent to <c>localStorage.getItem()</c>.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    Task<string?> GetAsync(string key);

    /// <summary>
    /// Sets an item in the local storage.
    /// <para>Equivalent to <c>localStorage.setItem()</c>.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    Task SetAsync(string key, string value);

    /// <summary>
    /// Removes an item from the local storage.
    /// <para>Equivalent to <c>localStorage.removeItem()</c>.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    Task RemoveAsync(string key);

    /// <summary>
    /// Clears all items in the local storage.
    /// <para>Equivalent to <c>localStorage.clear()</c>.</para>
    /// </summary>
    /// <returns></returns>
    Task ClearAsync();
}
