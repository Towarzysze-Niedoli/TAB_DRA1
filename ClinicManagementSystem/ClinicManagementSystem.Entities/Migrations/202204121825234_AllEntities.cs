namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Diagnosis = c.String(),
                        AppointmentStatus = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(),
                        CompletionDate = c.DateTime(),
                        Doctor_Id = c.Int(nullable: false),
                        Patient_Id = c.Int(nullable: false),
                        Receptionist_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.Patient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Receptionists", t => t.Receptionist_Id, cascadeDelete: true)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Patient_Id)
                .Index(t => t.Receptionist_Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.LaboratoryExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Result = c.String(),
                        DoctorComment = c.String(),
                        LaboratoryManagerComment = c.String(),
                        ReferralDate = c.DateTime(nullable: false),
                        RealisationDate = c.DateTime(),
                        CompletionDate = c.DateTime(),
                        Status = c.Int(nullable: false),
                        Examination_Code = c.String(nullable: false, maxLength: 128),
                        LaboratoryManager_Id = c.Int(),
                        LaboratoryTechnician_Id = c.Int(),
                        Appointment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Examinations", t => t.Examination_Code, cascadeDelete: true)
                .ForeignKey("dbo.LaboratoryManagers", t => t.LaboratoryManager_Id)
                .ForeignKey("dbo.LaboratoryTechnicians", t => t.LaboratoryTechnician_Id)
                .ForeignKey("dbo.Appointments", t => t.Appointment_Id, cascadeDelete: true)
                .Index(t => t.Examination_Code)
                .Index(t => t.LaboratoryManager_Id)
                .Index(t => t.LaboratoryTechnician_Id)
                .Index(t => t.Appointment_Id);
            
            CreateTable(
                "dbo.Examinations",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        ExamType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.LaboratoryManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.LaboratoryTechnicians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.PhysicalExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Result = c.String(),
                        Examination_Code = c.String(nullable: false, maxLength: 128),
                        Appointment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Examinations", t => t.Examination_Code, cascadeDelete: true)
                .ForeignKey("dbo.Appointments", t => t.Appointment_Id, cascadeDelete: true)
                .Index(t => t.Examination_Code)
                .Index(t => t.Appointment_Id);
            
            CreateTable(
                "dbo.Receptionists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Receptionist_Id", "dbo.Receptionists");
            DropForeignKey("dbo.Receptionists", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.PhysicalExams", "Appointment_Id", "dbo.Appointments");
            DropForeignKey("dbo.PhysicalExams", "Examination_Code", "dbo.Examinations");
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.LaboratoryExams", "Appointment_Id", "dbo.Appointments");
            DropForeignKey("dbo.LaboratoryExams", "LaboratoryTechnician_Id", "dbo.LaboratoryTechnicians");
            DropForeignKey("dbo.LaboratoryTechnicians", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.LaboratoryExams", "LaboratoryManager_Id", "dbo.LaboratoryManagers");
            DropForeignKey("dbo.LaboratoryManagers", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.LaboratoryExams", "Examination_Code", "dbo.Examinations");
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Receptionists", new[] { "Address_Id" });
            DropIndex("dbo.PhysicalExams", new[] { "Appointment_Id" });
            DropIndex("dbo.PhysicalExams", new[] { "Examination_Code" });
            DropIndex("dbo.LaboratoryTechnicians", new[] { "Address_Id" });
            DropIndex("dbo.LaboratoryManagers", new[] { "Address_Id" });
            DropIndex("dbo.LaboratoryExams", new[] { "Appointment_Id" });
            DropIndex("dbo.LaboratoryExams", new[] { "LaboratoryTechnician_Id" });
            DropIndex("dbo.LaboratoryExams", new[] { "LaboratoryManager_Id" });
            DropIndex("dbo.LaboratoryExams", new[] { "Examination_Code" });
            DropIndex("dbo.Doctors", new[] { "Address_Id" });
            DropIndex("dbo.Appointments", new[] { "Receptionist_Id" });
            DropIndex("dbo.Appointments", new[] { "Patient_Id" });
            DropIndex("dbo.Appointments", new[] { "Doctor_Id" });
            DropTable("dbo.Receptionists");
            DropTable("dbo.PhysicalExams");
            DropTable("dbo.LaboratoryTechnicians");
            DropTable("dbo.LaboratoryManagers");
            DropTable("dbo.Examinations");
            DropTable("dbo.LaboratoryExams");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
