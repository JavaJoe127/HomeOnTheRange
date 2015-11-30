namespace HomeOnTheRange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Inventories", newName: "InventoryModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.InventoryModels", newName: "Inventories");
        }
    }
}
