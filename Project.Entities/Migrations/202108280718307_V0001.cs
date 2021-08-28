namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V0001 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Comment_ID", "dbo.Comments");
            DropIndex("dbo.Products", new[] { "Comment_ID" });
            CreateIndex("dbo.Comments", "ProductID");
            AddForeignKey("dbo.Comments", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
            DropColumn("dbo.Products", "Comment_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Comment_ID", c => c.Int());
            DropForeignKey("dbo.Comments", "ProductID", "dbo.Products");
            DropIndex("dbo.Comments", new[] { "ProductID" });
            CreateIndex("dbo.Products", "Comment_ID");
            AddForeignKey("dbo.Products", "Comment_ID", "dbo.Comments", "ID");
        }
    }
}
