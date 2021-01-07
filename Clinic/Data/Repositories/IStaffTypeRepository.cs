using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface IStaffTypeRepository
    {
        List<StaffType> GetStaffTypes(int clinicId);
        StaffType GetStaffType(int Id);
        void RemoveStaffType(int id);
        void AddStaffType(StaffType staffType);

        void UpdateSalary(int Id,int salary);
    }

    public class StaffTypeRepository : IStaffTypeRepository
    {
        ClinicContext context = new ClinicContext();

        public void AddStaffType(StaffType staffType)
        {
            context.StaffTypes.Add(staffType);
            context.SaveChanges();
        }

        public StaffType GetStaffType(int Id)
        {
            return context.StaffTypes.Find(Id);
        }

        public List<StaffType> GetStaffTypes(int clinicId)
        {
            return context.StaffTypes.Where(s => s.ClinicId == clinicId).ToList();
        }

        public void RemoveStaffType(int id)
        {
            StaffType temp = context.StaffTypes.Find(id);
            context.StaffTypes.Remove(temp);
            context.SaveChanges();
        }

        public void UpdateSalary(int Id,int salary)
        {
            StaffType staffType = context.StaffTypes.Find(Id);
            staffType.Salary = salary;
            context.SaveChanges();

        }
    }
}
