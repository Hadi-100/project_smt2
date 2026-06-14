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
            this.AutoScaleMode = AutoScaleMode.None;
            this.Font = new Font("Arial", 9F); // pick one consistent font/size
        }

        public void LoadData()
        {
            HewanController controller = new HewanController();
            dataGridViewDataHewan.DataSource = controller.GetHewan();

            dataGridViewDataHewan.Columns["IDHewan"].HeaderText = "ID Hewan";
            dataGridViewDataHewan.Columns["JenisHewan"].HeaderText = "Jenis Hewan";
            dataGridViewDataHewan.Columns["JenisKelamin"].HeaderText = "Jenis Kelamin";
            dataGridViewDataHewan.Columns["Umur"].HeaderText = "Umur (th)";
            dataGridViewDataHewan.Columns["Berat"].HeaderText = "Berat (kg)";
            dataGridViewDataHewan.Columns["Harga"].HeaderText = "Harga (Rp)";
            dataGridViewDataHewan.Columns["NamaPeternak"].HeaderText = "Peternak";
            dataGridViewDataHewan.Columns["StatusHewan"].HeaderText = "Status Hewan";
            dataGridViewDataHewan.Columns["KondisiFisik"].HeaderText = "Kondisi Fisik";
            dataGridViewDataHewan.Columns["StatusQurban"].HeaderText = "Status Qurban";

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
