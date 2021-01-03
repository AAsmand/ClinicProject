using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicProject.Data.Repositories;
using ClinicProject.Model;

namespace ClinicProject
{
    public partial class AddPatient : Form
    {
        private int clinicId;
        private IPeopleRepository peopleRepository;
        private IPatientRepository patientRepository;
        public AddPatient(int _clinicId)
        {
            InitializeComponent();
            peopleRepository = new PeopleRepository();
            patientRepository = new PatientRepository();
            clinicId = _clinicId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            Check();
        }
        public void Check()
        {
            People temp = peopleRepository.CheckExist(CodeMelliTxt.Text);
            if (temp != null)
            {
                NameTxt.Text = temp.Name;
                FamilyTxt.Text = temp.Family;
                TellTex.Text = temp.Tell;
                UsernameTxt.Text = temp.Username;
                PassTxt.Text = temp.Password;
                NameTxt.Enabled = false;
                FamilyTxt.Enabled = false;
                TellTex.Enabled = false;
                UsernameTxt.Enabled = false;
                PassTxt.Enabled = false;
                AddBtn.Enabled = true;
            }
            else
            {
                NameTxt.Enabled = true;
                FamilyTxt.Enabled = true;
                TellTex.Enabled = true;
                UsernameTxt.Enabled = true;
                PassTxt.Enabled = true;
                AddBtn.Enabled = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            People temp = new People()
            {
                Name = NameTxt.Text,
                Family = FamilyTxt.Text,
                Tell = TellTex.Text,
                CodeMelli = CodeMelliTxt.Text,
                Username = UsernameTxt.Text,
                Password = PassTxt.Text
            };
            if(NameTxt.Enabled==true)
            {
                peopleRepository.AddPeople(temp);
                
            }
            Patient patient = new Patient()
            {
                PeopleId = peopleRepository.CheckExist(temp.CodeMelli).Id,
                ClinicId = clinicId,
            };
            if(patientRepository.IsExist(temp.CodeMelli)==null)
            patientRepository.AddPatient(patient);
            else
            {
                MessageBox.Show("پرونده ای با این کد ملی در سیستم موجود است !", "خطا", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
