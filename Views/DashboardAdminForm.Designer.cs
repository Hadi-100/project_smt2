using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class DashboardAdminForm : Form
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
        }

        private void DashboardAdminForm_Load(object sender, EventArgs e)
        {
            lblJudul.Text = "Dashboard Admin";
        }
    }
}