namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClinicDaysTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClinicSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayIndex = c.Int(nullable: false),
                        DayName = c.String(),
                        StartTime = c.Time(nullable: false, precision: 7),
                        EndTime = c.Time(nullable: false, precision: 7),
                        IsActive = c.Boolean(nullable: false),
                        ClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClinicSettings");
        }
    }
}
