namespace BabyStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class category : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "Category_ID", newName: "CategoryID");
            RenameIndex(table: "dbo.Products", name: "IX_Category_ID", newName: "IX_CategoryID");
            DropColumn("dbo.Products", "CatagoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CatagoryID", c => c.Int());
            RenameIndex(table: "dbo.Products", name: "IX_CategoryID", newName: "IX_Category_ID");
            RenameColumn(table: "dbo.Products", name: "CategoryID", newName: "Category_ID");
        }
    }
}
