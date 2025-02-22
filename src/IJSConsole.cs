namespace BlazorJS;

public interface IJSConsole
{
    /// <summary>
    /// Logs a message to the console if the condition is false.
    /// <para>Equivalent to <c>console.assert()</c>.</para>
    /// </summary>
    Task AssertAsync(bool condition, params object[] messages);

    /// <summary>
    /// Clears all messages from the console.
    /// <para>Equivalent to <c>console.clear()</c>.</para>
    /// </summary>
    Task ClearAsync();

    /// <summary>
    /// Logs the number of times this method has been called with the same label.
    /// <para>Equivalent to <c>console.count()</c>.</para>
    /// </summary>
    Task CountAsync(string label = "default");

    /// <summary>
    /// Resets the count for a specific label.
    /// <para>Equivalent to <c>console.countReset()</c>.</para>
    /// </summary>
    Task CountResetAsync(string label = "default");

    /// <summary>
    /// Logs debug messages to the browser console.
    /// <para>Equivalent to <c>console.debug()</c>.</para>
    /// </summary>
    Task DebugAsync(params object[] messages);

    /// <summary>
    /// Displays an interactive list of all properties of a specified JavaScript object.
    /// <para>Equivalent to <c>console.dir()</c>.</para>
    /// </summary>
    Task DirAsync(object obj);

    /// <summary>
    /// Displays an interactive listing of the XML/HTML elements passed.
    /// <para>Equivalent to <c>console.dirxml()</c>.</para>
    /// </summary>
    Task DirXmlAsync(object obj);

    /// <summary>
    /// Logs error messages to the browser console.
    /// <para>Equivalent to <c>console.error()</c>.</para>
    /// </summary>
    Task ErrorAsync(params object[] messages);

    ///// <summary>
    ///// Creates a new inline group in the console.
    ///// <para>Equivalent to <c>console.group()</c>.</para>
    ///// </summary>
    //Task GroupAsync(params object[] messages);

    ///// <summary>
    ///// Creates a new collapsed inline group in the console.
    ///// <para>Equivalent to <c>console.groupCollapsed()</c>.</para>
    ///// </summary>
    //Task GroupCollapsedAsync(params object[] messages);

    ///// <summary>
    ///// Ends the most recently created group.
    ///// <para>Equivalent to <c>console.groupEnd()</c>.</para>
    ///// </summary>
    //Task GroupEndAsync();

    ///// <summary>
    ///// Logs informational messages to the browser console.
    ///// <para>Equivalent to <c>console.info()</c>.</para>
    ///// </summary>
    //Task InfoAsync(params object[] messages);

    /// <summary>
    /// Logs messages to the browser console.
    /// <para>Equivalent to <c>console.log()</c>.</para>
    /// </summary>
    Task LogAsync(params object[] messages);

    ///// <summary>
    ///// Displays tabular data as a table in the console.
    ///// <para>Equivalent to <c>console.table()</c>.</para>
    ///// </summary>
    //Task TableAsync(object data);

    ///// <summary>
    ///// Starts a timer with a given label.
    ///// <para>Equivalent to <c>console.time()</c>.</para>
    ///// </summary>
    //Task TimeAsync(string label);

    ///// <summary>
    ///// Stops the timer and logs the elapsed time.
    ///// <para>Equivalent to <c>console.timeEnd()</c>.</para>
    ///// </summary>
    //Task TimeEndAsync(string label);

    ///// <summary>
    ///// Logs the elapsed time for a specific timer.
    ///// <para>Equivalent to <c>console.timeLog()</c>.</para>
    ///// </summary>
    //Task TimeLogAsync(string label, params object[] messages);

    ///// <summary>
    ///// Prints a stack trace to the console.
    ///// <para>Equivalent to <c>console.trace()</c>.</para>
    ///// </summary>
    //Task TraceAsync(params object[] messages);

    ///// <summary>
    ///// Logs warning messages to the browser console.
    ///// <para>Equivalent to <c>console.warn()</c>.</para>
    ///// </summary>
    //Task WarnAsync(params object[] messages);
}
