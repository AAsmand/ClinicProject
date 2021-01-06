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
using ClinicProject.Data;
using ClinicProject.Data.Repositories;

namespace ClinicProject
{
    public partial class ManageStaffTypes : Form
    {
        IStaffTypeRepository staffTypeRepository;
        int ClinicId;
        public ManageStaffTypes(int clinicId)
        {
            InitializeComponent();
            staffTypeRepository = new StaffTypeRepository();
            ClinicId = clinicId;
        }

        private void ManageTypeService_Load(object sender, EventArgs e)
        {
            initGrid();
        }
        public void initGrid()
        {
            StaffTypeGrid.AutoGenerateColumns = false;
            StaffTypeGrid.DataSource = staffTypeRepository.GetStaffTypes(ClinicId);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int TypeId = int.Parse(StaffTypeGrid.Rows[int.Parse(StaffTypeGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            var result = MessageBox.Show("آیا از حذف خدمات شماره " + TypeId + " مطمئن هستید ؟(تمامی دیتا های مربوط به این رکورد حذف خواهد شد )", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                staffTypeRepository.RemoveStaffType(TypeId);
                initGrid();
            }
            else
            {
                MessageBox.Show("عملیات لغو شد", "لغو عملیات", MessageBoxButtons.OK);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddStaffType addStaff = new AddStaffType(ClinicId);
            if(addStaff.ShowDialog()==DialogResult.OK)
            {
                initGrid();
            }
        }
    }
}
