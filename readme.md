# Blazor Render Mode Detection

The `Marimer.Blazor.RenderMode` library provides a simple way to detect the current render mode of a Blazor application.

## Installation

You can install the library via NuGet. Run the following command:

```
dotnet add package Marimer.Blazor.RenderMode
```

## Usage

The library provides a `RenderModeProvider` service that you can inject into your components. The service has a single method `GetRenderMode` that returns the current render mode for the current page or component.

```csharp
@inject RenderModeProvider RenderMode
@using Marimer.Blazor.RenderMode

var mode = RenderMode.GetRenderMode(this);

@if (mode.IsInteractive && mode.IsServer)
{
    <p>This is a server interactive Blazor page</p>
}
else if (mode.IsInteractive && mode.IsWebAssembly)
{
    <p>This is a WebAssembly interactive Blazor page</p>
}
else if (mode.IsServer && mode.IsStreaming)
{
    <p>This is a streaming server static Blazor page</p>
}
else
{
    <p>This is a server static Blazor page</p>
}
```
