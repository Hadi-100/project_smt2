using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class DashboardAdminForm : Form
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
            new AutoScaleHelper(this);
        }

        private void DashboardAdminForm_Load(object sender, EventArgs e)
        {
            //lblJudul.Text = "Dashboard Admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardAdminForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
