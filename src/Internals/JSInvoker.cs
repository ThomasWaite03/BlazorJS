using Microsoft.JSInterop;
using Microsoft.JSInterop.Infrastructure;

namespace BlazorJS.Internals;

internal class JSInvoker
{
    private readonly IJSRuntime JS;

    internal JSInvoker(IJSRuntime jsRuntime)
    {
        JS = jsRuntime;
    }

    internal async Task InvokeVoidAsync(string identifier)
    {
        await JS.InvokeVoidAsync(identifier);
    }

    internal async Task InvokeVoidAsync(string identifier, object? arg)
    {
        await JS.InvokeAsync<IJSVoidResult>(identifier, arg);
    }

    internal async Task InvokeVoidAsync(string identifier, IEnumerable<object?> args)
    {
        await JS.InvokeAsync<IJSVoidResult>(identifier, args?.ToArray());
    }
}
