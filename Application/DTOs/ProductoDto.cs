﻿// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 27-04-2022
// ***********************************************************************
// <copyright file="ProductoDto.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Application.DTOs
{
    /// <summary>
    /// Class ProductoDto.
    /// </summary>
    public class ProductoDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        /// 
        public CategoriaDto Categorias { get; set; }
        public string Nombre { get; set; }

        public int IdCategoria { get; set; }
 

        public string Descripcion { get; set; }
    }
}