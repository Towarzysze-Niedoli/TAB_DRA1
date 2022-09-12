namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpecializationColumnDoctor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Specialization", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "Specialization");
        }
    }
}
