using Microsoft.JSInterop;
using System.Reflection.Emit;

namespace BlazorJS.Internals.Console;

internal class JSConsole : IJSConsole
{
    private const string DefaultLabel = "default";

    private readonly JSInvoker JS;

    public JSConsole(IJSRuntime jsRuntime)
    {
        JS = new JSInvoker(jsRuntime);
    }

    public async Task AssertAsync(bool condition, object? message)
    {
        await JS.InvokeVoidAsync("console.assert", [condition, message]);
    }

    public async Task AssertAsync(bool condition, IEnumerable<object?> messages)
    {
        List<object?> args = [condition];
        args.AddRange(messages);

        await JS.InvokeVoidAsync("console.assert", args);
    }

    public async Task ClearAsync()
    {
        await JS.InvokeVoidAsync("console.clear");
    }

    public IJSConsoleCounter CreateCounter(string? label = null)
    {
        return new ConsoleCounter(JS, label ?? DefaultLabel);
    }

    public async Task DebugAsync(object? message)
    {
        await JS.InvokeVoidAsync("console.debug", message);
    }

    public async Task DebugAsync(IEnumerable<object?> messages)
    {
        await JS.InvokeVoidAsync("console.debug", messages);
    }

    public async Task DirAsync(object obj)
    {
        await JS.InvokeVoidAsync("console.dir", obj);
    }

    public async Task DirXmlAsync(object obj)
    {
        await JS.InvokeVoidAsync("console.dirxml", obj);
    }

    public async Task ErrorAsync(object? message)
    {
        await JS.InvokeVoidAsync("console.error", message);
    }

    public async Task ErrorAsync(IEnumerable<object?> messages)
    {
        await JS.InvokeVoidAsync("console.error", messages);
    }

    public async Task GroupAsync(string? label = null)
    {
        if (label == null)
        {
            await JS.InvokeVoidAsync("console.group");
        }
        else
        {
            await JS.InvokeVoidAsync("console.group", label);
        }
    }

    public async Task GroupCollapsedAsync(string? label = null)
    {
        if (label == null)
        {
            await JS.InvokeVoidAsync("console.groupCollapsed");
        }
        else
        {
            await JS.InvokeVoidAsync("console.groupCollapsed", label);
        }
    }

    public async Task GroupEndAsync()
    {
        await JS.InvokeVoidAsync("console.groupEnd");
    }

    public async Task InfoAsync(object? message)
    {
        await JS.InvokeVoidAsync("console.info", message);
    }

    public async Task InfoAsync(IEnumerable<object?> messages)
    {
        await JS.InvokeVoidAsync("console.info", messages);
    }

    public async Task LogAsync(object? message)
    {
        await JS.InvokeVoidAsync("console.log", message);
    }

    public async Task LogAsync(IEnumerable<object?> messages)
    {
        await JS.InvokeVoidAsync("console.log", messages);
    }

    public async Task TableAsync(IEnumerable<object> data)
    {
        await JS.InvokeVoidAsync("console.table", data);
    }

    public IJSConsoleTimer CreateTimer(string? label = null)
    {
        return new ConsoleTimer(JS, label ?? DefaultLabel);
    }

    public async Task TraceAsync()
    {
        await JS.InvokeVoidAsync("console.trace");
    }

    public async Task TraceAsync(object? message)
    {
        await JS.InvokeVoidAsync("console.trace", message);
    }

    public async Task TraceAsync(IEnumerable<object?> messages)
    {
        await JS.InvokeVoidAsync("console.trace", messages);
    }

    public async Task WarnAsync(object? message)
    {
        await JS.InvokeVoidAsync("console.warn", message);
    }

    public async Task WarnAsync(IEnumerable<object?> messages)
    {
        await JS.InvokeVoidAsync("console.warn", messages);
    }
}
