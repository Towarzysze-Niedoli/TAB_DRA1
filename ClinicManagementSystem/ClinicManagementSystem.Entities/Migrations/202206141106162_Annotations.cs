namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Annotations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.Appointments", new[] { "Patient_Id" });
            AlterColumn("dbo.Appointments", "Patient_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "Patient_Id");
            AddForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.Appointments", new[] { "Patient_Id" });
            AlterColumn("dbo.Appointments", "Patient_Id", c => c.Int());
            CreateIndex("dbo.Appointments", "Patient_Id");
            AddForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients", "Id");
        }
    }
}
