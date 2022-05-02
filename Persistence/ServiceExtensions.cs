// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 04-28-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="ServiceExtensions.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repository;

namespace Persistence
{
    /// <summary>
    /// Class ServiceExtensions.
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Adds the persistence infraestructure.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ArandasoftContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("ArandaSoft"),
                b => b.MigrationsAssembly(typeof(ArandasoftContext).Assembly.FullName)
            ));

            #region Repositories

            services.AddTransient(typeof(IRepositoryAsync<>), typeof(MyRepositoryAsync<>));

            #endregion
        }
    }
}