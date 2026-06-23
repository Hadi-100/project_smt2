using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class DashboardUserForm : Form
    {
        private string username;
        private Panel pnlContent;
        private string asalHalaman;

        public DashboardUserForm(string namaLengkap)
        {
            InitializeComponent();

            this.username = namaLengkap;
            lblNamaUser.Text = namaLengkap;

            listHewanTernak1.BtnKembaliClicked += list_hewan_ternak1_Load_btnKembaliClicked;
            listHewanQurban1.BtnKembaliClicked += list_hewan_qurban1_Load_btnKembaliClicked;

            listHewanTernak1.BtnBeliClicked += List_BtnBeliClicked;
            listHewanQurban1.BtnBeliClicked += ListQurban_BtnBeliClicked;

            masukkanAlamat2.LanjutKePembayaran += MasukkanAlamat2_LanjutKePembayaran;
            masukkanAlamat2.BtnKembaliClicked += MasukkanAlamat2_BtnKembaliClicked;

            pembayaranForm1.BtnBatal_Click += Pembayaran_BtnBatal_Click;

            new AutoScaleHelper(this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void MasukkanAlamat2_LanjutKePembayaran(
            int hewanId,
            int alamatId,
            decimal harga)
        {
            pembayaranForm1.SetData(hewanId,alamatId,harga);

            pembayaranForm1.Show();
            pembayaranForm1.BringToFront();

            masukkanAlamat2.Hide();
        }

        private void Pembayaran_BtnBatal_Click(object sende, EventArgs e)
        {
            pembayaranForm1.Hide();

            masukkanAlamat2.Show();
            masukkanAlamat2.BringToFront();
        }

        private void List_BtnBeliClicked(int hewanId, decimal harga)
        {
            asalHalaman = "Ternak";

            masukkanAlamat2.SetData(hewanId, harga);
            masukkanAlamat2.Show();

            listHewanTernak1.Hide();
        }
        private void ListQurban_BtnBeliClicked(int hewanId, decimal harga)
        {
            asalHalaman = "Qurban";

            masukkanAlamat2.SetData(hewanId, harga);
            masukkanAlamat2.Show();

            listHewanQurban1.Hide();
        }

        private void MasukkanAlamat2_BtnKembaliClicked(object sender,EventArgs e)
        {
            masukkanAlamat2.Hide();

            if (asalHalaman == "Qurban")
            {
                listHewanQurban1.Show();
                listHewanQurban1.BringToFront();
            }
            else
            {
                listHewanTernak1.Show();
                listHewanTernak1.BringToFront();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            riwayatTransaksiuser1.Show();
            pesananSaya1.Hide();
            listHewanTernak1.Hide();
            listHewanQurban1.Hide();
            listHewanTernak1.Hide();
        }

        private void btnPesananSaya_Click(object sender, EventArgs e)
        {
            pesananSaya1.Show();
            riwayatTransaksiuser1.Hide();
            listHewanTernak1.Hide();
            listHewanQurban1.Hide();
            masukkanAlamat2.Hide();
        }
        private void btnHewanTernak_Click(object sender, EventArgs e)
        {
            listHewanTernak1.Show();
            listHewanTernak1.BringToFront();

            pesananSaya1.Hide();
            riwayatTransaksiuser1.Hide();
            masukkanAlamat2.Hide();
            listHewanQurban1.Hide();

        }

        private void btnHewanQurban_Click(object sender, EventArgs e)
        {
            listHewanQurban1.Show();
            listHewanTernak1.Hide();
            riwayatTransaksiuser1.Hide();
            pesananSaya1.Hide();
            masukkanAlamat2.Hide();
        }

        private void btnHalamanUtama_Click(object sender, EventArgs e)
        {
            riwayatTransaksiuser1.Hide();
            riwayatTransaksiUSER.Hide();
            pesananSaya1.Hide();
            listHewanTernak1.Hide();
            masukkanAlamat2.Hide();
            listHewanQurban1.Hide();
        }

        private void riwayat_transaksi_user1_Load(object sender, EventArgs e)
        {
        }

        private void pesananSaya1_Load(object sender, EventArgs e)
        {

        }

        private void lblNamaUser_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaUser_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHewanTernakUser_Click(object sender, EventArgs e)
        {
            ListHewanTernak list = new ListHewanTernak();

            list.BtnBeliClicked += List_BtnBeliClicked;

            Controls.Clear();
            Controls.Add(list);
        }

        private void list_hewan_ternak1_Load_btnKembaliClicked(object sender, EventArgs e)
        {
            listHewanTernak1.Hide();
            riwayatTransaksiUSER.Hide();
            pesananSaya1.Hide();
        }
        private void list_hewan_qurban1_Load_btnKembaliClicked(object sender, EventArgs e)
        {
            listHewanQurban1.Hide();
            riwayatTransaksiUSER.Hide();
            pesananSaya1.Hide();
            listHewanTernak1.Hide();
        }

        //private void masukkanAlamat1_Load(object sender, EventArgs e)
        //{

        //}

        private void riwayatTransaksiuser1_Load(object sender, EventArgs e)
        {

        }

        private void masukkanAlamat2_Load(object sender, EventArgs e)
        {

        }

        private void masukkanAlamat2_Load_1(object sender, EventArgs e)
        {

        }

        private void pembayaranForm1_Load(object sender, EventArgs e)
        {

        }
    }
}

