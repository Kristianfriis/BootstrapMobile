# BootstrapMobile Components WIP

A demo can be seen here: [Demo](https://brave-pebble-064b1ad03.3.azurestaticapps.net)

## Prerequisities
| BootstrapMobile Components| .NET | Support |
| :--- | :---: | :---: |
| 6.0.x | [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) | :heavy_check_mark: |
| 6.1.x | [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) & [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) | :heavy_check_mark: |

### Quick Installation Guide
Install Package
```
dotnet add package BootstrapMobile.Components
```
Add the following to `_Imports.razor`
```razor
@using BlazorBeerCss
```
Change the article tag to below in the `MainLayout.razor` or `App.razor`
```razor
<BApp>
  @Body
 </BApp>
```
Add the following to `index.html` (client-side) or `_Host.cshtml` (server-side) in the `head`
```razor
    <link href="_content/BootstrapMobile.Components/css/bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="_content/BootstrapMobile.Components/css/app.css" rel="stylesheet" />
```

Add the following to `index.html` (client-side) or `_Host.cshtml` (server-side) in the end of `body`
```razor
    <script src="_content/BootstrapMobile.Components/css/bootstrap/bootstrap.bundle.min.js"></script>
    <script src="_content/BootstrapMobile.Components/BootstrapMobile.js?5"></script>
```
Add the following to the relevant sections of `Program.cs`
```c#
using BootstrapMobile.Components;
```
```c#
builder.Services.AddBootstrapMobile();
builder.Services.AddScoped<BToastService>();
```
### Optional
Remove unused css in wwwwroot/css and remove the scaffolded css from MainLayout.razor.css and NavMenu.razor.css 