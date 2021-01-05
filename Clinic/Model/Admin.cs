using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class Admin
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int ClinicId { get; set; }


        public People People { get; set; }
    }
}
