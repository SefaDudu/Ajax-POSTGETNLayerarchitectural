namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V0003 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "product_ID", "dbo.Products");
            DropIndex("dbo.Comments", new[] { "product_ID" });
            RenameColumn(table: "dbo.Comments", name: "product_ID", newName: "ProductId");
            AlterColumn("dbo.Comments", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "ProductId");
            AddForeignKey("dbo.Comments", "ProductId", "dbo.Products", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "ProductId", "dbo.Products");
            DropIndex("dbo.Comments", new[] { "ProductId" });
            AlterColumn("dbo.Comments", "ProductId", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "ProductId", newName: "product_ID");
            CreateIndex("dbo.Comments", "product_ID");
            AddForeignKey("dbo.Comments", "product_ID", "dbo.Products", "ID");
        }
    }
}
