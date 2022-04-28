// ***********************************************************************
// Assembly         : Domain
// Author           : alberto palencia
// Created          : 01-06-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-26-2022
// ***********************************************************************
// <copyright file="Productos.cs" company="Domain">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Domain.Entities
{
    /// <summary>
    /// Class Productos.
    /// </summary>
    public class Productos
    {
        public Productos()
        {

        }
        
        public Productos(string nombre, int idCategoria, string descripcion) 
        {
            this.Nombre = nombre;
            this.IdCategoria = idCategoria;
            this.Descripcion = descripcion;
            this.Estado = true;
        }

        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public virtual Categorias Categorias { get; set; } 

    }
}
