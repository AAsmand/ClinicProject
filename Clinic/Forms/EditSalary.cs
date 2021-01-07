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
    public partial class EditSalary : Form
    {
        IStaffTypeRepository staffTypeRepository;
        int StaffTypeId;
        public EditSalary(int staffTypeId,int salary)
        {
            InitializeComponent();
            SalaryTxt.Text = salary.ToString();
            StaffTypeId = staffTypeId;
            staffTypeRepository = new StaffTypeRepository();
        }

        private void EditPercent_Load(object sender, EventArgs e)
        {

        }
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditSalaryBtn_Click(object sender, EventArgs e)
        {
            staffTypeRepository.UpdateSalary(StaffTypeId, int.Parse(SalaryTxt.Text));
            this.Close();
        }
    }
}
