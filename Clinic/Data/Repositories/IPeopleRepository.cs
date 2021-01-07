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
        People CheckExist(int clinicId,string codeMelli);
        List<People> GetPeoples(int clinicId,string name="",string family="",string codeMelli="");
        People GetPeople(int id);
        People GetPeopleByCode(int clinicId, string CodeMelli);
        void Update();
        void RemovePeople(int clinicId,int Id);
    }

    public class PeopleRepository : IPeopleRepository
    {
        ClinicContext context = new ClinicContext();
        public void AddPeople(People people)
        {
            context.Peoples.Add(people);
            context.SaveChanges();
        }

        public People CheckExist(int clinicId,string codeMelli)
        {
            return context.Peoples.SingleOrDefault(p => p.CodeMelli == codeMelli&&p.ClinicId==clinicId);
        }

        public People GetPeople(int id)
        {
            return context.Peoples.FirstOrDefault(p => p.Id == id);
        }

        public People GetPeopleByCode(int clinicId, string CodeMelli)
        {
            return context.Peoples.FirstOrDefault(p => p.CodeMelli == CodeMelli&&p.ClinicId==clinicId);
        }

        public List<People> GetPeoples(int clinicId,string name = "", string family = "", string codeMelli = "")
        {
            return context.Peoples.Where(p=>p.ClinicId==clinicId&& p.Name.Contains(name)&&p.Family.Contains(family)&&p.CodeMelli.Contains(codeMelli)).ToList();
        }

        public void RemovePeople(int clinicId, int Id)
        {
            context.Peoples.SingleOrDefault(p => p.Id == Id && p.ClinicId == clinicId);
        }

        public void Update()
        {
            context.SaveChanges();
        }
    }
}
