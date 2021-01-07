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
    public partial class EditPercent : Form
    {
        public EditPercent(int percent)
        {
            InitializeComponent();
            PercentTxt.Text = percent.ToString();
        }

        private void EditPercent_Load(object sender, EventArgs e)
        {

        }
        public int getPercent()
        {
            return int.Parse(PercentTxt.Text);
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPercentBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
