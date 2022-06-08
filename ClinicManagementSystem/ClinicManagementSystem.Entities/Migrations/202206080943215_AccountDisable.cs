namespace ClinicManagementSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountDisable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUsers", "IsDisabled", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ApplicationUsers", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApplicationUsers", "Password", c => c.String());
            DropColumn("dbo.ApplicationUsers", "IsDisabled");
        }
    }
}
