// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInventoryRepository.cs" company="HotR">
//   2015
// </copyright>
// <summary>
//   The Inventory Repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HomeOnTheRange.Repositories
{
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    /// <summary>
    /// The Inventory Repository.
    /// </summary>
    public class InventoryRepository : Repository<Inventory>
    {
        /// <inheritdoc />
        public List<Inventory> GetByType(string type)
        {
            return DbSet.Where(a => a.Type.Contains(type)).ToList();
        }

        /// <inheritdoc />
        public List<Inventory> GetByProperty(string property)
        {
            return DbSet.Where(a => a.Property.Contains(property)).ToList();
        }

        /// <inheritdoc />
        public void Save<T>(T template) where T : class
        {
            TheRangeDataContext context = new TheRangeDataContext();

            context.Set<T>().Attach(template);
            context.Entry(template).State = EntityState.Modified;

            context.SaveChangesAsync();
        }
    }
}