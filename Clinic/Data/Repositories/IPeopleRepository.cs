using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface IPeopleRepository
    {
        void AddPeople(People people);
        People CheckExist(string codeMelli);
        People GetPeople(int id);
    }

    public class PeopleRepository : IPeopleRepository
    {
        ClinicContext context = new ClinicContext();
        public void AddPeople(People people)
        {
            context.Peoples.Add(people);
            context.SaveChanges();
        }

        public People CheckExist(string codeMelli)
        {
            return context.Peoples.SingleOrDefault(p => p.CodeMelli == codeMelli);
        }

        public People GetPeople(int id)
        {
            return context.Peoples.FirstOrDefault(p => p.Id == id);
        }
    }
}
