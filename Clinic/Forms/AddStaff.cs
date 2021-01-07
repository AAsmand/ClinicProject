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
    public partial class AddStaff : Form
    {
        int ClinicId;
        IPeopleRepository peopleRepository;
        IStaffRepository staffRepository;
        IStaffTypeRepository staffTypeRepository;
        People people;
        public AddStaff(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            peopleRepository = new PeopleRepository();
            staffRepository = new StaffRepository();
            staffTypeRepository = new StaffTypeRepository();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            People p = peopleRepository.GetPeopleByCode(ClinicId,CodeMelliTxt.Text);
            if (p == null)
            {
                if (MessageBox.Show("فرد مورد نظر در دیتابیس وجود ندارد\n مایل به افزودن آن هستید ؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AddEditPeople addPeople = new AddEditPeople(ClinicId);
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

        private void Addpatient_Load(object sender, EventArgs e)
        {
            initTypeCombo();
        }

        public void initTypeCombo()
        {
            List<StaffType> list = staffTypeRepository.GetStaffTypes(ClinicId);
            if (list != null)
            {
                TypeCombo.DataSource = list;
                TypeCombo.DisplayMember = "Name";
                TypeCombo.ValueMember = "Id";
            }
        }

        private void AddTypeBtn_Click(object sender, EventArgs e)
        {
            AddStaffType addStaffType = new AddStaffType(ClinicId);
            if(addStaffType.ShowDialog()==DialogResult.OK)
            {
                initTypeCombo();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff()
            {
                PeopleId = people.Id,
                ClinicId = this.ClinicId,
                StaffTypeId = int.Parse(TypeCombo.SelectedValue.ToString())
            };
            staffRepository.AddStaff(staff);
            var result = MessageBox.Show("عملیات  با موفقیت انجام شد", "موفق", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
