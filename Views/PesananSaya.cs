using System;
using System.Windows.Forms;
using System.Data;
using Npgsql;
using project_smt2.Helpers;
using project_smt2.Controllers;

namespace project_smt2.Views
{
    public partial class PesananSaya : UserControl
    {
        public PesananSaya()
        {
            InitializeComponent();
            LoadPesananSaya();
        }

        private void LoadPesananSaya()
        {
            PesananSayaController controller = new PesananSayaController();

            dgvPesananSaya.DataSource =
                controller.GetPesananSayaUser(Session.UserId);
            dgvPesananSaya.Columns["transaksi_id"].HeaderText = "ID Transaksi";
            dgvPesananSaya.Columns["tanggal_transaksi"].HeaderText = "Tanggal";
            dgvPesananSaya.Columns["hewan_ternak_id"].HeaderText = "ID Hewan";
            dgvPesananSaya.Columns["harga_jual"].HeaderText = "Harga";
            dgvPesananSaya.Columns["status_pembayaran"].HeaderText = "Pembayaran";
            dgvPesananSaya.Columns["status_pengiriman"].HeaderText = "Pengiriman";

            lblTotalPesanan.Text = controller.GetTotalPesananUser(Session.UserId).ToString();
            lblSudahTerkirim.Text = controller.GetPesananTerkirimUser(Session.UserId).ToString();
            lblProsesPengiriman.Text = controller.GetPesananProsesUser(Session.UserId).ToString();

        }


        private void dgvPesananSaya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadPesananSaya();
        }

        private void lblTotalPesanan_Click(object sender, EventArgs e)
        {
            LoadPesananSaya();
        }

        private void lblProsesPengiriman_Click(object sender, EventArgs e)
        {
            LoadPesananSaya();
        }

        private void lblSudahTerkirim_Click(object sender, EventArgs e)
        {
            LoadPesananSaya();
        }
    }
}  