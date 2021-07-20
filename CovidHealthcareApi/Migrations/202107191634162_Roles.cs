namespace CovidHealthcareApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Roles : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into UserRoles values('Admin')");
            Sql("Insert into UserRoles values('Hospital_Employee')");
        }
        
        public override void Down()
        {
        }
    }
}
