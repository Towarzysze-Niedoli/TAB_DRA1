namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonAddressAndAppointment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "Receptionist_Id", "dbo.Receptionists");
            DropIndex("dbo.Appointments", new[] { "Patient_Id" });
            DropIndex("dbo.Appointments", new[] { "Receptionist_Id" });
            AddColumn("dbo.Admins", "Address_Id", c => c.Int());
            AlterColumn("dbo.Appointments", "Patient_Id", c => c.Int());
            AlterColumn("dbo.Appointments", "Receptionist_Id", c => c.Int());
            CreateIndex("dbo.Appointments", "Patient_Id");
            CreateIndex("dbo.Appointments", "Receptionist_Id");
            CreateIndex("dbo.Admins", "Address_Id");
            AddForeignKey("dbo.Admins", "Address_Id", "dbo.Addresses", "Id");
            AddForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients", "Id");
            AddForeignKey("dbo.Appointments", "Receptionist_Id", "dbo.Receptionists", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Receptionist_Id", "dbo.Receptionists");
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.Admins", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Admins", new[] { "Address_Id" });
            DropIndex("dbo.Appointments", new[] { "Receptionist_Id" });
            DropIndex("dbo.Appointments", new[] { "Patient_Id" });
            AlterColumn("dbo.Appointments", "Receptionist_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Appointments", "Patient_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Admins", "Address_Id");
            CreateIndex("dbo.Appointments", "Receptionist_Id");
            CreateIndex("dbo.Appointments", "Patient_Id");
            AddForeignKey("dbo.Appointments", "Receptionist_Id", "dbo.Receptionists", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients", "Id", cascadeDelete: true);
        }
    }
}
