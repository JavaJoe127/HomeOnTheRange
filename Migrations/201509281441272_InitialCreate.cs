namespace HomeOnTheRange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InventoryModels",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Product = c.String(),
                        PurchaseDate = c.DateTime(nullable: false),
                        Type = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InventoryModels");
        }
    }
}
