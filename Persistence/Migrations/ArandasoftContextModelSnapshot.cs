﻿// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 04-28-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="ArandasoftContextModelSnapshot.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

namespace Persistence.Migrations
{
    /// <summary>
    /// Class ArandasoftContextModelSnapshot.
    /// Implements the <see cref="Microsoft.EntityFrameworkCore.Infrastructure.ModelSnapshot" />
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.Infrastructure.ModelSnapshot" />
    [DbContext(typeof(ArandasoftContext))]
    partial class ArandasoftContextModelSnapshot : ModelSnapshot
    {
        /// <summary>
        /// Builds the model.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Domain.Entities.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1500)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Productos", b =>
                {
                    b.HasOne("Domain.Entities.Categorias", "IdCategoriaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK_Productos_Categorias")
                        .IsRequired();

                    b.Navigation("IdCategoriaNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Categorias", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
