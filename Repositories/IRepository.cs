
namespace HomeOnTheRange.Repositories
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    interface IRepository
    {
        Task<List<TheRangeDataContext>> GetAll();

        TheRangeDataContext Get(Guid id);

        void Add(TheRangeDataContext entity);

        void SaveChanges();

        void Remove(TheRangeDataContext template);

        void Dispose();
    }
}
