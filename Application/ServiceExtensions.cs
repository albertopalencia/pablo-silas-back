// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 27-04-2022
// ***********************************************************************
// <copyright file="ServiceExtensions.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Application.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    /// <summary>
    /// Class ServiceExtensions.
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Adds the aplication layer.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddAplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}
