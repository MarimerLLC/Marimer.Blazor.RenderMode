//-----------------------------------------------------------------------
// <copyright file="ConfigurationExtensions.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Extension methods for the RenderMode enum</summary>
//-----------------------------------------------------------------------
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.Extensions.DependencyInjection;

namespace Marimer.Blazor.RenderMode
{
    /// <summary>
    /// Extension methods for the RenderMode enum
    /// </summary>
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// Adds services required for render mode detection
        /// </summary>
        /// <param name="services">IServiceCollection instance</param>
        /// <returns></returns>
        public static IServiceCollection AddRenderModeDetection(this IServiceCollection services)
        {
            services.AddTransient<RenderModeProvider>();
            services.AddScoped<ActiveCircuitState>();
            var isBrowser = OperatingSystem.IsBrowser();
            if (!isBrowser)
            {
                services.AddScoped(typeof(CircuitHandler), typeof(ActiveCircuitHandler));
            }
            return services;
        }
    }
}
