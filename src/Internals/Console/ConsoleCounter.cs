using System.Reflection.Emit;

namespace BlazorJS.Internals.Console;

internal class ConsoleCounter : IConsoleCounter
{
    private readonly JSInvoker JS;
    private readonly string _label;

    internal ConsoleCounter(JSInvoker jsInvoker, string label)
    {
        JS = jsInvoker;
        _label = label;
    }

    public async Task CountAsync()
    {
        await JS.InvokeVoidAsync("console.count", _label);
    }

    public async Task ResetAsync()
    {
        await JS.InvokeVoidAsync("console.countReset", _label);
    }
}
