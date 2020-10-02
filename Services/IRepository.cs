﻿// ***********************************************************************
// Assembly         : StarWarsApiCSharp
// Author           : M.Yankov
// Created          : 02-06-2016
//
// Last Modified By : M.Yankov
// Last Modified On : 03-17-2016
// ***********************************************************************
// <copyright file="IRepository.cs" company="M-Yankov">
//     Copyright ©  2016
// </copyright>
// <summary>Contains generic repository interface.</summary>
// ***********************************************************************
namespace BlazerMovies.Services
{
    using BlazerMovies.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface IRepository
    /// </summary>
    /// <typeparam name="T"><see cref="StarWarsApiCSharp.BaseEntity" />Base entity.</typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Gets the entity by it's identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><see cref="StarWarsApiCSharp.BaseEntity" />Base entity.</returns>
        Task<T> GetById(int id);
        /// <summary>
        /// Gets the entity by it's identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><see cref="StarWarsApiCSharp.BaseEntity" />Base entity.</returns>
        Task<T> GetByUrl(string url);

        /// <summary>
        /// Gets entities.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="size">The size of entities.</param>
        /// <returns>ICollection&lt; <see cref="StarWarsApiCSharp.BaseEntity" /> &gt;.</returns>
        Task<ICollection<T>> GetEntities(int page = 1, int size = 10);
    }
}
