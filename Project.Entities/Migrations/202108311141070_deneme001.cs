namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme001 : DbMigration
    {
        public override void Up()
        {
            string _sql = @"
IF OBJECT_ID('MyProcedure') IS NOT NULL
 BEGIN
  DROP PROC MyProcedure
END
";
            Sql(_sql);
        }
        
        public override void Down()
        {
        }
    }
}
