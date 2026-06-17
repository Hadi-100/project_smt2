using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using project_smt2.Controllers;
using System.Globalization;

namespace project_smt2.Views
{
    public partial class DashboardAdminForm : Form
    {
        private UserController controller = new UserController();

        public DashboardAdminForm()
        {
            InitializeComponent();
            PanellHelper.MakeButtonRounded(btnDashboard, 10);
            PanellHelper.MakeButtonRounded(btnUsers, 10);
            PanellHelper.MakeButtonRounded(btnHewanTernak, 10);
            PanellHelper.MakeButtonRounded(btnRiwayat, 10);
            PanellHelper.MakeButtonRounded(btnLaporan, 10);
            PanellHelper.MakeButtonRounded(btnDistribusi, 10);
            new AutoScaleHelper(this);

            //lbDistribusi.Hide();
            //lbJumlahuser.Hide();
            //lbTotalTransaksi.Hide();
            //lbHewanTersedia.Hide();
            //lbHewanTerjual.Hide();
            //lbPendapatanTotal.Hide();
            //dgvRiwayatTransaksi.Hide();
            dataUserForm1.Hide();
            dataHewanForm2.Hide();
            tambah_hewan_ternak1.Hide();
            riwayatTransaksiForm1.Hide();
            dataHewanForm2.BtnTambahClicked += DataHewanForm2_BtnTambahClicked;
            tambah_hewan_ternak1.BtnBatalClicked += Tambah_hewan_ternak1_BtnBatalClicked;
            tambah_hewan_ternak1.BtnTambahClicked += DataHewanForm2_BtnTambahClicked;
            editKlasifikasiQurbanForm1.btnBatalClick += editKlasifikasiQurbanForm1_btnBatalClick;
            editKlasifikasiQurbanForm1.btnKonfirmasiClick += editKlasifikasiQurbanForm1_btnKonfirmasiClick; 
            dataHewanForm2.EditRequested += DataHewanForm2_EditRequested;
            distribusiHewanForm2.Hide();
            laporanPenjualanForm1.Hide();
            editKlasifikasiQurbanForm1.Hide();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                TransaksiController controller = new TransaksiController();
                DashboardController dashcntrl = new DashboardController();
                HewanController hewancntrl = new HewanController();
                PengirimanController kirimcntrl = new PengirimanController();

                DataTable dt = controller.GetRiwayat();
                // remove any existing columns (designer or previous binds) so we don't get duplicates
                dgvDashAdmin.Columns.Clear();
                dgvDashAdmin.AutoGenerateColumns = true;
                dgvDashAdmin.DataSource = dt;
                dgvDashAdmin.AutoResizeColumns();
                dgvDashAdmin.AutoResizeRows();

                // Only set column headers if columns exist
                if (dgvDashAdmin.Columns.Contains("transaksi_id"))
                    dgvDashAdmin.Columns["transaksi_id"].HeaderText = "ID Transaksi";
                if (dgvDashAdmin.Columns.Contains("nama_lengkap"))
                    dgvDashAdmin.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
                if (dgvDashAdmin.Columns.Contains("tanggal_transaksi"))
                    dgvDashAdmin.Columns["tanggal_transaksi"].HeaderText = "Tanggal Transaksi";
                if (dgvDashAdmin.Columns.Contains("harga_jual"))
                    dgvDashAdmin.Columns["harga_jual"].HeaderText = "Harga Jual";
                if (dgvDashAdmin.Columns.Contains("subtotal"))
                    dgvDashAdmin.Columns["subtotal"].HeaderText = "Subtotal";
                if (dgvDashAdmin.Columns.Contains("status_pembayaran"))
                    dgvDashAdmin.Columns["status_pembayaran"].HeaderText = "Status Pembayaran";

                lbJumlahuser.Text = dashcntrl.GetTotalUser().ToString();
                lbTotalTransaksi.Text = controller.GetTotalTransaksi().ToString();
                lbHewanTersedia.Text = dashcntrl.GetTotalHewan().ToString();
                lbHewanTerjual.Text = hewancntrl.GetTotalTerjual().ToString();
                lbDistribusi.Text = kirimcntrl.GetTotalDistribusi().ToString();
                var total = controller.GetNilaiTotal();
                lbPendapatanTotal.Text = "Rp " + controller.GetNilaiTotal().ToString("N0");

                // ensure datagrid is visible and on top
                dgvDashAdmin.Show();
                dgvDashAdmin.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DashboardAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardAdminForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Apakah anda yakin?",
                "Logout",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                var login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            dataUserForm1.Show();
            dataHewanForm2.Hide();
            riwayatTransaksiForm1.Hide();
            tambah_hewan_ternak1.Hide();
            distribusiHewanForm2.Hide();
            laporanPenjualanForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
            dgvDashAdmin.Hide();

        }


