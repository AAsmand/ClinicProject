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
    public partial class StockHolderPannel : Form
    {
        IStockHolderRepository StockHolderRepository;
        int ClinicId;
        List<StockHolder> list;
        public StockHolderPannel(int clinicId)
        {
            InitializeComponent();
            StockHolderRepository = new StockHolderRepository();
            ClinicId = clinicId;
            list = StockHolderRepository.GetStockHolders(ClinicId);
        }

        private void StockHolderPannel_Load(object sender, EventArgs e)
        {
            initStockHolderGrid();
        }
        public void initStockHolderGrid()
        {
            StockHolderGrid.AutoGenerateColumns = false;
            StockHolderGrid.DataSource = list.Select(p => new { Id = p.StockHolderId, Name = p.People.Name, Family = p.People.Family, CodeMelli = p.People.CodeMelli, StockPercent = p.StockPercent }).ToList();
            if (StockHolderGrid.Rows.Count > 0)
                StockHolderGrid.CurrentCell = StockHolderGrid[0, 0];
        }

        private void EditPercentBtn_Click(object sender, EventArgs e)
        {
            EditPercent editPercent = new EditPercent(int.Parse(StockHolderGrid.Rows[int.Parse(StockHolderGrid.CurrentCell.RowIndex.ToString())].Cells[4].Value.ToString()));
            int percent;
            if (editPercent.ShowDialog() == DialogResult.OK)
            {
                percent = editPercent.getPercent();
                list.Find(s => s.StockHolderId == int.Parse(StockHolderGrid.Rows[int.Parse(StockHolderGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString())).StockPercent = percent;
                initStockHolderGrid();
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            int sum = list.Sum(s => s.StockPercent);
            if (sum != 100)
            {
                MessageBox.Show("مجموع درصد های مالکیت باید برابر 100 شود !", "خطا", MessageBoxButtons.OK);
            }
            else
            {
                StockHolderRepository.Update();
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفق", MessageBoxButtons.OK);
                initStockHolderGrid();
            }
        }
    }
}
