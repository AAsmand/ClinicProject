namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TurnBugsFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turns", "TurnTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Turns", "IsPaid", c => c.Int(nullable: false));
            AddColumn("dbo.Turns", "ClinicId", c => c.Int(nullable: false));
            CreateIndex("dbo.Turns", "TurnTypeId");
            AddForeignKey("dbo.Turns", "TurnTypeId", "dbo.TurnTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turns", "TurnTypeId", "dbo.TurnTypes");
            DropIndex("dbo.Turns", new[] { "TurnTypeId" });
            DropColumn("dbo.Turns", "ClinicId");
            DropColumn("dbo.Turns", "IsPaid");
            DropColumn("dbo.Turns", "TurnTypeId");
        }
    }
}
