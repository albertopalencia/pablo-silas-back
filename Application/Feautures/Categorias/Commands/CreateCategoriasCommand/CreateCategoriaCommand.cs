// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 27-04-2022
// ***********************************************************************
// <copyright file="CreateCategoriaCommand.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Wrappers;
using MediatR;

namespace Application.Feautures.Factura.Commands.CreateCategoriaCommand
{
    /// <summary>
    /// Class CreateCategoriaCommand.
    /// Implements the <see cref="MediatR.IRequest{Response{int}}" />
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// <seealso cref="MediatR.IRequest{Response{int}}" />
    public class CreateCategoriaCommand : IRequest<Response<int>>
    {

        public string Nombre { get; set; }

        public bool Estado { get; set; }

        /// <summary>
        /// Class CreateCategoriaCommandHandler.
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Factura.Commands.CreateCategoriaCommand.CreateCategoriaCommand, Application.Wrappers.Response{System.Int32}}" />
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Factura.Commands.CreateCategoriaCommand.CreateCategoriaCommand, Application.Wrappers.Response{System.Int32}}" />
        public class CreateCategoriaCommandHandler : IRequestHandler<CreateCategoriaCommand, Response<int>>
        {
            /// <summary>
            /// The repository
            /// </summary>
            private readonly IRepositoryAsync<Domain.Entities.Categorias> _repository;

            /// <summary>
            /// Initializes a new instance of the <see cref="CreateCategoriaCommandHandler" /> class.
            /// </summary>
            /// <param name="repository">The repository.</param>
            public CreateCategoriaCommandHandler(IRepositoryAsync<Domain.Entities.Categorias> repository)
            {
                _repository = repository;
            }

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>Response from the request</returns>
            public async Task<Response<int>> Handle(CreateCategoriaCommand request, CancellationToken cancellationToken)
            {
                var categoria = new Domain.Entities.Categorias(request.Nombre, request.Estado);
                await _repository.AddAsync(categoria, cancellationToken);
                return new Response<int>(categoria.Id);
            }
        }
    }
}