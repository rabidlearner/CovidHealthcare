namespace CovidHealthcareApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DoctorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "DoctorId");
            AddForeignKey("dbo.Customers", "DoctorId", "dbo.Doctors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.Customers", new[] { "DoctorId" });
            DropColumn("dbo.Customers", "DoctorId");
        }
    }
}
