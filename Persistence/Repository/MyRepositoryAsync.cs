﻿// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 27-04-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="MyRepositoryAsync.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Application.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository
{
    /// <summary>
    /// Class MyRepositoryAsync.
    /// Implements the <see cref="Ardalis.Specification.EntityFrameworkCore.RepositoryBase{T}" />
    /// Implements the <see cref="Application.Interfaces.IRepositoryAsync{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Ardalis.Specification.EntityFrameworkCore.RepositoryBase{T}" />
    /// <seealso cref="Application.Interfaces.IRepositoryAsync{T}" />
    public class MyRepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where  T : class
    {
        /// <summary>
        /// The database context
        /// </summary>
        private readonly ArandasoftContext _dbContext;
        /// <summary>
        /// Initializes a new instance of the <see cref="MyRepositoryAsync{T}" /> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public MyRepositoryAsync(ArandasoftContext dbContext): base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}