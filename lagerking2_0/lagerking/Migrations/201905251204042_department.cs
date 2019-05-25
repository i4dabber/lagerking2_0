namespace lagerking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class department : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DbProduktIndexes", newName: "Products");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Products", newName: "DbProduktIndexes");
        }
    }
}
