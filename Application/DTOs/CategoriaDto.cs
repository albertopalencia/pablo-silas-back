// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 27-07-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="CategoriaDto.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Application.DTOs
{
    /// <summary>
    /// Class FacturaDto.
    /// </summary>
    public class CategoriaDto
    {

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }


        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get; set; }


        /// <summary>
        /// Gets or sets the estado.
        /// </summary>
        /// <value>The estado.</value>
        public string Estado { get; set; }


    }
}