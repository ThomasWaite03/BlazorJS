using BlazorJS.Internals;
using BlazorJS.Internals.Clipboard;
using BlazorJS.Internals.Console;
using BlazorJS.Internals.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorJS;

public static class ServiceCollectionExtensions
{
    public static void AddBlazorJS(this IServiceCollection services)
    {
        services.AddScoped<JSInvoker>();

        services.AddScoped<IJSConsole, JSConsole>();
        services.AddScoped<ISessionStorage, SessionStorage>();
        services.AddScoped<ILocalStorage, LocalStorage>();
        services.AddScoped<IClipboard, Clipboard>();
    }
}
