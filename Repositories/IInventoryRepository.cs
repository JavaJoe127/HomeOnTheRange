// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInventoryRepository.cs" company="HotR">
//   2015
// </copyright>
// <summary>
//   The Inventory Repository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HomeOnTheRange.Repositories
{
    using System.Collections.Generic;

    using Models;

    /// <summary>
    /// The Inventory Repository interface.
    /// </summary>
    public interface IInventoryRepository
    {
        /// <summary>
        /// The Get By Type.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="Inventory"/>.
        /// </returns>
        List<Inventory> GetByType(string type);

        /// <summary>
        /// The Get By Property.
        /// </summary>
        /// <param name="property">
        /// The property.
        /// </param>
        /// <returns>
        /// The <see cref="Inventory"/>.
        /// </returns>
        List<Inventory> GetByProperty(string property);

        /// <summary>
        /// The Save.
        /// </summary>
        /// <param name="template">
        /// The template.
        /// </param>
        void Save<T>(T template) where T : class;
    }
}
