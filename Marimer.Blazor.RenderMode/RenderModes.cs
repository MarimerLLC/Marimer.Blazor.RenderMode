//-----------------------------------------------------------------------
// <copyright file="RenderMode.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>List of render modes</summary>
//-----------------------------------------------------------------------
namespace Marimer.Blazor.RenderMode;

/// <summary>
/// List of render modes
/// </summary>
public enum RenderMode
{
    Unknown,
    ServerStatic,
    ServerStaticStreaming,
    ServerInteractive,
    WebAssemblyInteractive
}

/// <summary>
/// Extension methods for the RenderMode enum
/// </summary>
public static class RenderModeFlagsExtensions
{
    /// <summary>
    /// Gets a value indicating if the render mode is server-side
    /// </summary>
    /// <param name="mode">RenderMode value</param>
    /// <returns></returns>
    public static bool IsServer(this RenderMode mode)
    {
        return mode.ToString().Contains("Server");
    }

    /// <summary>
    /// Gets a value indicating if the render mode is WebAssembly
    /// </summary>
    /// <param name="mode">RenderMode value</param>
    /// <returns></returns>
    public static bool IsWebAssembly(this RenderMode mode)
    {
        return mode == RenderMode.WebAssemblyInteractive;
    }

    /// <summary>
    /// Gets a value indicating if the render mode is interactive
    /// </summary>
    /// <param name="mode">RenderMode value</param>
    /// <returns></returns>
    public static bool IsInteractive(this RenderMode mode)
    {
        return mode.ToString().Contains("Interactive");
    }

    /// <summary>
    /// Gets a value indicating if the render mode is streaming
    /// </summary>
    /// <param name="mode">RenderMode value</param>
    /// <returns></returns>
    public static bool IsStreaming(this RenderMode mode)
    {
        return mode == RenderMode.ServerStaticStreaming;
    }
}
