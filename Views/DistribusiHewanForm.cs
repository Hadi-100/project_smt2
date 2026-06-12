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
    public partial class DistribusiHewanForm : UserControl
    {
        private PengirimanController controller =
            new PengirimanController();

        private void LoadDistribusiHewan()
        {
            try
            {
                dgvDistribusiHewan.DataSource =
                    controller.GetDistribusiHewan();

                dgvDistribusiHewan.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvDistribusiHewan.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvDistribusiHewan.ReadOnly = true;

                dgvDistribusiHewan.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data!\n" +
                    ex.Message
                );
            }
        }

        private void LoadStatistik()
        {
            lblTerkirim.Text = controller.GetTotalTerkirim().ToString();
            lblProses.Text = controller.GetTotalProses().ToString();
            lblDistribusi.Text = controller.GetTotalDistribusi().ToString();
        }

        public DistribusiHewanForm()
        {
            InitializeComponent();

            LoadDistribusiHewan();

            LoadStatistik();
        }

        private void DistribusiHewanForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDistribusi_Click(object sender, EventArgs e)
        {

        }
    }
}
