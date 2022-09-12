namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDoctor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "LicenseNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "LicenseNumber");
        }
    }
}
