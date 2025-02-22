using Microsoft.JSInterop;

namespace BlazorJS.Apis;

internal class JSConsole : IJSConsole
{
    private readonly IJSRuntime JS;

    public JSConsole(IJSRuntime jsRuntime)
    {
        JS = jsRuntime;
    }

    public async Task AssertAsync(bool condition, params object[] messages)
    {
        await JS.InvokeVoidAsync("console.assert", condition, messages);
    }

    public async Task ClearAsync()
    {
        await JS.InvokeVoidAsync("console.clear");
    }

    public async Task CountAsync(string label = "default")
    {
        await JS.InvokeVoidAsync("console.count", label);
    }

    public async Task CountResetAsync(string label = "default")
    {
        await JS.InvokeVoidAsync("console.countReset", label);
    }

    public async Task DebugAsync(params object[] messages)
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

    public async Task ErrorAsync(params object[] messages)
    {
        await JS.InvokeVoidAsync("console.error", messages);
    }

    public async Task LogAsync(params object[] messages)
    {
        await JS.InvokeVoidAsync("console.log", messages);
    }
}
