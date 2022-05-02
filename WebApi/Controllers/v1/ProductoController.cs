// ***********************************************************************
// Assembly         : WebApi
// Author           : alberto palencia
// Created          : 04-28-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-30-2022
// ***********************************************************************
// <copyright file="ProductoController.cs" company="WebApi">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Application.Feautures.Editorial.Queries.GetAllProducto;
using Application.Feautures.Producto.Commands.CreateProductoCommand;
using Application.Feautures.Producto.Commands.DeleteProductoCommand;
using Application.Feautures.Producto.Commands.EditProductoCommand;
using Application.Feautures.Productos.Queries.GetAllProducto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers.v1
{
    /// <summary>
    /// Class ProductoController.
    /// Implements the <see cref="WebApi.Controllers.BaseApiController" />
    /// </summary>
    /// <seealso cref="WebApi.Controllers.BaseApiController" />
    [ApiVersion("1.0")]
    public class ProductoController : BaseApiController
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductoParameters filter)
        {
            return Ok(await Mediator.Send(new GetAllProductoQuery { 
                Nombre = filter.Nombre, 
                Descripcion = filter.Descripcion, 
                Categoria = filter.Categoria, 
                PageSize = filter.PageSize, 
                PageNumber = filter.PageNumber 
            }));
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetByProductoIdQuery { Id = id }));
        }

        /// <summary>
        /// Posts the specified command.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        /// <summary>
        /// Puts the specified command.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] EditProductoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteProductoCommand { Id = id }));
        }
    }
}