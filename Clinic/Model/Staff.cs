using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class Staff
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int StaffTypeId { get; set; }
        public int ClinicId { get; set; }

            
        public People People { get; set; }  
        public StaffType staffType { get; set; }    
    }
}
