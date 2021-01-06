namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "AccountNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "AccountNumber");
        }
    }
}
