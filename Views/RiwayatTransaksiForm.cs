using Project.Models;
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
    public partial class RiwayatTransaksiForm : UserControl
    {
        public RiwayatTransaksiForm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            TransaksiController controller = new TransaksiController();
            DataTable dt = controller.GetRiwayat();

            dataGridViewRiwayat.DataSource = dt;

            dataGridViewRiwayat.Columns["transaksi_id"].HeaderText = "ID Transaksi";
            dataGridViewRiwayat.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
            dataGridViewRiwayat.Columns["tanggal_transaksi"].HeaderText = "Tanggal Transaksi";
            dataGridViewRiwayat.Columns["harga_jual"].HeaderText = "Harga Jual";
            dataGridViewRiwayat.Columns["status_pembayaran"].HeaderText = "Status Pembayaran";

            lblTotalTransaksi.Text = controller.GetTotalTransaksi().ToString();
            lblbelumbayar.Text = controller.GetTotalBelumBayar().ToString();
            lblbelumlunas.Text = controller.GetTotalSudahLunas().ToString();
            lblnilaitotal.Text = "Rp " + controller.GetNilaiTotal().ToString("N0");
        }

        private void RiwayatTransaksiForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void dataGridViewRiwayatTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalTransaksi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblbelumbayar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblbelumlunas_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblnilaitotal_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
