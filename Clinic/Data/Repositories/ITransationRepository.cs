using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;

namespace ClinicProject.Data.Repositories
{
    public interface ITransationRepository
    {
        // int GetTotalStaffSalary(int clinicId, int month, int year);
        int GetTotalSalary(int clinicId, int month, int year);
        bool PaySalary(int clinicId);
        bool PayStockHoldersProfit(int clinicId);
        void AddTransaction(Transaction transaction);
        bool IsExist(int clinicId, int month, int year);
    }


    public class TransationRepository : ITransationRepository
    {
        ClinicContext context = new ClinicContext();

        public void AddTransaction(Transaction transaction)
        {
            context.Transactions.Add(transaction);
            context.SaveChanges();
        }

        public int GetTotalSalary(int clinicId, int month, int year)
        {
            return context.Transactions.SingleOrDefault(t => t.ClinicId == clinicId && t.dateTime.Month == month && t.dateTime.Year == year).TotalSalary;
        }

        public bool IsExist(int clinicId, int month, int year)
        {
            return context.Transactions.Any(t => t.dateTime.Month == month && t.dateTime.Year == year && t.ClinicId == clinicId);
        }

        //public int GetTotalStaffSalary(int clinicId, int month, int year)
        //{
        //    return context.Transactions.Where(t => t.ClinicId == clinicId && t.dateTime.Month == month && t.dateTime.Year == year && t.Type == 0).Sum(t => t.Cash);
        //}

        public bool PaySalary(int clinicId)
        {
            int month = DateTime.Now.Month, year = DateTime.Now.Year;
            if (IsExist(clinicId, month, year))
                return false;
            else
            {
                int totalprice = context.Turns.Include("TurnType").Where(t => t.ClinicId == clinicId && t.StartDate.Month == month && t.StartDate.Year == year).Sum(t => t.TurnType.Price);
                int totalcost = context.Turns.Include("TurnType").Where(t => t.ClinicId == clinicId && t.StartDate.Month == month && t.StartDate.Year == year).Sum(t => t.TurnType.Cost);
                int totalsalary = context.Staffs.Include("staffType").Sum(s => s.staffType.Salary) + (int)context.Doctors.Include("People").Sum(d => d.People.Income);
                Transaction temp = new Transaction()
                {
                    TotalPrice = totalprice,
                    TotalCost = totalcost,
                    TotalSalary = totalsalary,
                    TotalIncome = totalprice - totalcost - totalsalary,
                    dateTime = DateTime.Now,
                    ClinicId = clinicId,
                    Decription = "",
                };
                AddTransaction(temp);
                List<Doctor> doctors = context.Doctors.Include("People").Where(d => d.ClinicId == clinicId).ToList();
                foreach (var item in doctors)
                {
                    item.People.Income = 0;
                }
                context.Clinics.Find(clinicId).Income -= context.Staffs.Include("staffType").Sum(s => s.staffType.Salary);
                context.SaveChanges();
                return true;
            }
        }

        public bool PayStockHoldersProfit(int clinicId)
        {
            Clinic clinic = context.Clinics.Find(clinicId);
            List<StockHolder> stockHolders = context.StockHolders.Include("People").Where(s => s.ClinicId == clinicId).ToList();
            foreach (var item in stockHolders)
            {
                item.People.Income += (((decimal)item.StockPercent / 100) * clinic.Income);
            }
            context.SaveChanges();
            clinic.Income = 0;
            context.SaveChanges();
            return true;
        }
    }
}
