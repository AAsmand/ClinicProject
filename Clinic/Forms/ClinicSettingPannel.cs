using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicProject.Model;
using ClinicProject.Data.Repositories;

namespace ClinicProject.Forms
{
    public partial class ClinicSettingPannel : Form
    {
        int ClinicId;
        private IClinicSettingRepository clinicSettingRepository;
        public ClinicSettingPannel(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            clinicSettingRepository = new ClinicSettingRepository();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClinicSettingPannel_Load(object sender, EventArgs e)
        {
            List<ClinicSetting> settings = clinicSettingRepository.GetSettings(ClinicId);
            if (settings != null)
            {
                ClinicSetting saturday = settings.SingleOrDefault(s => s.DayIndex == 6);
                SaturdayIsActive.Checked = saturday.IsActive;
                saturdayStartHour.Value = saturday.StartTime.Hours;
                saturdayStartMin.Value = saturday.StartTime.Minutes;
                saturdayEndHour.Value = saturday.EndTime.Hours;
                saturdayEndMin.Value = saturday.EndTime.Minutes;
                //////////////////////////////////////////////////////////////
                ClinicSetting sunday = settings.SingleOrDefault(s => s.DayIndex == 0);
                SundayIsActive.Checked = sunday.IsActive;
                SundayStartHour.Value = sunday.StartTime.Hours;
                SundayStartMin.Value = sunday.StartTime.Minutes;
                SundayEndHour.Value = sunday.EndTime.Hours;
                SundayEndMin.Value = sunday.EndTime.Minutes;
                ///////////////////////////////////////////////////////////////
                ClinicSetting monday = settings.SingleOrDefault(s => s.DayIndex == 1);
                MondayIsActive.Checked = monday.IsActive;
                MondayStartHour.Value = monday.StartTime.Hours;
                MondayStartMin.Value = monday.StartTime.Minutes;
                MondayEndHour.Value = monday.EndTime.Hours;
                MondayEndMin.Value = monday.EndTime.Minutes;
                ///////////////////////////////////////////////////////////////
                ClinicSetting tuesday = settings.SingleOrDefault(s => s.DayIndex == 2);
                TuesdayIsActive.Checked = tuesday.IsActive;
                TuesdayStartHour.Value = tuesday.StartTime.Hours;
                TuesdayStartMin.Value = tuesday.StartTime.Minutes;
                TuesdayEndHour.Value = tuesday.EndTime.Hours;
                TuesdayEndMin.Value = tuesday.EndTime.Minutes;
                /////////////////////////////////////////////////////////////
                ClinicSetting wednsday = settings.SingleOrDefault(s => s.DayIndex == 3);
                WednsdayIsActive.Checked = wednsday.IsActive;
                WednsdayStartHour.Value = wednsday.StartTime.Hours;
                WednsdayStartMin.Value = wednsday.StartTime.Minutes;
                WednsdayEndHour.Value = wednsday.EndTime.Hours;
                WednsdayEndMin.Value = wednsday.EndTime.Minutes;
                //////////////////////////////////////////////////////////////
                ClinicSetting thursday = settings.SingleOrDefault(s => s.DayIndex == 4);
                ThursdayIsActive.Checked = thursday.IsActive;
                ThursdayStartHour.Value = thursday.StartTime.Hours;
                ThursdayStartMin.Value = thursday.StartTime.Minutes;
                ThursdayEndHour.Value = thursday.EndTime.Hours;
                ThursdayEndMin.Value = thursday.EndTime.Minutes;
                ///////////////////////////////////////////////////////////////
                ClinicSetting friday = settings.SingleOrDefault(s => s.DayIndex == 5);
                FridayIsActive.Checked = friday.IsActive;
                FridayStartHour.Value = friday.StartTime.Hours;
                FridayStartMin.Value = friday.StartTime.Minutes;
                FridayEndHour.Value = friday.EndTime.Hours;
                FridayEndMin.Value = friday.EndTime.Minutes;
            }
            else
            {
                clinicSettingRepository.CreateDefaultSetting(ClinicId);
            }
            initIsActives();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<ClinicSetting> settings = clinicSettingRepository.GetSettings(ClinicId);
            ClinicSetting saturday = settings.SingleOrDefault(s => s.DayIndex == 6);
            saturday.IsActive = SaturdayIsActive.Checked;
            TimeSpan saturdayStart = new TimeSpan((int)saturdayStartHour.Value, (int)saturdayStartMin.Value, 0);
            saturday.StartTime = saturdayStart;
            TimeSpan saturdayEnd = new TimeSpan((int)saturdayEndHour.Value, (int)saturdayEndMin.Value, 0);
            saturday.EndTime = saturdayEnd;
            //////////////////////////////////////////////////////////////
            ClinicSetting sunday = settings.SingleOrDefault(s => s.DayIndex == 0);
            sunday.IsActive = SundayIsActive.Checked;
            TimeSpan sundayStart = new TimeSpan((int)SundayStartHour.Value, (int)SundayStartMin.Value, 0);
            sunday.StartTime = sundayStart;
            TimeSpan sundayEnd = new TimeSpan((int)SundayEndHour.Value, (int)SundayEndMin.Value, 0);
            sunday.EndTime = sundayEnd;
            ///////////////////////////////////////////////////////////////
            ClinicSetting monday = settings.SingleOrDefault(s => s.DayIndex == 1);
            monday.IsActive = MondayIsActive.Checked;
            TimeSpan mondaystart = new TimeSpan((int)MondayStartHour.Value, (int)MondayStartMin.Value, 0);
            monday.StartTime = mondaystart;
            TimeSpan mondayEnd = new TimeSpan((int)MondayEndHour.Value, (int)MondayEndMin.Value, 0);
            monday.EndTime = mondayEnd;
            ///////////////////////////////////////////////////////////////
            ClinicSetting tuesday = settings.SingleOrDefault(s => s.DayIndex == 2);
            tuesday.IsActive = TuesdayIsActive.Checked;
            TimeSpan tuesdaystart = new TimeSpan((int)TuesdayStartHour.Value, (int)TuesdayStartMin.Value, 0);
            tuesday.StartTime = tuesdaystart;
            TimeSpan tuesdayEnd = new TimeSpan((int)TuesdayEndHour.Value, (int)TuesdayEndMin.Value, 0);
            tuesday.EndTime = tuesdayEnd;
            /////////////////////////////////////////////////////////////
            ClinicSetting wednsday = settings.SingleOrDefault(s => s.DayIndex == 3);
            wednsday.IsActive = WednsdayIsActive.Checked;
            TimeSpan wednsdaystart = new TimeSpan((int)WednsdayStartHour.Value, (int)WednsdayStartMin.Value, 0);
            wednsday.StartTime = wednsdaystart;
            TimeSpan wednsdayEnd = new TimeSpan((int)WednsdayEndHour.Value, (int)WednsdayEndMin.Value, 0);
            wednsday.EndTime = wednsdayEnd;
            //////////////////////////////////////////////////////////////
            ClinicSetting thursday = settings.SingleOrDefault(s => s.DayIndex == 4);
            thursday.IsActive = ThursdayIsActive.Checked;
            TimeSpan thursdaystart = new TimeSpan((int)ThursdayStartHour.Value, (int)ThursdayStartMin.Value, 0);
            thursday.StartTime = thursdaystart;
            TimeSpan thursdayEnd = new TimeSpan((int)ThursdayEndHour.Value, (int)ThursdayEndMin.Value, 0);
            thursday.EndTime = thursdayEnd;
            ///////////////////////////////////////////////////////////////
            ClinicSetting friday = settings.SingleOrDefault(s => s.DayIndex == 5);
            friday.IsActive = FridayIsActive.Checked;
            TimeSpan fridaystart = new TimeSpan((int)FridayStartHour.Value, (int)FridayStartMin.Value, 0);
            friday.StartTime = fridaystart;
            TimeSpan fridayEnd = new TimeSpan((int)FridayEndHour.Value, (int)FridayEndHour.Value, 0);
            friday.EndTime = fridayEnd;

            clinicSettingRepository.Update();
            MessageBox.Show("عملیات با موفقیت انجام شد !", "موفق", MessageBoxButtons.OK);
            this.Close();
        }

        private void SaturdayIsActive_CheckedChanged(object sender, EventArgs e)
        {
            initIsActives();
        }

        public void initIsActives()
        {
            if (SaturdayIsActive.Checked)
            {
                saturdayStartHour.Enabled = true;
                saturdayStartMin.Enabled = true;
                saturdayEndHour.Enabled = true;
                saturdayEndMin.Enabled = true;
            }
            else
            {
                saturdayStartHour.Enabled = false;
                saturdayStartMin.Enabled = false;
                saturdayEndHour.Enabled = false;
                saturdayEndMin.Enabled = false;
            }
            //////////////////////////////////////////////////////////////

            if (SundayIsActive.Checked)
            {
                SundayStartHour.Enabled = true;
                SundayStartMin.Enabled = true;
                SundayEndHour.Enabled = true;
                SundayEndMin.Enabled = true;
            }
            else
            {
                SundayStartHour.Enabled = false;
                SundayStartMin.Enabled = false;
                SundayEndHour.Enabled = false;
                SundayEndMin.Enabled = false;
            }
            ///////////////////////////////////////////////////////////////

            if (MondayIsActive.Checked)
            {
                MondayStartHour.Enabled = true;
                MondayStartMin.Enabled = true;
                MondayEndHour.Enabled = true;
                MondayEndMin.Enabled = true;
            }
            else
            {
                MondayStartHour.Enabled = false;
                MondayStartMin.Enabled = false;
                MondayEndHour.Enabled = false;
                MondayEndMin.Enabled = false;
            }
            ///////////////////////////////////////////////////////////////

            if (TuesdayIsActive.Checked)
            {
                TuesdayStartHour.Enabled = true;
                TuesdayStartMin.Enabled = true;
                TuesdayEndHour.Enabled = true;
                TuesdayEndMin.Enabled = true;
            }
            else
            {
                TuesdayStartHour.Enabled = false;
                TuesdayStartMin.Enabled = false;
                TuesdayEndHour.Enabled = false;
                TuesdayEndMin.Enabled = false;
            }
            /////////////////////////////////////////////////////////////

            if (WednsdayIsActive.Checked)
            {
                WednsdayStartHour.Enabled = true;
                WednsdayStartMin.Enabled = true;
                WednsdayEndHour.Enabled = true;
                WednsdayEndMin.Enabled = true;
            }
            else
            {
                WednsdayStartHour.Enabled = false;
                WednsdayStartMin.Enabled = false;
                WednsdayEndHour.Enabled = false;
                WednsdayEndMin.Enabled = false;
            }
            //////////////////////////////////////////////////////////////
            if (ThursdayIsActive.Checked)
            {
                ThursdayStartHour.Enabled = true;
                ThursdayStartMin.Enabled = true;
                ThursdayEndHour.Enabled = true;
                ThursdayEndMin.Enabled = true;
            }
            else
            {
                ThursdayStartHour.Enabled = false;
                ThursdayStartMin.Enabled = false;
                ThursdayEndHour.Enabled = false;
                ThursdayEndMin.Enabled = false;
            }
            ///////////////////////////////////////////////////////////////
            if (FridayIsActive.Checked)
            {
                FridayStartHour.Enabled = true;
                FridayStartMin.Enabled = true;
                FridayEndHour.Enabled = true;
                FridayEndMin.Enabled = true;
            }
            else
            {
                FridayStartHour.Enabled = false;
                FridayStartMin.Enabled = false;
                FridayEndHour.Enabled = false;
                FridayEndMin.Enabled = false;
            }
        }

        private void SundayIsActive_CheckedChanged(object sender, EventArgs e)
        {
            initIsActives();
        }

        private void MondayIsActive_CheckedChanged(object sender, EventArgs e)
        {
            initIsActives();
        }

        private void TuesdayIsActive_CheckedChanged(object sender, EventArgs e)
        {
            initIsActives();
        }

        private void WednsdayIsActive_CheckedChanged(object sender, EventArgs e)
        {
            initIsActives();
        }

        private void ThursdayIsActive_CheckedChanged(object sender, EventArgs e)
        {
            initIsActives();
        }

        private void FridayIsActive_CheckedChanged(object sender, EventArgs e)
        {
            initIsActives();
        }
    }
}
