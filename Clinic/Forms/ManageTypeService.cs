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
    public partial class ManageTypeService : Form
    {
        ITurnTypeRepository turnTypeRepository;
        int ClinicId;
        public ManageTypeService(int clinicId)
        {
            InitializeComponent();
            turnTypeRepository = new TurnTypeRepository();
            ClinicId = clinicId;
        }

        private void ManageTypeService_Load(object sender, EventArgs e)
        {
            initGrid();
        }
        public void initGrid()
        {
            TurnTypeGrid.AutoGenerateColumns = false;
            TurnTypeGrid.DataSource = turnTypeRepository.getTurnTypes(ClinicId);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int TypeId = int.Parse(TurnTypeGrid.Rows[int.Parse(TurnTypeGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
            var result = MessageBox.Show("آیا از حذف خدمات شماره " + TypeId + " مطمئن هستید ؟(تمامی دیتا های مربوط به این رکورد حذف خواهد شد )", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                turnTypeRepository.RemoveTurnType(TypeId);
                initGrid();
            }
            else
            {
                MessageBox.Show("عملیات لغو شد", "لغو عملیات", MessageBoxButtons.OK);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddTurnType addTurnType = new AddTurnType(ClinicId);
            if(addTurnType.ShowDialog()==DialogResult.OK)
            {
                initGrid();
            }
        }
    }
}
