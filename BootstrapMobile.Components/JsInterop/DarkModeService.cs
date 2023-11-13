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

    public Action? OnToggleDarkmode;
    public Task<Action>? OnToggleDarkmodeAsync;
    public string ThemeColor { get; set; } = "";
    private void NotifyDarkmodeChange() => OnToggleDarkmode?.Invoke();

    public async Task ToggleDarkMode(ColorMode colorMode)
    {
        var useDarkMode = colorMode == ColorMode.Dark;
        var automatic = colorMode == ColorMode.Automatic;
        await _runtime.InvokeVoidAsync("toggleDarkMode", useDarkMode, automatic);
        await SetThemeColor();
        NotifyDarkmodeChange();
    }

    public async Task SetThemeColor() {
        ThemeColor = await _runtime.InvokeAsync<string>("getBackgroundColor");
    }
}
