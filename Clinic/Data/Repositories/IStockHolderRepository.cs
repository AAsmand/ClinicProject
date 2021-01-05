using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface IStockHolderRepository
    {
        List<StockHolder> GetStockHolders(int clinicId);
    }


    public class StockHolderRepository : IStockHolderRepository
    {
        ClinicContext context = new ClinicContext();
        public List<StockHolder> GetStockHolders(int clinicId)
        {
            return context.StockHolders.Include("People").Where(s => s.ClinicId == clinicId).ToList();
        }
    }
}
