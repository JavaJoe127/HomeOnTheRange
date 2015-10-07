// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TheRangeDataContext.cs" company="HotR">
//   2015
// </copyright>
// <summary>
//   The Range Data Context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HomeOnTheRange.Models
{
    using System.Data.Entity;
    using System.Diagnostics;

    /// <summary>
    /// The Range Data Context.
    /// </summary>
    public class TheRangeDataContext : DbContext
    {
        /// <summary>
        /// The Inventory data context.
        /// </summary>
        /// <returns>
        /// The <see cref="Inventory"/>.
        /// </returns>
        public DbSet<Inventory> Inventory { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TheRangeDataContext"/> class.
        /// </summary>
        public TheRangeDataContext()
        {
            // display SQL to Output window
            Debug.WriteLine(Database.Connection.ConnectionString);
            Database.Log = s => Debug.WriteLine(s);
        }
    }
}