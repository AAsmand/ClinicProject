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
    public partial class ClerkPannel : Form
    {
        private IPatientRepository PatientRepository;
        private ITurnRepository TurnRepository;
        private int clinicId;
        public ClerkPannel(int _clinicId)
        {
            InitializeComponent();
            PatientRepository = new PatientRepository();
            TurnRepository = new TurnRepository();
            clinicId = _clinicId;
        }

        private void StaffPannel_Load(object sender, EventArgs e)
        {
            initPatiendGrid();
            initTurnGrid();
        }
        public void initPatiendGrid()
        {
            PatientsGrid.AutoGenerateColumns = false;
            List<Patient> list = PatientRepository.GetPatients(NameTxt.Text, FamilyTxt.Text, CodeMelliTxt.Text);
            PatientsGrid.DataSource = list.Select(p => new { Id = p.Id, Name = p.People.Name, Family = p.People.Family, CodeMelli = p.People.CodeMelli }).ToList();
            if(PatientsGrid.Rows.Count>0)
            PatientsGrid.CurrentCell = PatientsGrid[0, 0];
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            initPatiendGrid();
            initTurnGrid();
        }

        private void FamilyTxt_TextChanged(object sender, EventArgs e)
        {
            initPatiendGrid();
            initTurnGrid();
        }

        private void CodeMelliTxt_TextChanged(object sender, EventArgs e)
        {
            initPatiendGrid();
            initTurnGrid();
        }

        private void PatientsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            initTurnGrid();
        }
        public void initTurnGrid()
        {
            TurnsGrid.AutoGenerateColumns = false;
            if (PatientsGrid.Rows.Count > 0)
            {
                int id = int.Parse(PatientsGrid.Rows[int.Parse(PatientsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
                TurnsGrid.DataSource = TurnRepository.GetPatientTurn(id).Select(T => new { Id = T.Id, Date = T.StartDate, DoctorName = T.doctor.People.Name + " " + T.doctor.People.Family, Type = T.TurnType.Name, IsPaid = T.IsPaid, TurnPrice = T.TurnType.Price }).ToList();
                if (TurnsGrid.Rows.Count > 0)
                    TurnsGrid.CurrentCell = TurnsGrid[0, 0];
            }
            else
                TurnsGrid.DataSource = null;

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            TurnsGrid.AutoGenerateColumns = false;
            int id = int.Parse(PatientsGrid.Rows[int.Parse(PatientsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            TurnsGrid.DataSource = TurnRepository.GetPatientTurn(id,TurnDatePic.Value).Select(T => new { Id = T.Id, Date = T.StartDate, DoctorName = T.doctor.People.Name, Type = T.TurnType.Name, IsPaid = T.IsPaid, TurnPrice = T.TurnType.Price }).ToList();
        }

        private void removeFilterBtn_Click(object sender, EventArgs e)
        {
            initTurnGrid();
        }

        private void CancelTurnBtn_Click(object sender, EventArgs e)
        {
            Addpatient a = new Addpatient(clinicId);
            if(a.ShowDialog()==DialogResult.OK)
            {
                initPatiendGrid();
                initTurnGrid();
            }
        }

        private void AddTurnBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(PatientsGrid.Rows[int.Parse(PatientsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            ReserveTurn reserve = new ReserveTurn(id,clinicId);
            if(reserve.ShowDialog()==DialogResult.OK)
            {
                initTurnGrid();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int id= int.Parse(TurnsGrid.Rows[int.Parse(TurnsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            var result = MessageBox.Show("آیا از حذف نوبت شماره " + TurnsGrid.Rows[int.Parse(TurnsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString() + " مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TurnRepository.RemoveTurn(id);
                initTurnGrid();
            }
            else
            {
                MessageBox.Show("عملیات لغو شد", "لغو عملیات", MessageBoxButtons.OK);
            }
        }
    }
}
