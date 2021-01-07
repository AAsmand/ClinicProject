using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;

namespace ClinicProject.Data.Repositories
{
    public interface IClinicSettingRepository
    {
        ClinicSetting GetFirstTime(int clinicId,int DayIndex);

        List<ClinicSetting> GetSettings(int clinicId);
        void CreateDefaultSetting(int clinicId);
        void Update();
    }
    public class ClinicSettingRepository : IClinicSettingRepository
    {
        ClinicContext context = new ClinicContext();

        public void CreateDefaultSetting(int clinicId)
        {
            for(int i=0; i<7;i++)
            {
                context.ClinicSettings.Add(new ClinicSetting
                {
                    ClinicId = clinicId,
                    DayIndex=i,
                    IsActive = false,
                    StartTime = new TimeSpan(),
                    EndTime = new TimeSpan()
                });
            }
        }

        public ClinicSetting GetFirstTime(int clinicId, int DayIndex)
        {
            return context.ClinicSettings.SingleOrDefault(s => s.DayIndex == DayIndex && s.ClinicId==clinicId);
        }

        public List<ClinicSetting> GetSettings(int clinicId)
        {
            return context.ClinicSettings.Where(s => s.ClinicId == clinicId).ToList();
        }

        public void Update()
        {
            context.SaveChanges();
        }
    }
}
