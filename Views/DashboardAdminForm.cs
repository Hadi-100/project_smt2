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

            distribusiHewanForm1.Visible = false;
            riwayatTransaksiForm1.Visible = true;
            tambah_hewan_ternak1.Visible = false;
            dataHewanForm2.Visible = false;

            dataUserForm1.Visible = false;
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

        private void distribusiHewanForm1_Load(object sender, EventArgs e)
        {
        }

        private void riwayatTransaksiForm1_Load(object sender, EventArgs e)
        {

        }

        private void tambah_hewan_ternak1_Load(object sender, EventArgs e)
        {

        }

        private void dataUserForm1_Load(object sender, EventArgs e)
        {

        }

        private void dataHewanForm2_Load(object sender, EventArgs e)
        {

        }


        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
