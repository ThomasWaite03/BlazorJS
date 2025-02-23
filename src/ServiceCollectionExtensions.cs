using BlazorJS.Internals;
using BlazorJS.Internals.Clipboard;
using BlazorJS.Internals.Console;
using BlazorJS.Internals.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BlazorJS;

public static class ServiceCollectionExtensions
{
    public static void AddBlazorJS(this IServiceCollection services)
    {
        services.AddJSConsole();
        services.AddSessionStorage();
        services.AddLocalStorage();
        services.AddClipboard();
    }

    public static void AddJSConsole(this IServiceCollection services)
    {
        services.TryAddScoped<JSInvoker>();

        services.AddScoped<IJSConsole, JSConsole>();
    }

    public static void AddSessionStorage(this IServiceCollection services)
    {
        services.TryAddScoped<JSInvoker>();

        services.AddScoped<ISessionStorage, SessionStorage>();
    }

    public static void AddLocalStorage(this IServiceCollection services)
    {
        services.TryAddScoped<JSInvoker>();

        services.AddScoped<ILocalStorage, LocalStorage>();
    }

    public static void AddClipboard(this IServiceCollection services)
    {
        services.TryAddScoped<JSInvoker>();

        services.AddScoped<IClipboard, Clipboard>();
    }
}
