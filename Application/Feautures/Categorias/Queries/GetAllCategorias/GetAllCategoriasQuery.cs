// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 27-04-2022
// ***********************************************************************
// <copyright file="GetAllFacturaQuery.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Application.DTOs;
using Application.Interfaces;
using Application.Specifications;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Feautures.Factura.Queries.GetAllCategorias
{

    /// <summary>
    /// Class GetAllCategoriasQuery.
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.CategoriaDto}}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.CategoriaDto}}}" />
    public class GetAllCategoriasQuery : IRequest<PagedResponse<List<CategoriaDto>>>
    {

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        /// <value>The page number.</value>
        public int PageNumber { get; set; }
        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        public int PageSize { get; set; }



        /// <summary>
        /// Class CategoriaQueryHandler.
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Book.Queries.GetAllFactura.GetAllFacturaQuery, Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.CategoriaDto}}}" />
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Factura.Queries.GetAllFactura.GetAllCategoriasQuery, Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.CategoriaDto}}}" />
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Factura.Queries.GetAllFactura.GetAllCategoriasQuery, Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.CategoriaDto}}}" />
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Book.Queries.GetAllFactura.GetAllFacturaQuery, Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.CategoriaDto}}}" />
        public class CategoriaQueryHandler : IRequestHandler<GetAllCategoriasQuery, PagedResponse<List<CategoriaDto>>>
        {

            /// <summary>
            /// The repository
            /// </summary>
            private readonly IRepositoryAsync<Domain.Entities.Categorias> _repository;
            /// <summary>
            /// The mapper
            /// </summary>
            private readonly IMapper _mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="CategoriaQueryHandler" /> class.
            /// </summary>
            /// <param name="repository">The repository.</param>
            /// <param name="mapper">The mapper.</param>
            public CategoriaQueryHandler(IRepositoryAsync<Domain.Entities.Categorias> repository, IMapper mapper)
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
            /// <exception cref="System.NotImplementedException"></exception>
            public async Task<PagedResponse<List<CategoriaDto>>> Handle(GetAllCategoriasQuery request, CancellationToken cancellationToken)
            {
                var categorias = await _repository.ListAsync(new PagedCategoriasSpecification(request.PageSize, request.PageNumber), cancellationToken);
                var categoriasDto = _mapper.Map<List<CategoriaDto>>(categorias).ToList();
                return new PagedResponse<List<CategoriaDto>>(categoriasDto, request.PageNumber, request.PageSize);
            }
        }
    }
}