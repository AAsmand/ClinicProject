using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class TurnType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }   
        public int Price { get; set; }
        public int DoctorComission { get; set; }

        public List<TurnTypeDoctor> TurnDoctors { get; set; }
    }
}
