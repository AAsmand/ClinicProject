using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Income { get; set; }

        public List<Staff> Staffs { get; set; }
        public List<StockHolder> StockHolders { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<TurnType> TurnTypes { get; set; }
    }
}
