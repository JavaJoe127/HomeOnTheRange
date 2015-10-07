// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="HotR">
//   2015
// </copyright>
// <summary>
//   The Repository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HomeOnTheRange.Repositories
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// The Repository interface.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// The Get All.
        /// </summary>
        /// <returns>
        /// The <see cref="TheRangeDataContext"/>.
        /// </returns>
        Task<List<TheRangeDataContext>> GetAll();

        /// <summary>
        /// The Get.
        /// </summary>
        /// <param name="id">
        /// The Id.
        /// </param>
        /// <returns>
        /// The <see cref="TypTheRangeDataContexte"/>.
        /// </returns>
        TheRangeDataContext Get(Guid id);

        /// <summary>
        /// The Add.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Add(TheRangeDataContext entity);

        /// <summary>
        /// The Save Changes.
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// The Remove.
        /// </summary>
        /// <param name="template">
        /// The template.
        /// </param>
        void Remove(TheRangeDataContext template);

        /// <summary>
        /// The Dispose.
        /// </summary>
        void Dispose();
    }
}
