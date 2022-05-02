// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 01-07-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="DeleteProductoCommand.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using MediatR;

namespace Application.Feautures.Producto.Commands.DeleteProductoCommand
{
    /// <summary>
    /// Class CreateFacturaCommand.
    /// Implements the <see cref="MediatR.IRequest{Response{int}}" />
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// <seealso cref="MediatR.IRequest{Response{int}}" />
    public class DeleteProductoCommand : IRequest<Response<int>>
    {

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }


        /// <summary>
        /// Class DeleteProductoCommandHandler.
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Producto.Commands.DeleteProductoCommand.DeleteProductoCommand, Application.Wrappers.Response{System.Int32}}" />
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Producto.Commands.DeleteProductoCommand.DeleteProductoCommand, Application.Wrappers.Response{System.Int32}}" />
        public class DeleteProductoCommandHandler : IRequestHandler<DeleteProductoCommand, Response<int>>
        {
            /// <summary>
            /// The repository
            /// </summary>
            private readonly IRepositoryAsync<Domain.Entities.Productos> _repository;


            /// <summary>
            /// Initializes a new instance of the <see cref="CreateProductoCommandHandler" /> class.
            /// </summary>
            /// <param name="repository">The repository.</param>
            public DeleteProductoCommandHandler(IRepositoryAsync<Domain.Entities.Productos> repository)
            {
                _repository = repository;
            }

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>Response from the request</returns>
            /// <exception cref="Application.Exceptions.ApiException">No se encontro el id: {request.Id}</exception>
            /// <exception cref="ApiException">No se encontro el id</exception>
            public async Task<Response<int>> Handle(DeleteProductoCommand request, CancellationToken cancellationToken)
            {
                var producto = await _repository.GetByIdAsync(request.Id, cancellationToken);
                if (producto == null) throw new ApiException($"No se encontro el id: {request.Id}");
                await _repository.DeleteAsync(producto, cancellationToken);
                return new Response<int>(producto.Id);
            }
        }
    }
}