//-----------------------------------------------------------------------
// <copyright file="RenderModeProvider.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Service that provides the render mode</summary>
//-----------------------------------------------------------------------
using Microsoft.AspNetCore.Components;

namespace Marimer.Blazor.RenderMode;

/// <summary>
/// Service that provides the render mode.
/// </summary>
/// <param name="activeCircuitState">ActiveCircuitState service</param>
public class RenderModeProvider(ActiveCircuitState activeCircuitState)
{
    /// <summary>
    /// Gets the render mode for the specified page.
    /// </summary>
    /// <param name="page">Current page.</param>
    public RenderMode GetRenderMode(ComponentBase page)
    {
        RenderMode result = RenderMode.ServerStatic;
        var isBrowser = OperatingSystem.IsBrowser();
        if (isBrowser)
            result = RenderMode.WebAssemblyInteractive;
        else if (activeCircuitState.CircuitExists)
            result = RenderMode.ServerInteractive;
        else if (page.GetType().GetCustomAttributes(typeof(StreamRenderingAttribute), true).Length > 0)
            result = RenderMode.ServerStaticStreaming;
        return result;
    }
}
