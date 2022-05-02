// ***********************************************************************
// Assembly         : WebApi
// Author           : alberto palencia
// Created          : 04-28-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 01-07-2022
// ***********************************************************************
// <copyright file="ServiceExtensions.cs" company="WebApi">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
    /// <summary>
    /// Class ServiceExtensions.
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Adds the API versioning extensions.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddApiVersioningExtensions(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }
    }
}