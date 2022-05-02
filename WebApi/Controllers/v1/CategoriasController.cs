// ***********************************************************************
// Assembly         : WebApi
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="CategoriasController.cs" company="WebApi">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Application.Feautures.Factura.Commands.CreateCategoriaCommand;
using Application.Feautures.Factura.Queries.GetAllCategorias;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers.v1
{
    /// <summary>
    /// Categoria's api
    /// Implements the <see cref="WebApi.Controllers.BaseApiController" />
    /// </summary>
    /// <seealso cref="WebApi.Controllers.BaseApiController" />
    [ApiVersion("1.0")]
    public class CategoriasController : BaseApiController
    {
        #region Methods
        /// <summary>
        /// Gets the specified filter.`
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>IActionResult.</returns>
        /// +-
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCategoriasParameters filter)
        {
            return Ok(await Mediator.Send(new GetAllCategoriasQuery { PageSize = filter.PageSize, PageNumber = filter.PageNumber }));
        }


        /// <summary>
        /// Posts the specified command.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>IActionResult.</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoriaCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        #endregion
    }
}