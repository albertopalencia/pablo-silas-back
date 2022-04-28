// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-24-2022
// ***********************************************************************
// <copyright file="IRepositoryAsync.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Ardalis.Specification;

namespace Application.Interfaces
{
    /// <summary>
    /// Interface IRepositoryAsync
    /// Implements the <see cref="Ardalis.Specification.IRepositoryBase{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Ardalis.Specification.IRepositoryBase{T}" />
    public interface IRepositoryAsync<T>: IRepositoryBase<T> where T : class
    {
        
    }
}