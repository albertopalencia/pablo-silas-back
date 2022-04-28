// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 01-06-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 01-06-2022
// ***********************************************************************
// <copyright file="FacturaConfiguration.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Persistence.Configuration
{
    /// <summary>
    /// Class FacturaConfiguration.
    /// Implements the <see cref="Microsoft.EntityFrameworkCore.IEntityTypeConfiguration{Factura}" />
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.IEntityTypeConfiguration{Factura}" />
    public class CategoriasConfiguration : IEntityTypeConfiguration<Domain.Entities.Categorias>
    {
        /// <summary>
        /// Configures the entity of type <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<Domain.Entities.Categorias> builder)
         {
            builder.ToTable("Categorias");
            builder.HasKey("Id");
            builder.Property(x => x.Id);
            builder.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.Property(x => x.Estado);
                    
        }
    }
}
