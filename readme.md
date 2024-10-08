# Blazor Render Mode Detection

The `Marimer.Blazor.RenderMode` library provides a simple way to detect the current render mode of a Blazor application.

## Installation

You can install the library via NuGet. Run the following command for a Blazor Server project:

```
dotnet add package Marimer.Blazor.RenderMode
```

For a Blazor WebAssembly project or Razor Class Library, run the following command:

```
dotnet add package Marimer.Blazor.RenderMode.WebAssembly
```

In `Program.cs`, add the following line to register the service:

```csharp
builder.Services.AddRenderModeDetection();
```

When using a Razor Class Library that may be loaded in WebAssembly, make sure to add that registration to the client-side `Program.cs` as well.

## Usage

The library provides a `RenderModeProvider` service that you can inject into your components. The service has a single method `GetRenderMode` that returns the current render mode for the current page or component.

```csharp
@inject RenderModeProvider RenderMode
@using Marimer.Blazor.RenderMode

var mode = RenderMode.GetRenderMode(this);

@if (mode.IsInteractive() && mode.IsServer())
{
    <p>This is a server interactive Blazor page</p>
}
else if (mode.IsWebAssembly())
{
    <p>This is a WebAssembly interactive Blazor page</p>
}
else if (mode.IsServer() && mode.IsStreaming())
{
    <p>This is a streaming server static Blazor page</p>
}
else
{
    <p>This is a server static Blazor page</p>
}
```
