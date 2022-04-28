// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 01-07-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 01-13-2022
// ***********************************************************************
// <copyright file="ClassEditProductosommand.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Feautures.Producto.Commands.EditProductoCommand
{
    /// <summary>
    /// ClassEditProductosommand.
    /// Implements the <see cref="MediatR.IRequest{Response{int}}" />
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// <seealso cref="MediatR.IRequest{Response{int}}" />
    public class EditProductoCommand: IRequest<Response<int>>
    {
        public int Id { get; set; }
         
        public string Nombre { get; set; }

        public int IdCategoria { get; set; }

        public string Descripcion { get; set; }
  

        public class EditProductoCommandHandler : IRequestHandler<EditProductoCommand, Response<int>>
        {
            /// <summary>
            /// The repository
            /// </summary>
            private readonly IRepositoryAsync<Domain.Entities.Productos> _repository;

            private readonly IMapper _mapper;


            /// <summary>
            /// Initializes a new instance of the <see cref="EditProductoCommandHandler"/> class.
            /// </summary>
            /// <param name="repository">The repository.</param>
            ///  /// <param name="mapper">The mapper.</param>
            public EditProductoCommandHandler(IRepositoryAsync<Domain.Entities.Productos> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>Response from the request</returns>
            /// <exception cref="ApiException">No se encontro el ido</exception>
            public async Task<Response<int>> Handle(EditProductoCommand  request, CancellationToken cancellationToken)
            {
                var producto = await _repository.GetByIdAsync(request.Id, cancellationToken);
                if (producto == null) throw new KeyNotFoundException($"No se encontro el id: {request.Id}");
                producto.Nombre = request.Nombre;
                producto.IdCategoria = request.IdCategoria != producto.IdCategoria ? request.IdCategoria : producto.IdCategoria;
                producto.Descripcion = request.Descripcion;
                await _repository.UpdateAsync(producto, cancellationToken);
                return new Response<int>(producto.Id);
            }
        }
    }
}