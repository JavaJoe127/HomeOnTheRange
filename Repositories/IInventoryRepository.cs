namespace HomeOnTheRange.Repositories
{
    using System.Collections.Generic;

    using Models;

    interface IInventoryRepository
    {
        List<Inventory> GetByType(string type);

        List<Inventory> GetByProperty(string property);

        void Save<T>(T template) where T : class;
    }
}
