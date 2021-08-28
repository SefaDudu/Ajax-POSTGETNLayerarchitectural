namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V0002 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "ProductID", "dbo.Products");
            DropIndex("dbo.Comments", new[] { "ProductID" });
            RenameColumn(table: "dbo.Comments", name: "ProductID", newName: "product_ID");
            AlterColumn("dbo.Comments", "Comments", c => c.String());
            AlterColumn("dbo.Comments", "product_ID", c => c.Int());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            CreateIndex("dbo.Comments", "product_ID");
            AddForeignKey("dbo.Comments", "product_ID", "dbo.Products", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "product_ID", "dbo.Products");
            DropIndex("dbo.Comments", new[] { "product_ID" });
            AlterColumn("dbo.Products", "ProductName", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "product_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "Comments", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Comments", name: "product_ID", newName: "ProductID");
            CreateIndex("dbo.Comments", "ProductID");
            AddForeignKey("dbo.Comments", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
        }
    }
}
