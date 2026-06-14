using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using project_smt2.Controllers;

namespace project_smt2.Views
{
    public partial class DataUserForm : UserControl
    {
        UserController controller =
            new UserController();
        public DataUserForm()
        {
            InitializeComponent();
            new AutoScaleHelper(this);

            LoadDataUser();
        }

        public void LoadDataUser()
        {
            dataGridView1.DataSource = controller.GetUsers();


            lblTotalUser.Text = controller.GetTotalUser().ToString();
            lblTotalAdmin.Text = controller.GetTotalAdmin().ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalUser_Click(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void lblTotalAdmin_Click(object sender, EventArgs e)
        {
            LoadDataUser();
        }
    }
}
