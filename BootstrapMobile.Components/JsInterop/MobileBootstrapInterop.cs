using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BootstrapMobile.JsInterop;

public class MobileBootstrapInterop : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;
    private readonly IJSRuntime jsRuntime;

    public MobileBootstrapInterop(IJSRuntime jsRuntime)
    {
        this.jsRuntime = jsRuntime;
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/BootstrapMobile.Components/exampleJsInterop.js?2").AsTask());
    }

    public async ValueTask GoBack()
    {
        await jsRuntime.InvokeVoidAsync("window.history.back");
    }

    public async Task ToogleOffCanvas(ElementReference element)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("toggleOffCanvas", element);
    }

    public async Task SetThemeColor(string color)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("setThemeColor", color);
    }

    public async ValueTask DisposeAsync()
    {
        if (moduleTask.IsValueCreated)
        {
            var module = await moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}
