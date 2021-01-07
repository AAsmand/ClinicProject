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
    public partial class AddStaffType : Form
    {
        IStaffTypeRepository staffTypeRepository;
        int ClinicId;
        
        public AddStaffType(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            staffTypeRepository = new StaffTypeRepository();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStaffTypeBtn_Click(object sender, EventArgs e)
        {
            StaffType temp = new StaffType()
            {
                Name = NameTxt.Text,
                Salary = int.Parse(SalaryTxt.Text),
                ClinicId = this.ClinicId
            };
            staffTypeRepository.AddStaffType(temp);
            MessageBox.Show("عملیات ثبت خدمت با موفقیت انجام شد", "موفق", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
