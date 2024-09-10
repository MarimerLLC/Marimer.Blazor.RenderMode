//-----------------------------------------------------------------------
// <copyright file="ActiveCircuitState.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Service that maintains the active circuit state</summary>
//-----------------------------------------------------------------------
namespace Marimer.Blazor.RenderMode;

/// <summary>
/// Service that maintains the active circuit state
/// </summary>
public class ActiveCircuitState
{
    /// <summary>
    /// Gets or sets a value indicating whether a SignalR
    /// circuit exists.
    /// </summary>
    public bool CircuitExists { get; set; }
}
