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

            dataGridView1.Location = new Point(60, 180);
            dataGridView1.Size = new Size(850, 400);
        }

        private void LoadDataUser ()
        {
            try
            {
                dataGridView1.DataSource = controller.GetUsers();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.ReadOnly = true;

                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data!\n" + ex.Message);
            }
        }
    }
}
