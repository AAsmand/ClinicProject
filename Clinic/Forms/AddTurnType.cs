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
    public partial class AddTurnType : Form
    {
        ITurnTypeRepository turnTypeRepository;
        int ClinicId;
        
        public AddTurnType(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            turnTypeRepository = new TurnTypeRepository();
        }
        private void AddTurnType_Load(object sender, EventArgs e)
        {
           
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTypeBtn_Click(object sender, EventArgs e)
        {
            TimeSpan t = new TimeSpan(int.Parse(HourTxt.Text), int.Parse(MinTxt.Text), 0);
            TurnType temp = new TurnType()
            {
                Name = NameTxt.Text,
                Cost = int.Parse(CostTxt.Text),
                Price = int.Parse(PriceTxt.Text),
                DoctorComission = int.Parse(ComissionTxt.Text),
                Duration = t,
                ClinicId = this.ClinicId
            };
            turnTypeRepository.AddTurnType(temp);
            MessageBox.Show("عملیات ثبت خدمت با موفقیت انجام شد", "موفق", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
