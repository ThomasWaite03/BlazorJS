namespace BlazorJS;

public interface IClipboard
{
    Task<string?> ReadTextAsync();

    Task WriteTextAsync(string text);
}
