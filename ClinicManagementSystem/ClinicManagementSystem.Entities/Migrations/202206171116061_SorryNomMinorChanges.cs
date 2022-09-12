namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SorryNomMinorChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Examinations", "ExaminationName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Examinations", "ExaminationName");
        }
    }
}
