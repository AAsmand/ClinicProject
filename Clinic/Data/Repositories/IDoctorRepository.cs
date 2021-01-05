using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface IDoctorRepository
    {
        List<DoctorViewModel> GetDoctors(int turntypeId,int clinicId);
        List<DoctorViewModel> GetDoctors(int clinicId,string name="",string family="",string codeMelli="");
        void RemoveDoctor(int Id);
        void AddDoctor(Doctor doctor);
    }

    public class DoctorRepository : IDoctorRepository
    {
        ClinicContext context = new ClinicContext();

        public void AddDoctor(Doctor doctor)
        {
            context.Doctors.Add(doctor);
            context.SaveChanges();
        }

        public List<DoctorViewModel> GetDoctors(int turntypeId, int clinicId)
        {
            List <DoctorViewModel> test= context.TurnTypeDoctors.Include("doctor").Include("doctor.People").Where(t => t.TurnTypeId == turntypeId&&t.doctor.ClinicId==clinicId).Select(t => new DoctorViewModel {Id= t.doctor.Id,Name=t.doctor.People.Name,Family=t.doctor.People.Family }).ToList();
            return test;
        }

        public List<DoctorViewModel> GetDoctors(int clinicId, string name = "", string family = "", string codeMelli = "")
        {
            return context.Doctors.Include("People").Where(d=>d.ClinicId==clinicId&&d.People.Name.Contains(name)&&d.People.Family.Contains(family)&&d.People.CodeMelli.Contains(codeMelli)).Select(t => new DoctorViewModel { Id = t.Id, Name = t.People.Name, Family = t.People.Family }).ToList();
        }

        public void RemoveDoctor(int Id)
        {
            Doctor temp=context.Doctors.Find(Id);
            context.Doctors.Remove(temp);
            context.SaveChanges();
        }
    }
}
