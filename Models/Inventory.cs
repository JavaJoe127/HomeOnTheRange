using System;
using System.ComponentModel.DataAnnotations;

namespace HomeOnTheRange.Models
{
    public class Inventory
    {
        public Guid ID { get; set; }
        [Required()]
        [StringLength(100, MinimumLength = 3)]
        public string Product { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}