namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TurnDurationFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TurnTypes", "Duration", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Turns", "Duration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turns", "Duration", c => c.DateTime(nullable: false));
            DropColumn("dbo.TurnTypes", "Duration");
        }
    }
}
