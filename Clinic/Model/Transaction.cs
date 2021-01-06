using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }
        public int TotalPrice { get; set; }
        public int TotalCost { get; set; }
        public int TotalSalary { get; set; }
        public int TotalIncome { get; set; }
        public DateTime dateTime { get; set; }
        public string Decription { get; set; }
    }
}
