namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExaminationCorrections : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LaboratoryExams", "Examination_Code", "dbo.Examinations");
            DropForeignKey("dbo.PhysicalExams", "Examination_Code", "dbo.Examinations");
            DropIndex("dbo.LaboratoryExams", new[] { "Examination_Code" });
            DropIndex("dbo.PhysicalExams", new[] { "Examination_Code" });
            DropPrimaryKey("dbo.Examinations");
            AlterColumn("dbo.LaboratoryExams", "Examination_Code", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Examinations", "Code", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.PhysicalExams", "Examination_Code", c => c.String(nullable: false, maxLength: 8));
            AddPrimaryKey("dbo.Examinations", "Code");
            CreateIndex("dbo.LaboratoryExams", "Examination_Code");
            CreateIndex("dbo.PhysicalExams", "Examination_Code");
            AddForeignKey("dbo.LaboratoryExams", "Examination_Code", "dbo.Examinations", "Code", cascadeDelete: true);
            AddForeignKey("dbo.PhysicalExams", "Examination_Code", "dbo.Examinations", "Code", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhysicalExams", "Examination_Code", "dbo.Examinations");
            DropForeignKey("dbo.LaboratoryExams", "Examination_Code", "dbo.Examinations");
            DropIndex("dbo.PhysicalExams", new[] { "Examination_Code" });
            DropIndex("dbo.LaboratoryExams", new[] { "Examination_Code" });
            DropPrimaryKey("dbo.Examinations");
            AlterColumn("dbo.PhysicalExams", "Examination_Code", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Examinations", "Code", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.LaboratoryExams", "Examination_Code", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Examinations", "Code");
            CreateIndex("dbo.PhysicalExams", "Examination_Code");
            CreateIndex("dbo.LaboratoryExams", "Examination_Code");
            AddForeignKey("dbo.PhysicalExams", "Examination_Code", "dbo.Examinations", "Code", cascadeDelete: true);
            AddForeignKey("dbo.LaboratoryExams", "Examination_Code", "dbo.Examinations", "Code", cascadeDelete: true);
        }
    }
}
