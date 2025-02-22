namespace BlazorJS;

public interface IConsoleTimer
{
    /// <summary>
    /// Starts the timer.
    /// <para>Equivalent to <c>console.time()</c>.</para>
    /// </summary>
    /// <returns></returns>
    Task StartAsync();

    /// <summary>
    /// Logs the elapsed time for the timer.
    /// <para>Equivalent to <c>console.timeLog()</c>.</para>
    /// </summary>
    /// <returns></returns>
    Task LogAsync();

    /// <summary>
    /// Logs the elapsed time for the timer along with a message.
    /// <para>Equivalent to <c>console.timeLog()</c>.</para>
    /// </summary>
    /// <param name="messages"></param>
    /// <returns></returns>
    Task LogAsync(object? message);

    /// <summary>
    /// Logs the elapsed time for the timer along with some messages.
    /// <para>Equivalent to <c>console.timeLog()</c>.</para>
    /// </summary>
    /// <param name="messages"></param>
    /// <returns></returns>
    Task LogAsync(IEnumerable<object?> messages);

    /// <summary>
    /// Stops the timer and logs the elapsed time.
    /// <para>Equivalent to <c>console.timeEnd()</c>.</para>
    /// </summary>
    /// <returns></returns>
    Task EndAsync();
}
