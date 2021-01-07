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
    public partial class ManagePeople : Form
    {
        int ClinicId;
        IPeopleRepository peopleRepository;
        public ManagePeople(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            peopleRepository = new PeopleRepository();
        }

        public void initPeopleGrid()
        {
            PeoplesGrid.AutoGenerateColumns = false;
            List<People> list = peopleRepository.GetPeoples(ClinicId, NameTxt.Text, FamilyTxt.Text, CodeMelliTxt.Text);
            PeoplesGrid.DataSource = list.Select(p => new { Id = p.Id, Name = p.Name, Family = p.Family, CodeMelli = p.CodeMelli, Tell = p.Tell, AccountNumber = p.AccountNumber, Username = p.Username }).ToList();
            if (PeoplesGrid.Rows.Count > 0)
                PeoplesGrid.CurrentCell = PeoplesGrid[0, 0];
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            initPeopleGrid();
        }

        private void FamilyTxt_TextChanged(object sender, EventArgs e)
        {
            initPeopleGrid();
        }

        private void CodeMelliTxt_TextChanged(object sender, EventArgs e)
        {
            initPeopleGrid();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(PeoplesGrid.Rows[int.Parse(PeoplesGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            var result = MessageBox.Show("آیا از حذف فرد به شماره " + id + " مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                peopleRepository.RemovePeople(ClinicId, id);
                initPeopleGrid();
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
            AddEditPeople people = new AddEditPeople(ClinicId);
            if (people.ShowDialog() == DialogResult.OK)
            {
                initPeopleGrid();
            }
        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            initPeopleGrid();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(PeoplesGrid.Rows[int.Parse(PeoplesGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            AddEditPeople people = new AddEditPeople(ClinicId, id);
            if (people.ShowDialog() == DialogResult.OK)
            {
                initPeopleGrid();
            }
        }
    }
}