        private void btnHewanTernak_Click(object sender, EventArgs e)
        {
            dataUserForm1.Hide();
            dataHewanForm2.Show();
            tambah_hewan_ternak1.Hide();
            distribusiHewanForm2.Hide();
            riwayatTransaksiForm1.Hide();
            laporanPenjualanForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
            dgvDashAdmin.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            riwayatTransaksiForm1.Show();
            dataHewanForm2.Hide();
            dataUserForm1.Hide();
            distribusiHewanForm2.Hide();
            laporanPenjualanForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
            dgvDashAdmin.Hide();
        }

        private void btnDistribusi_Click(object sender, EventArgs e)
        {
            distribusiHewanForm2.Show();
            dataHewanForm2.Hide();
            dataUserForm1.Hide();
            riwayatTransaksiForm1.Hide();
            laporanPenjualanForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
            dgvDashAdmin.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            laporanPenjualanForm1.Show();
            distribusiHewanForm2.Hide();
            dataHewanForm2.Hide();
            dataUserForm1.Hide();
            riwayatTransaksiForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
            dgvDashAdmin.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            distribusiHewanForm2.Hide();
            dataHewanForm2.Hide();
            dataUserForm1.Hide();
            riwayatTransaksiForm1.Hide();
            laporanPenjualanForm1.Hide();
            lbDistribusi.Show();
            lbJumlahuser.Show();
            lbTotalTransaksi.Show();
            lbHewanTersedia.Show();
            lbHewanTerjual.Show();
            lbPendapatanTotal.Show();
            dgvDashAdmin.Show();
        }

        private void LoadStatistik()
        {

        }

        private void tambah_hewan_ternak1_Load(object sender, EventArgs e)
        {

        }

        private void dataHewanForm2_Load(object sender, EventArgs e)
        {

        }

        private void DataHewanForm2_BtnTambahClicked(object sender, EventArgs e)
        {
            dataHewanForm2.Hide();
            tambah_hewan_ternak1.Show();
        }

        private void Tambah_hewan_ternak1_BtnBatalClicked(object sender, EventArgs e)
        {
            // Hide tambah form and show data list again
            tambah_hewan_ternak1.Hide();
            dataHewanForm2.Show();
        }

        private void Tambah_hewan_ternak1_BtnTambahClicked(object sender, EventArgs e)
        {
            dataHewanForm2.Show();
            dataHewanForm2.RefreshDataHewan(); 
            tambah_hewan_ternak1.Hide(); 
        }

        private void DataHewanForm2_EditRequested(object sender, int hewanId)
        {
            // show edit form and load data immediately
            dataHewanForm2.Hide();
            // Use OpenFor to set id and prefill from DB
            editKlasifikasiQurbanForm1.BtnKonfirmasiClicked -= editKlasifikasiQurbanForm1_btnKonfirmasiClick;
            editKlasifikasiQurbanForm1.BtnKonfirmasiClicked += editKlasifikasiQurbanForm1_btnKonfirmasiClick;
            editKlasifikasiQurbanForm1.OpenFor(hewanId);
            editKlasifikasiQurbanForm1.BringToFront();
        }

        private void editKlasifikasiQurbanForm1_btnBatalClick(object sender, EventArgs e)
        {
            editKlasifikasiQurbanForm1.Hide();
            dataHewanForm2.Show();
            dataHewanForm2.RefreshDataHewan();
        }

        private void editKlasifikasiQurbanForm1_btnKonfirmasiClick(object sender, EventArgs e)
        {
            editKlasifikasiQurbanForm1.Hide();
            dataHewanForm2.Show();
            dataHewanForm2.RefreshDataHewan();
        }

        private void distribusiHewanForm1_Load(object sender, EventArgs e)
        {

        }



        private void dgvRiwayatTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbHewanTersedia_Click(object sender, EventArgs e)
        {

        }

        private void lbDistribusi_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
