// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 04-28-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-30-2022
// ***********************************************************************
// <copyright file="ProductoIncludeSpecification.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Ardalis.Specification;
using Domain.Entities;

namespace Application.Specifications
{
    /// <summary>
    /// Class ProductoIncludeSpecification.
    /// Implements the <see cref="Ardalis.Specification.Specification{Domain.Entities.Productos}" />
    /// </summary>
    /// <seealso cref="Ardalis.Specification.Specification{Domain.Entities.Productos}" />
    public class PagedProductoSpecification : Specification<Productos>
    { 

        /// <summary>
        /// Initializes a new instance of the <see cref="PAgedProductoSpecification"/> class.
        /// </summary>
        /// <param name="nombre">The nombre.</param>
        /// <param name="descripcion">The descripcion.</param>
        /// <param name="categoria">The categoria.</param>
        public PagedProductoSpecification(string nombre, string descripcion, string categoria, int pageSize, int pageNumber)
        {
            var query = Query.Include("Categorias");
            if (!string.IsNullOrEmpty(nombre))
            {
                query = query.Where(s => s.Nombre.Contains(nombre));
            }

            if (!string.IsNullOrEmpty( descripcion))
            {
                query = query.Where(s => s.Descripcion.Contains(descripcion));
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                query = query.Where(s => s.Categorias.Nombre.Contains(nombre));
            }

            query.Skip((pageNumber - 1) * pageSize)
               .Take(pageSize).OrderBy(s => s.Nombre);

        }
    }
}
