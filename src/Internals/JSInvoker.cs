using Microsoft.JSInterop;
using Microsoft.JSInterop.Infrastructure;

namespace BlazorJS.Internals;

internal class JSInvoker
{
    private readonly IJSRuntime JS;

    public JSInvoker(IJSRuntime jsRuntime)
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

    internal async Task<T> InvokeAsync<T>(string identifier)
    {
        return await JS.InvokeAsync<T>(identifier);
    }

    internal async Task<T> InvokeAsync<T>(string identifier, object? arg)
    {
        return await JS.InvokeAsync<T>(identifier, arg);
    }

    internal async Task<T> InvokeAsync<T>(string identifier, IEnumerable<object?> args)
    {
        return await JS.InvokeAsync<T>(identifier, args);
    }
}
