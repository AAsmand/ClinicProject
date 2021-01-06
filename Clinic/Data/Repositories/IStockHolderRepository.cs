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
        void Update();
        StockHolder GetStockHolder(int id);
    }


    public class StockHolderRepository : IStockHolderRepository
    {
        ClinicContext context = new ClinicContext();

        public StockHolder GetStockHolder(int id)
        {
            return context.StockHolders.Find(id);
        }

        public List<StockHolder> GetStockHolders(int clinicId)
        {
            return context.StockHolders.Include("People").Where(s => s.ClinicId == clinicId).ToList();
        }

        public void Update()
        {
            context.SaveChanges();
        }
    }
}
