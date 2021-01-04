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
        IPeopleRepository peopleRepository;
        int UserId;
        int ClinicId;
        public ReserveTurn(int userId,int clinicId)
        {
            InitializeComponent();
            UserId = userId;
            ClinicId = clinicId;
            turnRepository = new TurnRepository();
            turnTypeRepository = new TurnTypeRepository();
            doctorRepository = new DoctorRepository();
            peopleRepository = new PeopleRepository();
        }

        private void ReserveTurn_Load(object sender, EventArgs e)
        {
            TurnTypeCombo.DisplayMember = "Name";
            TurnTypeCombo.ValueMember = "Id";
            TurnTypeCombo.DataSource = turnTypeRepository.getTurnTypes();
            initDoctorsGrid();
            People p = peopleRepository.GetPeople(UserId);
            NameLbl.Text += p.Name+ " " + p.Family;
            CodeMelliLbl.Text = p.CodeMelli;
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DoctorId = int.Parse(DoctorsGrid.Rows[int.Parse(DoctorsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            FirstTime.Text = turnRepository.GetFirstTime(DoctorId, int.Parse(TurnTypeCombo.SelectedValue.ToString())).ToString();
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
            List<DoctorViewModel> list = doctorRepository.GetDoctors(int.Parse(TurnTypeCombo.SelectedValue.ToString()));
            DoctorsGrid.DataSource = list.Select(d => new { Id = d.Id, Name = d.Name, Family = d.Family }).ToList();
            DoctorsGrid.CurrentCell = DoctorsGrid[0, 0];
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Turn temp = new Turn()
            {
                DoctorId = int.Parse(DoctorsGrid.Rows[int.Parse(DoctorsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString()),
                PatientId = UserId,
                StartDate = Convert.ToDateTime(FirstTime.Text),
                TurnTypeId = int.Parse(TurnTypeCombo.SelectedValue.ToString()),
                IsPaid = Convert.ToInt32(IsPaidCheck.Checked),
                ClinicId = this.ClinicId

            };
            turnRepository.AddTurn(temp);
            MessageBox.Show("عملیات رزرو با موفقیت انجام شد ");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
