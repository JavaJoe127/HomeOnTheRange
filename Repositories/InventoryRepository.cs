namespace HomeOnTheRange.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public class InventoryRepository : Repository<Inventory>
    {
        public List<Inventory> GetByType(string type)
        {
            return DbSet.Where(a => a.Type.Contains(type)).ToList();
        }

        public List<Inventory> GetByProperty(string property)
        {
            return DbSet.Where(a => a.Property.Contains(property)).ToList();
        }

        public void Save<T>(T template) where T : class
        {
            TheRangeDataContext context = new TheRangeDataContext();

            context.Set<T>().Attach(template);
            context.Entry(template).State = EntityState.Modified;

            context.SaveChangesAsync();
        }
    }
}