// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 27-04-2022
// ***********************************************************************
// <copyright file="GeneralSpecification.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Ardalis.Specification;

namespace Application.Specifications
{
    /// <summary>
    /// Class GeneralSpecification.
    /// Implements the <see cref="Ardalis.Specification.Specification{T}" />
    /// Implements the <see cref="Ardalis.Specification.ISingleResultSpecification" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Ardalis.Specification.ISingleResultSpecification" />
    /// <seealso cref="Ardalis.Specification.Specification{T}" />
    public class GeneralSpecification<T> : Specification<T>, ISingleResultSpecification
    {
        
    }
}