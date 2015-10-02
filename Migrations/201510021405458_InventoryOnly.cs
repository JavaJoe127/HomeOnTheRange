namespace HomeOnTheRange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InventoryOnly : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Product = c.String(nullable: false, maxLength: 100),
                        BrandName = c.String(maxLength: 100),
                        PurchaseDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.String(maxLength: 50),
                        Property = c.String(maxLength: 50),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inventories");
        }
    }
}
