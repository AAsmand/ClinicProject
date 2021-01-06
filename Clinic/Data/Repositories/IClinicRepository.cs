using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface IClinicRepository
    {
        int GetIncome(int clinicId);
    }

    public class ClinicRepository : IClinicRepository
    {
        ClinicContext context = new ClinicContext();
        public int GetIncome(int clinicId)
        {
            return (int)context.Clinics.Find(clinicId).Income;
        }
    }
}
