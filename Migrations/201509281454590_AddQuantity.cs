namespace HomeOnTheRange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InventoryModels", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InventoryModels", "Quantity");
        }
    }
}
