using project_smt2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class DataHewanForm : UserControl
    {
        public DataHewanForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            HewanController controller = new HewanController();
            DataTable dt = controller.GetHewan();

            dataGridViewDataHewan.DataSource = dt;

            dataGridViewDataHewan.Columns["hewan_ternak_id"].HeaderText = "ID Hewan";
            dataGridViewDataHewan.Columns["jenis_hewan"].HeaderText = "Jenis Hewan";
            dataGridViewDataHewan.Columns["jenis_kelamin"].HeaderText = "Jenis Kelamin";
            dataGridViewDataHewan.Columns["umur"].HeaderText = "Umur (th)";
            dataGridViewDataHewan.Columns["berat"].HeaderText = "Berat (kg)";
            dataGridViewDataHewan.Columns["harga"].HeaderText = "Harga (Rp)";
            dataGridViewDataHewan.Columns["nama_peternak"].HeaderText = "Peternak";
            dataGridViewDataHewan.Columns["status_hewan"].HeaderText = "Status Hewan";
            dataGridViewDataHewan.Columns["kondisi_fisik"].HeaderText = "Kondisi Fisik";
            dataGridViewDataHewan.Columns["status_qurban"].HeaderText = "Status Qurban";

            lblhewantersedia.Text = controller.GetTotalTersedia().ToString();
            lbltotalsapi.Text = controller.GetTotalSapi().ToString();
            lbltotalkambing.Text = controller.GetTotalKambing().ToString();
            lblhewanterjual.Text = controller.GetTotalTerjual().ToString();
        }

        private void DataHewanForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lbltotalsapi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblhewanterjual_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewDataHewan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
