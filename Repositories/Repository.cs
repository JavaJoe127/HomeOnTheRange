
namespace HomeOnTheRange.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Threading.Tasks;

    using Models;

    public class Repository<T> where T : class
    {
        private TheRangeDataContext context = new TheRangeDataContext();

        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            DbSet = context.Set<T>();
        }

        public async Task<List<T>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public T Get(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Remove(T template)
        {
            DbSet.Remove(template);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}