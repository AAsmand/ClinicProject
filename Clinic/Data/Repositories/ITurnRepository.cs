using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface ITurnRepository
    {
        List<Turn> GetPatientTurn(int patientId,DateTime? date=null);
        List<Turn> GetDoctorTurn(int DoctorId,int clinicId, DateTime? date = null);
        DateTime GetFirstTime(int DoctorId, int turnType);
        void AddTurn(Turn turn);
        void RemoveTurn(int turnId);
        int GetTotalPrice(int clinicId, int month, int year);
        int GetTotalCost(int clinicId, int month, int year);
    }


    public class TurnRepository : ITurnRepository
    {
        ClinicContext context = new ClinicContext();
        public TimeSpan isEmpty(DateTime time,int DoctorId,int TypeId)
        {
            List<Turn> list = context.Doctors.Include("Turns").Include("Turns.TurnType").FirstOrDefault(d=>d.Id==DoctorId).Turns.OrderBy(d => d.StartDate).ToList();
            Turn next = list.Where(a => a.StartDate > time).FirstOrDefault();
            if (list.Where(a => a.StartDate == time).FirstOrDefault() == null) {
                if (next==null||next.StartDate >= time + context.TurnTypes.FirstOrDefault(t => t.Id == TypeId).Duration)
                    return new TimeSpan();
                else
                {
                    TimeSpan distance;
                    distance = next.StartDate - time + next.TurnType.Duration;
                    return distance;
                }
            }
            else
            {
                return list.Where(a => a.StartDate == time).FirstOrDefault().TurnType.Duration;
            }
        }
        public DateTime GetFirstTime(int DoctorId, int turnType)
        {
            DateTime d1 = DateTime.Now;
            DateTime date = new DateTime(d1.Year, d1.Month, d1.Day, 15, 0, 0);
            for (DateTime d = date; d.Hour <= 20; d = d.AddMinutes(10))    ////because 10 is minimum of time request 
            {
                TimeSpan result = isEmpty(d, DoctorId, turnType);        //// if result == 0 meens that time is empty 
                if (result == new TimeSpan()) return d;
                else                                                    ////else we should go forward enough to last turn length
                {
                    d = d.AddMinutes(result.Minutes-10).AddHours(result.Hours).AddSeconds(result.Seconds);
                }
                if (d.Hour == 20)
                {
                    d.AddDays(1);
                    d.AddHours(-12);
                }
            }
            return new DateTime();
        }

        public List<Turn> GetPatientTurn(int patientId, DateTime? date = null)
        {
            if(date==null)
            return context.Turns.Include("Doctor").Include("TurnType").Include("Doctor.People").Where(T => T.PatientId == patientId).ToList();
            else
            {
                return context.Turns.Include("Doctor").Include("TurnType").Include("Doctor.People").Where(T => T.PatientId == patientId&&T.StartDate.Day==date.Value.Day&&T.StartDate.Month==date.Value.Month&&T.StartDate.Year==date.Value.Year).ToList();
            }
        }

        public void AddTurn(Turn turn)
        {
            context.Turns.Add(turn);
            turn.TurnType = context.TurnTypes.SingleOrDefault(t => t.Id == turn.TurnTypeId && t.ClinicId == turn.ClinicId);
            context.Doctors.Include("People").SingleOrDefault(d => d.Id == turn.DoctorId && d.ClinicId == turn.ClinicId).People.Income += (turn.TurnType.Price - turn.TurnType.Cost) * turn.TurnType.DoctorComission / 100;
            context.Clinics.SingleOrDefault(c=>c.Id==turn.ClinicId).Income+= (turn.TurnType.Price - turn.TurnType.Cost) * (100-turn.TurnType.DoctorComission) / 100;
            context.SaveChanges();
            //////////
            ///
        }

        public void RemoveTurn(int turnId)
        {
            Turn turn = context.Turns.Find(turnId);
            context.Turns.Remove(turn);
            context.SaveChanges();
        }

        public List<Turn> GetDoctorTurn(int DoctorId, int clinicId, DateTime? date = null)
        {
            if (date == null)
                return context.Turns.Include("Doctor").Include("TurnType").Include("Doctor.People").Where(T => T.ClinicId == clinicId && T.DoctorId == DoctorId).ToList();
            else
            {
                return context.Turns.Include("Doctor").Include("TurnType").Include("Doctor.People").Where(T =>T.ClinicId==clinicId&& T.DoctorId == DoctorId && T.StartDate.Day == date.Value.Day && T.StartDate.Month == date.Value.Month && T.StartDate.Year == date.Value.Year).ToList();
            }
        }

        public int GetTotalPrice(int clinicId, int month, int year)
        {
            return context.Turns.Include("TurnType").Where(t => t.ClinicId == clinicId && t.StartDate.Month == month && t.StartDate.Year == year).Sum(t => t.TurnType.Price);
        }

        public int GetTotalCost(int clinicId, int month, int year)
        {
            return context.Turns.Include("TurnType").Where(t => t.ClinicId == clinicId && t.StartDate.Month == month && t.StartDate.Year == year).Sum(t => t.TurnType.Cost);
        }
    }
}
