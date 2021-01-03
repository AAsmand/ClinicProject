using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicProject.Data;
using ClinicProject.Model;
using ClinicProject.Data.Repositories;

namespace ClinicProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            IStaffRepository staffRepository = new StaffRepository();
            Staff user = staffRepository.Login(UserTxt.Text, PassTxt.Text);
            if (user != null)
            {
                //if (user.IsAdmin)
                //{
                //    Admin a = new Admin();
                //    this.Hide();
                //    a.ShowDialog();
                //}
                //else
                //{
                //    UserForm u = new UserForm(user.CustomerId);
                //    this.Hide();
                //    u.ShowDialog();
                //}
                StaffPannel pannel = new StaffPannel(user.ClinicId);
                pannel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("چنین کاربری در سیستم وجود ندارد", "خطا", MessageBoxButtons.OK);
            }
        }
    }
}
