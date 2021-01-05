using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface ITurnTypeDoctorRepository
    {
        void AddTurnTypeDoctor(TurnTypeDoctor turnTypeDoctor);
    }

    public class TurnTypeDoctorRepository : ITurnTypeDoctorRepository
    {
        ClinicContext Context = new ClinicContext();
        public void AddTurnTypeDoctor(TurnTypeDoctor turnTypeDoctor)
        {
            Context.TurnTypeDoctors.Add(turnTypeDoctor);
            Context.SaveChanges();
        }
    }
}
