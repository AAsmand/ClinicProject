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

namespace ClinicProject
{
    public partial class ReserveTurn : Form
    {
        ITurnRepository turnRepository;
        ITurnTypeRepository turnTypeRepository;
        IDoctorRepository doctorRepository;
        IPatientRepository patientRepository;
        int UserId;
        int ClinicId;
        List<WeekDay> weekDays = new List<WeekDay>();
        public ReserveTurn(int userId, int clinicId)
        {
            InitializeComponent();
            UserId = userId;
            ClinicId = clinicId;
            turnRepository = new TurnRepository();
            turnTypeRepository = new TurnTypeRepository();
            doctorRepository = new DoctorRepository();
            patientRepository = new PatientRepository();
            weekDays.Add(new WeekDay() { Index = 7, Name = "اولین روز خالی" });
            weekDays.Add(new WeekDay() { Index = 6, Name = "شنبه" });
            weekDays.Add(new WeekDay() { Index = 0, Name = "یک شنبه" });
            weekDays.Add(new WeekDay() { Index = 1, Name = "دوشنبه" });
            weekDays.Add(new WeekDay() { Index = 2, Name = "سه شنبه" });
            weekDays.Add(new WeekDay() { Index = 3, Name = "چهارشنبه" });
            weekDays.Add(new WeekDay() { Index = 4, Name = "پنج شنبه" });
        }

        private void ReserveTurn_Load(object sender, EventArgs e)
        {
            TurnTypeCombo.DisplayMember = "Name";
            TurnTypeCombo.ValueMember = "Id";
            TurnTypeCombo.DataSource = turnTypeRepository.getTurnTypes(ClinicId);
            initDoctorsGrid();
            Patient p = patientRepository.GetPatient(UserId);
            NameLbl.Text += p.People.Name + " " + p.People.Family;
            CodeMelliLbl.Text = p.People.CodeMelli;
            initWeekDaysCombo();
        }
        
        public void initWeekDaysCombo()
        {

            WeekDaysCombo.DataSource = weekDays;
            WeekDaysCombo.DisplayMember = "Name";
            WeekDaysCombo.ValueMember = "Index";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DoctorId = int.Parse(DoctorsGrid.Rows[int.Parse(DoctorsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            FirstTime.Text = turnRepository.GetFirstTime(ClinicId, DoctorId, int.Parse(TurnTypeCombo.SelectedValue.ToString()),int.Parse(WeekDaysCombo.SelectedValue.ToString())).ToString();
            // FirstTime.Text = Turns.getFirstTime(date, Convert.ToInt32(label3.Text)).ToString();
        }

        private void TurnTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            initDoctorsGrid();
            PriceLbl.Text = turnTypeRepository.GetTurnType(int.Parse(TurnTypeCombo.SelectedValue.ToString())).Price.ToString();
        }
        public void initDoctorsGrid()
        {
            DoctorsGrid.AutoGenerateColumns = false;
            List<DoctorViewModel> list = doctorRepository.GetDoctors(int.Parse(TurnTypeCombo.SelectedValue.ToString()),ClinicId);
            DoctorsGrid.DataSource = list.Select(d => new { Id = d.Id, Name = d.Name, Family = d.Family }).ToList();
            if (DoctorsGrid.Rows.Count > 0)
                DoctorsGrid.CurrentCell = DoctorsGrid[0, 0];
        }

        private void IsPaidCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPaidCheck.Checked)
                AddTurnBtn.Enabled = true;
            else
                AddTurnBtn.Enabled = false;
        }

        private void AddTurnBtn_Click(object sender, EventArgs e)
        {
            if (DoctorsGrid.Rows.Count > 0)
            {
                if (FirstTime.Text != null)
                {
                    Turn temp = new Turn()
                    {
                        DoctorId = int.Parse(DoctorsGrid.Rows[int.Parse(DoctorsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString()),
                        PatientId = UserId,
                        StartDate = Convert.ToDateTime(FirstTime.Text),
                        TurnTypeId = int.Parse(TurnTypeCombo.SelectedValue.ToString()),
                        IsPaid = Convert.ToInt32(IsPaidCheck.Checked),
                        ClinicId = this.ClinicId,
                    };
                    turnRepository.AddTurn(temp);
                    MessageBox.Show("عملیات رزرو با موفقیت انجام شد ", "موفق", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("لطفا ابتدا با زدن دکمه یافتن اولین نوبت زمان نوبت خود را مشخص نمایید ! ", "خطا", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("لطفا ابتدا پزشک مورد نظر را انتخاب نمایید ! ", "خطا", MessageBoxButtons.OK);
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class WeekDay
    {
        public int Index { get; set; }
        public string Name { get; set; }
    }
}
