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
    public partial class ManageFinancial : Form
    {
        int ClinicId;
        ITurnRepository turnRepository;
        ITransationRepository transationRepository;
        IClinicRepository clinicRepository;
        public ManageFinancial(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            turnRepository = new TurnRepository();
            transationRepository = new TransationRepository();
            clinicRepository = new ClinicRepository();
        }

        private void ManageFinancial_Load(object sender, EventArgs e)
        {
            monthNUD.Value = DateTime.Now.Month;
            YearNUD.Value = DateTime.Now.Year;
            initReportBox();
        }

        public void initReportBox()
        {
            TotalPriceTxt.Text = turnRepository.GetTotalPrice(ClinicId, int.Parse(monthNUD.Value.ToString()), int.Parse(YearNUD.Value.ToString())).ToString();
            TotalCostTxt.Text = turnRepository.GetTotalCost(ClinicId, int.Parse(monthNUD.Value.ToString()), int.Parse(YearNUD.Value.ToString())).ToString();
            TotalSalaryTxt.Text = transationRepository.GetTotalSalary(ClinicId, int.Parse(monthNUD.Value.ToString()), int.Parse(YearNUD.Value.ToString())).ToString();
            TotalIncomeTxt.Text = (int.Parse(TotalPriceTxt.Text) - int.Parse(TotalCostTxt.Text) - int.Parse(TotalSalaryTxt.Text)).ToString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            initReportBox();
        }

        private void removeFilterBtn_Click(object sender, EventArgs e)
        {
            monthNUD.Value = DateTime.Now.Month;
            YearNUD.Value = DateTime.Now.Year;
        }

        private void PaySalaries_Click(object sender, EventArgs e)
        {
            if (transationRepository.PaySalary(ClinicId) == true)
                MessageBox.Show("عملیات پرداخت با موفقیت انجام شد !", "موفق", MessageBoxButtons.OK);
            else
                MessageBox.Show("شما در این ماه عملیت پرداخت را انجام داده اید !", "خطا", MessageBoxButtons.OK);
        }

        private void AddTurnBtn_Click(object sender, EventArgs e)
        {
            transationRepository.PayStockHoldersProfit(ClinicId);
        }
    }
}
