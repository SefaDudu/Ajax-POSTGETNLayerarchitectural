namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Procedure002 : DbMigration
    {
        public override void Up()
        {
            string _sql = @"
IF (OBJECT_ID('MyProcedure') IS NOT NULL)
 BEGIN
  DROP PROCEDURE MyProcedure
END
GO
Create procedure MyProcedure
AS
BEGIN
   select *from Products
END";
            Sql(_sql);
        }
        
        public override void Down()
        {
        }
    }
}
