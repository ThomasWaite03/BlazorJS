using BlazorJS.Apis;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorJS;

public static class ServiceCollectionExtensions
{
    public static void AddBlazorJS(this IServiceCollection services)
    {
        services.AddScoped<IJSConsole, JSConsole>();
    }
}
