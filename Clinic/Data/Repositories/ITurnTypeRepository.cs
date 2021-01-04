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
         List<TurnType> getTurnTypes();
        TurnType GetTurnType(int id);
    }

    public class TurnTypeRepository : ITurnTypeRepository
    {
        ClinicContext context = new ClinicContext();

        public TurnType GetTurnType(int id)
        {
            return context.TurnTypes.FirstOrDefault(t => t.Id == id);
        }

        public List<TurnType> getTurnTypes()
        {
            return context.TurnTypes.ToList();
        }
    }
}
