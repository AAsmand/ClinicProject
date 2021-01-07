using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;

namespace ClinicProject.Data.Repositories
{
    public interface IPatientRepository
    {
        List<Patient> GetPatients(string name="",string family="",string codeMelli="");
        Patient GetPatient(int Id);
        void AddPatient(Patient patient);
        Patient IsExist(string codeMelli);
        void RemovePatient(int Id);

    }

    public class PatientRepository : IPatientRepository
    {
        ClinicContext context = new ClinicContext();

        public void AddPatient(Patient patient)
        {
            context.Patients.Add(patient);
            context.SaveChanges();
        }
        public Patient GetPatient(int Id)
        {
            return context.Patients.Include("People").SingleOrDefault(p=>p.Id==Id);
        }
        public List<Patient> GetPatients(string name = "", string family = "", string codeMelli = "")
        {
            return context.Patients.Include("People").Where(p => p.People.Name.Contains(name)&&p.People.Family.Contains(family)&&p.People.CodeMelli.Contains(codeMelli)).ToList();
        }

        public Patient IsExist(string codeMelli)
        {
            return context.Patients.Include("People").SingleOrDefault(p => p.People.CodeMelli == codeMelli);
        }

        public void RemovePatient(int Id)
        {
            Patient patient = context.Patients.Find(Id);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }
    }
}
