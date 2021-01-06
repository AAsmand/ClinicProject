namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclinicIdtoStaffType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StaffTypes", "ClinicId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StaffTypes", "ClinicId");
        }
    }
}
