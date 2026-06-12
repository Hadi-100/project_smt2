using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using project_smt2.Controllers;

namespace project_smt2.Views
{
    public partial class DashboardAdminForm : Form
    {
        private UserController controller = new UserController();

        public DashboardAdminForm()
        {
            InitializeComponent();
            new AutoScaleHelper(this);

            //dataUserForm1.Hide();
            dataHewanForm1.Hide();
            distribusiHewanForm1.Hide();
            riwayatTransaksiForm1.Hide();

            dataUserForm1.Show();
            dataUserForm1.BringToFront();
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

        private void dataHewanForm1_Load(object sender, EventArgs e)
        {

        }

        private void LoadStatistik()
        {
      
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
