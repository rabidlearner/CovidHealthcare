namespace CovidHealthcareApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_model1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "AadharNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "AadharNumber", c => c.String(nullable: false));
        }
    }
}
