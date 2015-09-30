namespace HomeOnTheRange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inventoryFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InventoryModels", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InventoryModels", "Description");
        }
    }
}
