namespace BlazorJS;

public interface IConsoleCounter
{
    /// <summary>
    /// Logs the number of times this method has been called.
    /// <para>Equivalent to <c>console.count()</c>.</para>
    /// </summary>
    Task CountAsync();

    /// <summary>
    /// Resets the count.
    /// <para>Equivalent to <c>console.countReset()</c>.</para>
    /// </summary>
    Task ResetAsync();
}
