namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclinicIdtoPeople : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "ClinicId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "ClinicId");
        }
    }
}
