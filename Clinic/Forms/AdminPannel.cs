﻿using ClinicProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicProject
{
    public partial class AdminPannel : Form
    {
        int ClinicId;
        public AdminPannel(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
        }

        private void AdminPannel_Load(object sender, EventArgs e)
        {

        }

        private void ManagePatients_Click(object sender, EventArgs e)
        {
            ClerkPannel pannel = new ClerkPannel(ClinicId);
            pannel.Show();
        }

        private void TypeManageBtn_Click(object sender, EventArgs e)
        {
            ManageTypeService manage = new ManageTypeService(ClinicId);
            manage.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ManageStaffs manage = new ManageStaffs(ClinicId);
            manage.Show();
        }

        private void AddTurnBtn_Click(object sender, EventArgs e)
        {
            DoctorPannel pannel = new DoctorPannel(ClinicId);
            pannel.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StockHolderPannel pannel = new StockHolderPannel(ClinicId);
            pannel.Show();
        }

        private void AddPeopleBtn_Click(object sender, EventArgs e)
        {
            ManagePeople a = new ManagePeople(ClinicId);
            a.ShowDialog();
        }

        private void ManageFinancialBtn_Click(object sender, EventArgs e)
        {
            ManageFinancial manageFinancial = new ManageFinancial(ClinicId);
            manageFinancial.Show();
        }

        private void ClinicSetting_Click(object sender, EventArgs e)
        {
            ClinicSettingPannel pannel = new ClinicSettingPannel(ClinicId);
            pannel.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
