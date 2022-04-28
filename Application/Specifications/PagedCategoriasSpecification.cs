// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 27-04-2022
// ***********************************************************************
// <copyright file="PagedFacturaSpecification.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Ardalis.Specification;
using Domain.Entities;

namespace Application.Specifications
{
    /// <summary>
    /// Class PagedFacturaSpecification.
    /// Implements the <see cref="Specification{Factura}" />
    /// Implements the <see cref="Ardalis.Specification.Specification{Domain.Entities.Book}" />
    /// Implements the <see cref="Ardalis.Specification.Specification{Domain.Entities.Categorias}" />
    /// </summary>
    /// <seealso cref="Ardalis.Specification.Specification{Domain.Entities.Categorias}" />
    /// <seealso cref="Ardalis.Specification.Specification{Domain.Entities.Book}" />
    /// <seealso cref="Specification{Factura}" />
    public class PagedCategoriasSpecification : Specification<Categorias>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedCategoriasSpecification" /> class.
        /// </summary>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="pageNumber">The page number.</param>
        public PagedCategoriasSpecification(int pageSize, int pageNumber)
        {
            Query.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }
    }
}