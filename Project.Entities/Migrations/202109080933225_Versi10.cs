namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versi10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ALogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        KullaniciAdi = c.String(nullable: false),
                        ActionName = c.String(nullable: false),
                        ControllerName = c.String(nullable: false),
                        Bilgi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Logs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        KullaniciAdi = c.String(nullable: false),
                        ActionName = c.String(nullable: false),
                        ControllerName = c.String(nullable: false),
                        Bilgi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ALogs");
        }
    }
}
