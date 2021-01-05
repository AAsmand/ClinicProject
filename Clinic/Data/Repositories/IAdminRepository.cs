using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data.Repositories;

namespace ClinicProject.Data.Repositories
{
    public interface IAdminRepository
    {
        Admin Login(string username, string password);
    }
    public class AdminRepository : IAdminRepository
    {
        ClinicContext context = new ClinicContext();
        public Admin Login(string username, string password)
        {
            return context.Admins.Include("People").FirstOrDefault(s => s.People.Username == username && s.People.Password == password);
        }
    }
}
