//-----------------------------------------------------------------------
// <copyright file="ConfigurationExtensions.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Extension methods for the RenderMode enum</summary>
//-----------------------------------------------------------------------
using Microsoft.Extensions.DependencyInjection;

namespace Marimer.Blazor.RenderMode.WebAssembly
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
            return services;
        }
    }
}
