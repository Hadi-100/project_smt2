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
        // Event raised when the Tambah button is clicked so parent forms can respond
        public event EventHandler BtnTambahClicked;

        public DataHewanForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.Font = new Font("Arial", 9F); // pick one consistent font/size
        }

        public void LoadData()
        {
            HewanController controller = new HewanController();
            DataTable dt = controller.GetHewan();
            PanellHelper.MakeButtonRounded(btnTambah, 25);
            dgvDataHewan.DataSource = dt;
            dgvDataHewan.AutoResizeColumns();
            dgvDataHewan.AutoResizeRows();
            dgvDataHewan.Columns["hewan_ternak_id"].HeaderText = "ID Hewan";
            dgvDataHewan.Columns["jenis_hewan"].HeaderText = "Jenis Hewan";
            dgvDataHewan.Columns["jenis_kelamin"].HeaderText = "Jenis Kelamin";
            dgvDataHewan.Columns["umur"].HeaderText = "Umur (th)";
            dgvDataHewan.Columns["berat"].HeaderText = "Berat (kg)";
            dgvDataHewan.Columns["harga"].HeaderText = "Harga (Rp)";
            dgvDataHewan.Columns["nama_peternak"].HeaderText = "Peternak";
            dgvDataHewan.Columns["status_hewan"].HeaderText = "Status Hewan";
            dgvDataHewan.Columns["kondisi_fisik"].HeaderText = "Kondisi Fisik";
            dgvDataHewan.Columns["status_qurban"].HeaderText = "Status Qurban";
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

        public void btnTambah_Click(object sender, EventArgs e)
        {
            BtnTambahClicked?.Invoke(this, e);
            LoadData();
        }

        private void dgvDataHewan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
