namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScheduledDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "ScheduledDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "ScheduledDate");
        }
    }
}
