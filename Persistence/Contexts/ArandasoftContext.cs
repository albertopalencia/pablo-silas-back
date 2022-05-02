// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 04-28-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="ArandasoftContext.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#nullable disable
using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 027-04-2022
// ***********************************************************************
// <copyright file="ArandasoftContext.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Persistence.Contexts
{
    /// <summary>
    /// Class ArandasoftContext.
    /// Implements the <see cref="Microsoft.EntityFrameworkCore.DbContext" />
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public partial class ArandasoftContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArandasoftContext"/> class.
        /// </summary>
        public ArandasoftContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArandasoftContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public ArandasoftContext(DbContextOptions<ArandasoftContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the categorias.
        /// </summary>
        /// <value>The categorias.</value>
        public virtual DbSet<Categorias> Categorias { get; set; }
        /// <summary>
        /// Gets or sets the productos.
        /// </summary>
        /// <value>The productos.</value>
        public virtual DbSet<Productos> Productos { get; set; }


        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run.</remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}