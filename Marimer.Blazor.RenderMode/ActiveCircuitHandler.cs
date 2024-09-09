//-----------------------------------------------------------------------
// <copyright file="ActiveCircuitHandler.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Service that detects whether an active SignalR circuit exists</summary>
//-----------------------------------------------------------------------
namespace Marimer.Blazor.RenderMode;

using Microsoft.AspNetCore.Components.Server.Circuits;

/// <summary>
/// Service that detects whether an active SignalR circuit exists.
/// </summary>
/// <param name="state">ActiveCircuitState service</param>
public class ActiveCircuitHandler(ActiveCircuitState state) : CircuitHandler
{
    /// <summary>
    /// Detects an open circuit.
    /// </summary>
    /// <param name="circuit">Circuit object</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns></returns>
    public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        state.CircuitExists = true;
        return base.OnCircuitOpenedAsync(circuit, cancellationToken);
    }

    /// <summary>
    /// Detects an closed circuit.
    /// </summary>
    /// <param name="circuit">Circuit object</param>
    /// <param name="cancellationToken">Cancellation token</param>
    public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        state.CircuitExists = false;
        return base.OnCircuitClosedAsync(circuit, cancellationToken);
    }
}
