namespace BlazorJS.Internals.Clipboard;

internal class Clipboard : IClipboard
{
    private readonly JSInvoker JS;

    public Clipboard(JSInvoker invoker)
    {
        JS = invoker;
    }

    public async Task<string?> ReadTextAsync()
    {
        return await JS.InvokeAsync<string>("navigator.clipboard.readText");
    }

    public async Task WriteTextAsync(string text)
    {
        await JS.InvokeVoidAsync("navigator.clipboard.writeText", text);
    }
}
