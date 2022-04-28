// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 01-06-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 01-06-2022
// ***********************************************************************
// <copyright file="EditorialConfiguration.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{ 
    public class ProductoConfiguration : IEntityTypeConfiguration<Productos>
    {
        /// <summary>
        /// Configures the entity of type <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<Productos> builder)
        {
            builder.ToTable("Productos");
            builder.HasKey("Id");
            builder.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false);

            builder.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            builder.HasOne(d => d.Categorias)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Productos_Categorias");            

        }
    }
}
