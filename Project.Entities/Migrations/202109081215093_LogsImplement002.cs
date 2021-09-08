namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogsImplement002 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logs", "Detail", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Logs", "Audit", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logs", "Audit", c => c.String());
            AlterColumn("dbo.Logs", "Detail", c => c.String());
        }
    }
}
