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
            //distribusiHewanForm1.Hide();
        }

        private void DashboardAdminForm_Load(object sender, EventArgs e)
        {
            //kvmdd
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
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();

        }


        private void btnHewanTernak_Click(object sender, EventArgs e)
        {
            dataUserForm1.Hide();
            dataHewanForm2.Show();
            tambah_hewan_ternak1.Hide();
            //distribusiHewanForm1.Hide();
            riwayatTransaksiForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            riwayatTransaksiForm1.Show();
            dataHewanForm2.Hide();
            dataUserForm1.Hide();
            //distribusiHewanForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
        }

        private void btnDistribusi_Click(object sender, EventArgs e)
        {
            //distribusiHewanForm1.Show();
            dataHewanForm2.Hide();
            dataUserForm1.Hide();
            riwayatTransaksiForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            //distribusiHewanForm1.Hide();
            dataHewanForm2.Hide();
            dataUserForm1.Hide();
            riwayatTransaksiForm1.Hide();
            lbDistribusi.Hide();
            lbJumlahuser.Hide();
            lbTotalTransaksi.Hide();
            lbHewanTersedia.Hide();
            lbHewanTerjual.Hide();
            lbPendapatanTotal.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //distribusiHewanForm1.Hide();
            dataHewanForm2.Hide();
            dataUserForm1.Hide();
            riwayatTransaksiForm1.Hide();
            lbDistribusi.Show();
            lbJumlahuser.Show();
            lbTotalTransaksi.Show();
            lbHewanTersedia.Show();
            lbHewanTerjual.Show();
            lbPendapatanTotal.Show();
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

        private void distribusiHewanForm1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void dgvRiwayatTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
