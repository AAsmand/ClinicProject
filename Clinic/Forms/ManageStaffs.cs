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
    public partial class ManageStaffs : Form
    {
        int ClinicId;
        IStaffRepository staffRepository;
        public ManageStaffs(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            staffRepository = new StaffRepository();
        }

        private void ManageStaffs_Load(object sender, EventArgs e)
        {
            initStaffsGrid();
        }
        public void initStaffsGrid()
        {
            StaffsGrid.AutoGenerateColumns = false;
            List<Staff> list = staffRepository.GetStaffs(ClinicId, NameTxt.Text, FamilyTxt.Text, CodeMelliTxt.Text);
            StaffsGrid.DataSource = list.Select(p => new { Id = p.Id, Name = p.People.Name, Family = p.People.Family,StaffType=p.staffType.Name }).ToList();
            StaffsGrid.CurrentCell = StaffsGrid[0, 0];
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            initStaffsGrid();
        }

        private void FamilyTxt_TextChanged(object sender, EventArgs e)
        {
            initStaffsGrid();
        }

        private void CodeMelliTxt_TextChanged(object sender, EventArgs e)
        {
            initStaffsGrid();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(StaffsGrid.Rows[int.Parse(StaffsGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            var result = MessageBox.Show("آیا از حذف کارمند به شماره " + id + " مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                staffRepository.RemoveStaff(id);
                initStaffsGrid();
            }
            else
            {
                MessageBox.Show("عملیات لغو شد", "لغو عملیات", MessageBoxButtons.OK);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ManageTypeBtn_Click(object sender, EventArgs e)
        {
            ManageStaffTypes manageStaffTypes = new ManageStaffTypes(ClinicId);
            manageStaffTypes.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff(ClinicId);
            if(addStaff.ShowDialog()==DialogResult.OK)
            {
                initStaffsGrid();
            }
        }
    }
}
