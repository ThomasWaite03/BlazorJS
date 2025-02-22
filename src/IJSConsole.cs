using BlazorJS.Internals.Console;

namespace BlazorJS;

public interface IJSConsole
{
    /// <summary>
    /// Logs a message to the console if the condition is false.
    /// <para>Equivalent to <c>console.assert()</c>.</para>
    /// </summary>
    Task AssertAsync(bool condition, object? messages);

    /// <summary>
    /// Logs messages to the console if the condition is false.
    /// <para>Equivalent to <c>console.assert()</c>.</para>
    /// </summary>
    Task AssertAsync(bool condition, IEnumerable<object?> messages);

    /// <summary>
    /// Clears all messages from the console.
    /// <para>Equivalent to <c>console.clear()</c>.</para>
    /// </summary>
    Task ClearAsync();

    /// <summary>
    /// Creates a counter object for incrementing and logging a count for a specific label
    /// </summary>
    /// <param name="label"></param>
    /// <returns></returns>
    IJSConsoleCounter CreateCounter(string? label = null);

    /// <summary>
    /// Logs a debug message to the browser console.
    /// <para>Equivalent to <c>console.debug()</c>.</para>
    /// </summary>
    Task DebugAsync(object? message);

    /// <summary>
    /// Logs debug messages to the browser console.
    /// <para>Equivalent to <c>console.debug()</c>.</para>
    /// </summary>
    Task DebugAsync(IEnumerable<object?> messages);

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
    /// Logs an error message to the browser console.
    /// <para>Equivalent to <c>console.error()</c>.</para>
    /// </summary>
    Task ErrorAsync(object? message);

    /// <summary>
    /// Logs error messages to the browser console.
    /// <para>Equivalent to <c>console.error()</c>.</para>
    /// </summary>
    Task ErrorAsync(IEnumerable<object?> messages);

    /// <summary>
    /// Creates a new inline group in the console.
    /// <para>Equivalent to <c>console.group()</c>.</para>
    /// </summary>
    Task GroupAsync(string? label = null);

    /// <summary>
    /// Creates a new collapsed inline group in the console.
    /// <para>Equivalent to <c>console.groupCollapsed()</c>.</para>
    /// </summary>
    Task GroupCollapsedAsync(string? label = null);

    /// <summary>
    /// Ends the most recently created group.
    /// <para>Equivalent to <c>console.groupEnd()</c>.</para>
    /// </summary>
    Task GroupEndAsync();

    /// <summary>
    /// Logs an informational message to the browser console.
    /// <para>Equivalent to <c>console.info()</c>.</para>
    /// </summary>
    Task InfoAsync(object? message);

    /// <summary>
    /// Logs informational messages to the browser console.
    /// <para>Equivalent to <c>console.info()</c>.</para>
    /// </summary>
    Task InfoAsync(IEnumerable<object?> messages);

    /// <summary>
    /// Logs a message to the browser console.
    /// <para>Equivalent to <c>console.log()</c>.</para>
    /// </summary>
    Task LogAsync(object? message);

    /// <summary>
    /// Logs messages to the browser console.
    /// <para>Equivalent to <c>console.log()</c>.</para>
    /// </summary>
    Task LogAsync(IEnumerable<object?> messages);

    /// <summary>
    /// Displays a list of objects as a table in the console.
    /// <para>Equivalent to <c>console.table()</c>.</para>
    /// </summary>
    Task TableAsync(IEnumerable<object> data);

    /// <summary>
    /// Creates a timer object which can be used to log the time to the console.
    /// </summary>
    /// <param name="label"></param>
    /// <returns></returns>
    IJSConsoleTimer CreateTimer(string? label = null);

    /// <summary>
    /// Prints a stack trace to the console.
    /// <para>Equivalent to <c>console.trace()</c>.</para>
    /// </summary>
    Task TraceAsync();

    /// <summary>
    /// Prints a stack trace to the console along with a message.
    /// <para>Equivalent to <c>console.trace()</c>.</para>
    /// </summary>
    Task TraceAsync(object? message);

    /// <summary>
    /// Prints a stack trace to the console along with some messages.
    /// <para>Equivalent to <c>console.trace()</c>.</para>
    /// </summary>
    Task TraceAsync(IEnumerable<object?> messages);

    /// <summary>
    /// Logs a warning message to the browser console.
    /// <para>Equivalent to <c>console.warn()</c>.</para>
    /// </summary>
    Task WarnAsync(object? message);

    /// <summary>
    /// Logs warning messages to the browser console.
    /// <para>Equivalent to <c>console.warn()</c>.</para>
    /// </summary>
    Task WarnAsync(IEnumerable<object?> messages);
}
