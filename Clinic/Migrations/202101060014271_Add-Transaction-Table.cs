namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTransactionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeopleId = c.Int(nullable: false),
                        ClinicId = c.Int(nullable: false),
                        Cash = c.Int(nullable: false),
                        dateTime = c.DateTime(nullable: false),
                        Decription = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PeopleId, cascadeDelete: true)
                .Index(t => t.PeopleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "PeopleId", "dbo.People");
            DropIndex("dbo.Transactions", new[] { "PeopleId" });
            DropTable("dbo.Transactions");
        }
    }
}
