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
        }

        private void DashboardAdminForm_Load(object sender, EventArgs e)
        {
            //lblJudul.Text = "Dashboard Admin";
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // DashboardAdminForm
            // 
            ClientSize = new Size(1500, 831);
            Name = "DashboardAdminForm";
            ResumeLayout(false);

        }
    }
}
