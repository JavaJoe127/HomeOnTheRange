namespace HomeOnTheRange.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Inventory
    {
        [Key()]
        public Guid ID { get; set; }

        [Required()]
        [Display(Name="Product Name")]
        [StringLength(100, MinimumLength = 3)]
        public string Product { get; set; }

        [Display(Name = "Brand Name")]
        [StringLength(100, MinimumLength = 3)]
        public string BrandName { get; set; }

        [Display(Name= "Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate { get; set; }

        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Type { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Property { get; set; }

        public string Description { get; set; }
    }
}