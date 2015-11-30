// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inventory.cs" company="HotR">
//   2015
// </copyright>
// <summary>
//   The Inventory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HomeOnTheRange.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The Inventory.
    /// </summary>
    public class InventoryModels
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [Key()]
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets Product.
        /// </summary>
        [Required()]
        [Display(Name="Product Name")]
        [StringLength(100, MinimumLength = 3)]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets Brand Name.
        /// </summary>
        [Display(Name = "Brand Name")]
        [StringLength(100, MinimumLength = 3)]
        public string BrandName { get; set; }

        /// <summary>
        /// Gets or sets Purchase Date.
        /// </summary>
        [Display(Name= "Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Gets or sets Expiration Date.
        /// </summary>
        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [StringLength(50, MinimumLength = 3)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Property.
        /// </summary>
        [StringLength(50, MinimumLength = 3)]
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public string Description { get; set; }
    }
}