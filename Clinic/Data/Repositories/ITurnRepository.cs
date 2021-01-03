using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface ITurnRepository
    {
        List<Turn> GetPatientTurn(int patientId,DateTime? date=null);
    }


    public class TurnRepository : ITurnRepository
    {
        ClinicContext context = new ClinicContext();
        public List<Turn> GetPatientTurn(int patientId, DateTime? date = null)
        {
            if(date==null)
            return context.Turns.Include("Doctor").Include("TurnType").Include("Doctor.People").Where(T => T.PatientId == patientId).ToList();
            else
            {
                return context.Turns.Include("Doctor").Include("TurnType").Include("Doctor.People").Where(T => T.PatientId == patientId&&T.StartDate.Day==date.Value.Day&&T.StartDate.Month==date.Value.Month&&T.StartDate.Year==date.Value.Year).ToList();
            }
        }
    }
}
