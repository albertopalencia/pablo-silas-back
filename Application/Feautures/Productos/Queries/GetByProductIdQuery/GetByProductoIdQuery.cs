// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 27-04-2022
// ***********************************************************************
// <copyright file="GetAllProductoQuery.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Application.Feautures.Editorial.Queries.GetAllProducto
{

    /// <summary>
    /// Class GetAllProductoQuery.
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.Response{System.Collections.Generic.List{Application.DTOs.ProductoDto}}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.Response{System.Collections.Generic.List{Application.DTOs.ProductoDto}}}" />
    public class GetByProductoIdQuery: IRequest<Response<ProductoDto>>
    {

        public int Id { get; set; }

        /// <summary>
        /// Class GetAllEditorialQueryHandler.
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Editorial.Queries.GetAllProducto.GetByProductoIdQuery, Application.Wrappers.Response{System.Collections.Generic.List{Application.DTOs.ProductoDto}}}" />
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Editorial.Queries.GetAllProducto.GetByProductoIdQuery, Application.Wrappers.Response{System.Collections.Generic.List{Application.DTOs.ProductoDto}}}" />
        public class ProductoQueryHandler : IRequestHandler<GetByProductoIdQuery, Response<ProductoDto>>
        {
            /// <summary>
            /// The repository
            /// </summary>
            private readonly IRepositoryAsync<Domain.Entities.Productos> _repository;
            /// <summary>
            /// The mapper
            /// </summary>
            private readonly IMapper _mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="ProductoQueryHandler" /> class.
            /// </summary>
            /// <param name="repository">The repository.</param>
            /// <param name="mapper">The mapper.</param>
            public ProductoQueryHandler(IRepositoryAsync<Domain.Entities.Productos> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            /// <summary>
            /// Handles the specified request.
            /// </summary>
            /// <param name="request">The request.</param>
            /// <param name="cancellationToken">The cancellation token.</param>
            /// <returns>Task&lt;Response&lt;List&lt;ProductoDto&gt;&gt;&gt;.</returns>
            public async Task<Response<ProductoDto>> Handle(GetByProductoIdQuery request, CancellationToken cancellationToken)
            {
                var producto = await _repository.ListAsync(new Specifications.ProductoIncludeSpecification(), cancellationToken);                
                var productoDto = _mapper.Map<ProductoDto>(producto);
                return new Response<ProductoDto>(productoDto);
            }
        }
    }
}