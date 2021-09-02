namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Procedure001 : DbMigration
    {
        public override void Up()
        {
            string _sql = @"
IF (OBJECT_ID('MyProcedure') IS NOT NULL)
";

            CreateStoredProcedure(
           "dbo.OrnekSP",
           p => new
           {

           },
           body:
               @"Select * from Products"
       );
        }
        
        public override void Down()
        {

            DropStoredProcedure("dbo.OrnekSP");
    }
    }
}
