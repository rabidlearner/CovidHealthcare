namespace CovidHealthcareApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_hospital_add_doctor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Hospitals", "EmployeeName", c => c.String(nullable: false));
            DropColumn("dbo.Hospitals", "DoctorName");
            DropColumn("dbo.Hospitals", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hospitals", "Password", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Hospitals", "DoctorName", c => c.String(nullable: false));
            DropColumn("dbo.Hospitals", "EmployeeName");
            DropTable("dbo.Doctors");
        }
    }
}
