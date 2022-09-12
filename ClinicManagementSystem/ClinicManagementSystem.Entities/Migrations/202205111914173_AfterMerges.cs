namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AfterMerges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "LicenseNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Doctors", "LicenseNumber", c => c.Int(nullable: false));
        }
    }
}
