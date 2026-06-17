using project_smt2.Controllers;
using project_smt2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class RiwayatTransaksiUSER : UserControl
    {
        public RiwayatTransaksiUSER()
        {
            InitializeComponent();
        }
        private void LoadRiwayat()
        {
            RiwayatTransaksiUserController controller = new RiwayatTransaksiUserController();

            dgvRiwayatTransaksiUser.DataSource = controller.GetRiwayatTransaksiUser(Session.UserId);


            lblTotalTransaksiUser.Text = controller.GetTotalTransaksiUser(Session.UserId).ToString();
            lblSudahLunas.Text = controller.GetTotalSudahLunasUser(Session.UserId).ToString();
            lblBelumLunas.Text = controller.GetTotalBelumBayarUser(Session.UserId).ToString();
        }

        private void Riwayat_transaksi_USER_Load(object sender, EventArgs e)
        {
            LoadRiwayat();
        }

        private void lblTotalTransaksiUser_Click_1(object sender, EventArgs e)
        {
            LoadRiwayat();
        }

        private void lblSudahLunas_Click(object sender, EventArgs e)
        {
            LoadRiwayat();
        }

        private void lblBelumLunas_Click(object sender, EventArgs e)
        {
            LoadRiwayat();
        }
    }

}
