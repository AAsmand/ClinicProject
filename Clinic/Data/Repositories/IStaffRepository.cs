using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;

namespace ClinicProject.Data.Repositories
{
    public interface IStaffRepository
    {
          Staff Login(string username,string password);
    }


    public class StaffRepository : IStaffRepository
    {
        ClinicContext context = new ClinicContext();
        public Staff Login(string username, string password)
        {
            return context.Staffs.Include("People").FirstOrDefault(s => s.People.Username == username && s.People.Password == password && s.StaffTypeId==1);
        }
    }
}
