using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BootstrapMobile.Components.JsInterop;

public class MobileBootstrapInterop : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public MobileBootstrapInterop(IJSRuntime jsRuntime)
    {
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/BootstrapMobile.Components/exampleJsInterop.js").AsTask());
    }

    public async ValueTask GoBack()
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("CanGoBack");
    }

    public async Task ToogleOffCanvas(ElementReference element)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("toggleOffCanvas", element);
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
