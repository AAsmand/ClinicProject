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
    public partial class AddEditPeople : Form
    {
        private int clinicId;
        private IPeopleRepository peopleRepository;
        private IPatientRepository patientRepository;
        private ICheckRepository CheckRepository;
        int PeopleId;
        public AddEditPeople(int _clinicId, int peopleId = 0)
        {
            InitializeComponent();
            peopleRepository = new PeopleRepository();
            patientRepository = new PatientRepository();
            CheckRepository = new CheckRepository();
            clinicId = _clinicId;
            PeopleId = peopleId;
        }
        private void AddPeople_Load(object sender, EventArgs e)
        {
            People temp = peopleRepository.GetPeople(PeopleId);
            if (PeopleId > 0)
            {
                this.Text = "ویرایش پرونده";
                label4.Text = "ویرایش پرونده";
                CodeMelliTxt.Text = temp.CodeMelli;
                NameTxt.Text = temp.Name;
                FamilyTxt.Text = temp.Family;
                TellTex.Text = temp.Tell;
                UsernameTxt.Text = temp.Username;
                PassTxt.Text = temp.Password;
                AccountNumberTxt.Text = temp.AccountNumber;

                CodeMelliTxt.Enabled = false;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPeopleBtn_Click(object sender, EventArgs e)
        {
            if (PeopleId > 0)
            {
                People temp = peopleRepository.GetPeople(PeopleId);
                temp.AccountNumber = AccountNumberTxt.Text;
                temp.Name = NameTxt.Text;
                temp.Family = FamilyTxt.Text;
                temp.Tell = TellTex.Text;
                temp.Username = UsernameTxt.Text;
                temp.Password = PassTxt.Text;
                string result = CheckRepository.CheckPeople(temp, true);
                if (result == "")
                {
                    peopleRepository.Update();
                    MessageBox.Show("عملیات با موفقیت انجام شد!", "موفق", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    ErrorLbl.Text = result;
            }
            else
            {
                CodeMelliTxt.Enabled = true;
                People temp = new People()
                {
                    Name = NameTxt.Text,
                    Family = FamilyTxt.Text,
                    Tell = TellTex.Text,
                    CodeMelli = CodeMelliTxt.Text,
                    AccountNumber = AccountNumberTxt.Text,
                    Username = UsernameTxt.Text,
                    Password = PassTxt.Text,
                    ClinicId = clinicId
                };
                string result = CheckRepository.CheckPeople(temp, false);
                if (result == "")
                {
                    peopleRepository.AddPeople(temp);
                    MessageBox.Show("عملیات با موفقیت انجام شد!", "موفق", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    ErrorLbl.Text = result;
            }
        }
    }
}
