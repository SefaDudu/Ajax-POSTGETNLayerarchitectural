namespace Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deneme0033 : DbMigration
    {
        public override void Up()
        {
            string _sql = @"
if not exists ( select * from sys.objects 
            where name='MyProcs' and objectproperty(object_id,'IsProcedure')=1 )
exec('create proc MyProcs 
as begin
  select*from Products
end')";


            Sql(_sql);

        }

        public override void Down()
        {
        }
    }
}
