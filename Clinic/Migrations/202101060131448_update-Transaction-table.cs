namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTransactiontable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "PeopleId", "dbo.People");
            DropIndex("dbo.Transactions", new[] { "PeopleId" });
            AddColumn("dbo.Transactions", "TotalPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "TotalCost", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "TotalSalary", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "TotalIncome", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "PeopleId");
            DropColumn("dbo.Transactions", "Cash");
            DropColumn("dbo.Transactions", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "Cash", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "PeopleId", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "TotalIncome");
            DropColumn("dbo.Transactions", "TotalSalary");
            DropColumn("dbo.Transactions", "TotalCost");
            DropColumn("dbo.Transactions", "TotalPrice");
            CreateIndex("dbo.Transactions", "PeopleId");
            AddForeignKey("dbo.Transactions", "PeopleId", "dbo.People", "Id", cascadeDelete: true);
        }
    }
}
