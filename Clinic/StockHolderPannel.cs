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
        public StockHolderPannel(int clinicId)
        {
            InitializeComponent();
            StockHolderRepository = new StockHolderRepository();
            ClinicId = clinicId;
        }

        private void StockHolderPannel_Load(object sender, EventArgs e)
        {
            initStockHolderGrid();
        }
        public void initStockHolderGrid()
        {
            StockHolderGrid.AutoGenerateColumns = false;
            List<StockHolder> list = StockHolderRepository.GetStockHolders(ClinicId);
            StockHolderGrid.DataSource = list.Select(p => new { Id = p.StockHolderId, Name = p.People.Name, Family = p.People.Family, CodeMelli = p.People.CodeMelli ,StockPercent=p.StockPercent}).ToList();
            StockHolderGrid.CurrentCell = StockHolderGrid[0, 0];
        }
    }
}
