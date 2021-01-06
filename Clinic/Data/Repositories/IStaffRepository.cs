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
        Staff Login(string username, string password);
        List<Staff> GetStaffs(int clinicId,string name="",string family="",string codeMelli="");
        void RemoveStaff(int Id);
        void AddStaff(Staff staff);
    }


    public class StaffRepository : IStaffRepository
    {
        ClinicContext context = new ClinicContext();

        public void AddStaff(Staff staff)
        {
            context.Staffs.Add(staff);
            context.SaveChanges();
        }

        public List<Staff> GetStaffs(int clinicId, string name = "", string family = "", string codeMelli = "")
        {
            return context.Staffs.Include("staffType").Include("People").Where(s => s.ClinicId == clinicId&&s.People.Name.Contains(name)&&s.People.Family.Contains(family)&&s.People.CodeMelli.Contains(codeMelli)).ToList();
        }

        public Staff Login(string username, string password)
        {
            return context.Staffs.Include("People").FirstOrDefault(s => s.People.Username == username && s.People.Password == password && s.StaffTypeId == 1);
        }

        public void RemoveStaff(int Id)
        {
            Staff temp=context.Staffs.Find(Id);
            context.Staffs.Remove(temp);
            context.SaveChanges();
        }
    }
}
