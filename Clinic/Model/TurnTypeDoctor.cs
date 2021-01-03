using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class TurnTypeDoctor
    {
        public int TurnTypeId { get; set; }
        public int DoctorId { get; set; }

        public TurnType turnType { get; set; }
        public Doctor doctor { get; set; }  

    }
}
