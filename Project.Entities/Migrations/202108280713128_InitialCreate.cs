namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Comments = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.Int(nullable: false),
                        Comment_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Comments", t => t.Comment_ID)
                .Index(t => t.Comment_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Comment_ID", "dbo.Comments");
            DropIndex("dbo.Products", new[] { "Comment_ID" });
            DropTable("dbo.Products");
            DropTable("dbo.Comments");
        }
    }
}
