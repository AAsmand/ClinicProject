using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;

namespace ClinicProject.Data
{
    class ClinicContext:DbContext
    {
        public ClinicContext():base("Data Source=.;Initial Catalog=ClinicDb;Integrated Security=true")
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffType> StaffTypes { get; set; }
        public DbSet<StockHolder> StockHolders { get; set; }
        public DbSet<TurnType> TurnTypes { get; set; }
        public DbSet<Turn> Turns { get; set; }
        public DbSet<TurnTypeDoctor> TurnTypeDoctors { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ClinicSetting> ClinicSettings { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurnTypeDoctor>().HasKey(t => new { t.DoctorId,t.TurnTypeId});
            modelBuilder.Entity<Patient>().HasKey(p => new { p.Id });
            base.OnModelCreating(modelBuilder);
        }
    }
}
