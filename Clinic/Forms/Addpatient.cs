using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicProject.Model;
using ClinicProject.Data.Repositories;

namespace ClinicProject
{
    public partial class Addpatient : Form
    {
        int ClinicId;
        IPeopleRepository peopleRepository;
        IPatientRepository patientRepository;
        People people;
        public Addpatient(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            peopleRepository = new PeopleRepository();
            patientRepository = new PatientRepository();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            People p = peopleRepository.GetPeopleByCode(CodeMelliTxt.Text);
            if (p == null)
            {
                if (MessageBox.Show("فرد مورد نظر در دیتابیس وجود ندارد\n مایل به افزودن آن هستید ؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AddPeople addPeople = new AddPeople(ClinicId);
                    addPeople.Show();
                }
            }
            else
            {
                NameLbl.Text = "";
                NameLbl.Text += p.Name + " " + p.Family;
                CodeMelliLbl.Text = p.CodeMelli;
                people = p;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                PeopleId = people.Id,
                ClinicId = this.ClinicId,
            };
            patientRepository.AddPatient(patient);
            var result = MessageBox.Show("عملیات  با موفقیت انجام شد", "موفق", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Addpatient_Load(object sender, EventArgs e)
        {

        }
    }
}
