using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class Turn
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }  
        public DateTime StartDate { get; set; }
        public int TurnTypeId { get; set; }
        public int IsPaid { get; set; }
        public int ClinicId { get; set; }   

        public Doctor doctor { get; set; }
        [ForeignKey("PatientId")]
        public Patient patient { get; set; }
        public TurnType TurnType { get; set; }  

    }
}
