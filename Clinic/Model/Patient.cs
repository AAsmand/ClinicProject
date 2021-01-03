using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class Patient
    {
        public int Id { get; set; } 
        public int PeopleId { get; set; }
        public int ClinicId { get; set; }
            
        public People People { get; set; }
        public List<Turn> Turns { get; set; }

    }
}
