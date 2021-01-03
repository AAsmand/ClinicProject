﻿using System;
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
    public partial class StaffPannel : Form
    {
        private IPatientRepository PatientRepository;
        private ITurnRepository TurnRepository;
        private int clinicId;
        public StaffPannel(int _clinicId)
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
            PatientsGrid.CurrentCell = PatientsGrid[0, 0];
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            initPatiendGrid();
        }

        private void FamilyTxt_TextChanged(object sender, EventArgs e)
        {
            initPatiendGrid();
        }

        private void CodeMelliTxt_TextChanged(object sender, EventArgs e)
        {
            initPatiendGrid();
        }

        private void PatientsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            initTurnGrid();
        }
        public void initTurnGrid()
        {
            TurnsGrid.AutoGenerateColumns = false;
            int id = int.Parse(PatientsGrid.Rows[int.Parse(PatientsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            TurnsGrid.DataSource = TurnRepository.GetPatientTurn(id).Select(T => new { Id = T.Id, Date = T.StartDate, DoctorName = T.doctor.People.Name, Type = T.TurnType.Name, IsPaid = T.IsPaid, TurnPrice = T.TurnType.Price }).ToList();
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
            AddPatient a = new AddPatient(clinicId);
            if(a.ShowDialog()==DialogResult.OK)
            {
                initPatiendGrid();
                initTurnGrid();
            }
        }
    }
}