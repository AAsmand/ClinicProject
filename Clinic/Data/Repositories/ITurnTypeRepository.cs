using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;

namespace ClinicProject.Data.Repositories
{
    public interface ITurnTypeRepository
    {
         List<TurnType> getTurnTypes(int clinicId);
        TurnType GetTurnType(int id);
        void AddTurnType(TurnType turnType);
        void RemoveTurnType(int Id);
    }

    public class TurnTypeRepository : ITurnTypeRepository
    {
        ClinicContext context = new ClinicContext();

        public void AddTurnType(TurnType turnType)
        {
            context.TurnTypes.Add(turnType);
            context.SaveChanges();
        }

        public TurnType GetTurnType(int id)
        {
            return context.TurnTypes.FirstOrDefault(t => t.Id == id);
        }

        public List<TurnType> getTurnTypes(int clinicId)
        {
            return context.TurnTypes.Where(t=>t.ClinicId==clinicId).ToList();
        }

        public void RemoveTurnType(int Id)
        {
            TurnType temp = context.TurnTypes.SingleOrDefault(t => t.Id == Id);

            context.TurnTypes.Remove(temp);
            context.SaveChanges();
        }
    }
}
