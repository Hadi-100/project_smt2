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
    public partial class PembayaranForm : UserControl
    {
        private int _hewanId;
        private int _alamatId;
        private decimal _harga;

        private TransaksiController transaksiController =
            new TransaksiController();
        public PembayaranForm(int hewanId, int alamatId, decimal harga)
        {
            InitializeComponent();

            _hewanId = hewanId;
            _alamatId = alamatId;
            _harga = harga;

            LoadBank();

            tbNoRekening.Visible = false;
        }

        private void LoadBank()
        {
            cmbBank.Items.Clear();

            cmbBank.Items.Add("BCA");
            cmbBank.Items.Add("BRI");
            cmbBank.Items.Add("BNI");
            cmbBank.Items.Add("Mandiri");
            cmbBank.Items.Add("BSI");
            cmbBank.Items.Add("DANA");
            cmbBank.Items.Add("OVO");
            cmbBank.Items.Add("GoPay");
        }


        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNoRekening.Visible = true;

        }

        private void tbNoRekening_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNominal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tbNoRekening.Clear();
            tbNominal.Clear();
            cmbBank.SelectedIndex = -1;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Pilih bank terlebih dahulu");
                return;
            }

            if (string.IsNullOrWhiteSpace(
                tbNoRekening.Text))
            {
                MessageBox.Show(
                    "Masukkan nomor rekening");
                return;
            }

            if (!decimal.TryParse(
                tbNominal.Text,
                out decimal nominalBayar))
            {
                MessageBox.Show(
                    "Nominal harus berupa angka");
                return;
            }

            if (nominalBayar < _harga)
            {
                MessageBox.Show(
                    $"Pembayaran gagal.\n" +
                    $"Harga hewan : Rp {_harga:N0}\n" +
                    $"Nominal bayar : Rp {nominalBayar:N0}",
                    "Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            decimal kembalian =
                nominalBayar - _harga;

            try
            {
                transaksiController
                    .InsertTransaksiDanDetail(
                        Session.UserId,
                        _alamatId,
                        _hewanId,
                        _harga);

                MessageBox.Show(
                    $"Pembayaran berhasil!\n\n" +
                    $"Bank : {cmbBank.Text}\n" +
                    $"No Rekening : {tbNoRekening.Text}\n" +
                    $"Total Bayar : Rp {nominalBayar:N0}\n" +
                    $"Kembalian : Rp {kembalian:N0}",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error");
            }

        }
    }
}
