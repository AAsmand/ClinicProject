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
        List<DoctorViewModel> GetDoctors(int turntypeId);
    }

    public class DoctorRepository : IDoctorRepository
    {
        ClinicContext context = new ClinicContext();
        public List<DoctorViewModel> GetDoctors(int turntypeId)
        {
            List <DoctorViewModel> test= context.TurnTypeDoctors.Include("doctor").Include("doctor.People").Where(t => t.TurnTypeId == turntypeId).Select(t => new DoctorViewModel {Id= t.doctor.Id,Name=t.doctor.People.Name,Family=t.doctor.People.Family }).ToList();
            return test;
        }
    }
}
