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
    public partial class DoctorPannel : Form
    {
        IDoctorRepository doctorRepository;
        ITurnRepository turnRepository;
        int ClinicId;
        public DoctorPannel(int clinicId)
        {
            InitializeComponent();
            doctorRepository = new DoctorRepository();
            turnRepository = new TurnRepository();
            ClinicId = clinicId;
        }

        private void DoctorPannel_Load(object sender, EventArgs e)
        {
            initDoctorsGrid();
            initTurnGrid();
        }
        public void initDoctorsGrid()
        {
            DoctorsGrid.AutoGenerateColumns = false;
            List<DoctorViewModel> list = doctorRepository.GetDoctors(ClinicId, NameTxt.Text, FamilyTxt.Text, CodeMelliTxt.Text);
            DoctorsGrid.DataSource = list.Select(p => new { Id = p.Id, Name = p.Name, Family = p.Family }).ToList();
            if (DoctorsGrid.Rows.Count > 0)
                DoctorsGrid.CurrentCell = DoctorsGrid[0, 0];
        }
        public void initTurnGrid()
        {
            if (DoctorsGrid.Rows.Count > 0)
            {
                TurnsGrid.AutoGenerateColumns = false;
                int id = int.Parse(DoctorsGrid.Rows[int.Parse(DoctorsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
                TurnsGrid.DataSource = null;
                TurnsGrid.DataSource = turnRepository.GetDoctorTurn(id, ClinicId).Select(T => new { Id = T.Id, Date = T.StartDate, PatientName = T.doctor.People.Name + " " + T.doctor.People.Family, Type = T.TurnType.Name, IsPaid = T.IsPaid, TurnPrice = T.TurnType.Price }).ToList();
                if (TurnsGrid.Rows.Count > 0)
                    TurnsGrid.CurrentCell = TurnsGrid[0, 0];
            }
            else
                TurnsGrid.DataSource = null;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DoctorsGrid.Rows[int.Parse(DoctorsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            var result = MessageBox.Show("آیا از حذف پزشک به شماره " + id + " مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                doctorRepository.RemoveDoctor(id);
                initDoctorsGrid();
                initTurnGrid();
            }
            else
            {
                MessageBox.Show("عملیات لغو شد", "لغو عملیات", MessageBoxButtons.OK);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor(ClinicId);
            if (addDoctor.ShowDialog() == DialogResult.OK)
            {
                initDoctorsGrid();
            }
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            initDoctorsGrid();
            initTurnGrid();
        }

        private void FamilyTxt_TextChanged(object sender, EventArgs e)
        {
            initDoctorsGrid();
            initTurnGrid();
        }

        private void CodeMelliTxt_TextChanged(object sender, EventArgs e)
        {
            initDoctorsGrid();
            initTurnGrid();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            initTurnGrid();
        }

        private void DoctorsGrid_Click(object sender, EventArgs e)
        {
            initTurnGrid();
        }
    }
}
