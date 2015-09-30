﻿using System.Data.Entity;
using System.Diagnostics;

namespace HomeOnTheRange.Models
{
    public class TheRangeDataContext : DbContext
    {
        public DbSet<Inventory> Inventory { get; set; }

        public TheRangeDataContext()
        {
            // display SQL to Output window
            Debug.WriteLine(Database.Connection.ConnectionString);
            Database.Log = s => Debug.WriteLine(s);
        }
    }
}