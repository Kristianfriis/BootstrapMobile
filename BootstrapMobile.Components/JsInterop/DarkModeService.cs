using BootstrapMobile.Components.Enums;
using Microsoft.JSInterop;

namespace BootstrapMobile.Components.JsInterop;

public class DarkModeService
{
    private readonly IJSRuntime _runtime;

    public DarkModeService(IJSRuntime runtime)
    {
        _runtime = runtime;
    }

    public async Task ToggleDarkMode(ColorMode colorMode)
    {
        var useDarkMode = colorMode == ColorMode.Dark;
        var automatic = colorMode == ColorMode.Automatic;
        await _runtime.InvokeVoidAsync("toggleDarkMode", useDarkMode, automatic);
    }
}
