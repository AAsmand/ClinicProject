using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class StockHolder
    {
        public int StockHolderId { get; set; }

        public int PeopleId { get; set; }
        public int StockPercent { get; set; }
        public int ClinicId { get; set; }

            
        public People People { get; set; }

    }
}
