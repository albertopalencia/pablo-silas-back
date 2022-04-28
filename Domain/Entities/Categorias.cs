// ***********************************************************************
// Assembly         : Domain
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 27-04-2022
// ***********************************************************************
// <copyright file="Categorias.cs" company="Domain">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;

namespace Domain.Entities
{
    /// <summary>
    /// Class Factura.
    /// </summary>
    public class Categorias
    {

        public Categorias(string nombre, bool estado)
        {
            Nombre = nombre;
            Estado = estado;
        }

        public Categorias()
        {
            Productos = new HashSet<Productos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }

    }
}
