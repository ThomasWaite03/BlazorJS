using Microsoft.JSInterop;

namespace BlazorJS.Internals.Console;

internal class ConsoleTimer : IConsoleTimer
{
    private readonly JSInvoker JS;
    private readonly string _label;

    internal ConsoleTimer(JSInvoker jsInvoker, string label)
    {
        JS = jsInvoker;
        _label = label;
    }

    public async Task StartAsync()
    {
        await JS.InvokeVoidAsync("console.time", _label);
    }

    public async Task LogAsync()
    {
        await JS.InvokeVoidAsync("console.timeLog", _label);
    }

    public async Task LogAsync(object? message)
    {
        await JS.InvokeVoidAsync("console.timeLog", message);
    }

    public async Task LogAsync(IEnumerable<object?> messages)
    {
        List<object?> args = [_label];
        args.AddRange(messages);

        await JS.InvokeVoidAsync("console.timeLog", args);
    }

    public async Task EndAsync()
    {
        await JS.InvokeVoidAsync("console.timeEnd", _label);
    }
}
