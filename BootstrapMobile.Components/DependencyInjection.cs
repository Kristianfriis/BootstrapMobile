using BootstrapMobile.Components.JsInterop;
using BootstrapMobile.JsInterop;
using Microsoft.Extensions.DependencyInjection;

namespace BootstrapMobile.Components;

public static class DependencyInjection
{
    public static IServiceCollection AddBootstrapMobile(this IServiceCollection services)
    {
        return services
            .AddScoped<DarkModeService>()
            .AddScoped<MobileBootstrapInterop>();
    }
}
