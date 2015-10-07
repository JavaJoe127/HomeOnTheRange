// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="HotR">
//   2015
// </copyright>
// <summary>
//   The Repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HomeOnTheRange.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using Models;
    using System.Linq;

    /// <summary>
    /// The Repository.
    /// </summary>
    public class Repository<T> where T : class
    {
        /// <summary>
        /// The context.
        /// </summary>
        /// <returns>
        /// The <see cref="TheRangeDataContext"/>.
        /// </returns>
        private TheRangeDataContext context = new TheRangeDataContext();

        /// <summary>
        /// Gets or sets DB set.
        /// </summary>
        /// <returns>
        /// The <see cref="DbSet"/>.
        /// </returns>
        protected DbSet<T> DbSet { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        public Repository()
        {
            DbSet = context.Set<T>();
        }

        /// <inheritdoc />
        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        /// <inheritdoc />
        public T Get(Guid id)
        {
            return DbSet.Find(id);
        }

        /// <inheritdoc />
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        /// <inheritdoc />
        public void SaveChanges()
        {
            context.SaveChanges();
        }

        /// <inheritdoc />
        public void Remove(T template)
        {
            DbSet.Remove(template);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            context.Dispose();
        }
    }
}