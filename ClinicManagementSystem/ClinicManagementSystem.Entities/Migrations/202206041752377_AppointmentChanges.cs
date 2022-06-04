namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "RegistrationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointments", "RegistrationDate", c => c.DateTime());
        }
    }
}
