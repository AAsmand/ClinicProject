namespace ClinicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeopleId = c.Int(nullable: false),
                        ClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PeopleId, cascadeDelete: true)
                .ForeignKey("dbo.Clinics", t => t.ClinicId, cascadeDelete: true)
                .Index(t => t.PeopleId)
                .Index(t => t.ClinicId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        Income = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CodeMelli = c.String(),
                        Tell = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TurnTypeDoctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false),
                        TurnTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DoctorId, t.TurnTypeId })
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.TurnTypes", t => t.TurnTypeId, cascadeDelete: true)
                .Index(t => t.DoctorId)
                .Index(t => t.TurnTypeId);
            
            CreateTable(
                "dbo.TurnTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        DoctorComission = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Income = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeopleId = c.Int(nullable: false),
                        ClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PeopleId, cascadeDelete: true)
                .ForeignKey("dbo.Clinics", t => t.ClinicId, cascadeDelete: true)
                .Index(t => t.PeopleId)
                .Index(t => t.ClinicId);
            
            CreateTable(
                "dbo.Turns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        Duration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: false)
                .Index(t => t.DoctorId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeopleId = c.Int(nullable: false),
                        StaffTypeId = c.Int(nullable: false),
                        ClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PeopleId, cascadeDelete: true)
                .ForeignKey("dbo.StaffTypes", t => t.StaffTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Clinics", t => t.ClinicId, cascadeDelete: true)
                .Index(t => t.PeopleId)
                .Index(t => t.StaffTypeId)
                .Index(t => t.ClinicId);
            
            CreateTable(
                "dbo.StaffTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockHolders",
                c => new
                    {
                        StockHolderId = c.Int(nullable: false, identity: true),
                        PeopleId = c.Int(nullable: false),
                        StockPercent = c.Int(nullable: false),
                        ClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockHolderId)
                .ForeignKey("dbo.People", t => t.PeopleId, cascadeDelete: true)
                .ForeignKey("dbo.Clinics", t => t.ClinicId, cascadeDelete: true)
                .Index(t => t.PeopleId)
                .Index(t => t.ClinicId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockHolders", "ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.StockHolders", "PeopleId", "dbo.People");
            DropForeignKey("dbo.Staffs", "ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.Staffs", "StaffTypeId", "dbo.StaffTypes");
            DropForeignKey("dbo.Staffs", "PeopleId", "dbo.People");
            DropForeignKey("dbo.Patients", "ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.Turns", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Turns", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Patients", "PeopleId", "dbo.People");
            DropForeignKey("dbo.Doctors", "ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.TurnTypeDoctors", "TurnTypeId", "dbo.TurnTypes");
            DropForeignKey("dbo.TurnTypeDoctors", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "PeopleId", "dbo.People");
            DropIndex("dbo.StockHolders", new[] { "ClinicId" });
            DropIndex("dbo.StockHolders", new[] { "PeopleId" });
            DropIndex("dbo.Staffs", new[] { "ClinicId" });
            DropIndex("dbo.Staffs", new[] { "StaffTypeId" });
            DropIndex("dbo.Staffs", new[] { "PeopleId" });
            DropIndex("dbo.Turns", new[] { "PatientId" });
            DropIndex("dbo.Turns", new[] { "DoctorId" });
            DropIndex("dbo.Patients", new[] { "ClinicId" });
            DropIndex("dbo.Patients", new[] { "PeopleId" });
            DropIndex("dbo.TurnTypeDoctors", new[] { "TurnTypeId" });
            DropIndex("dbo.TurnTypeDoctors", new[] { "DoctorId" });
            DropIndex("dbo.Doctors", new[] { "ClinicId" });
            DropIndex("dbo.Doctors", new[] { "PeopleId" });
            DropTable("dbo.StockHolders");
            DropTable("dbo.StaffTypes");
            DropTable("dbo.Staffs");
            DropTable("dbo.Turns");
            DropTable("dbo.Patients");
            DropTable("dbo.Clinics");
            DropTable("dbo.TurnTypes");
            DropTable("dbo.TurnTypeDoctors");
            DropTable("dbo.People");
            DropTable("dbo.Doctors");
        }
    }
}
