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
            AddDoctor add = new AddDoctor(ClinicId);
            add.Show();
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
    }
}
