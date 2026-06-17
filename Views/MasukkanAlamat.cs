using project_smt2.Controllers;
using project_smt2.Helpers;
using project_smt2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class MasukkanAlamat : UserControl
    {
        public event EventHandler BtnKembaliClicked;

        AlamatController controller = new AlamatController();

        private int _hewanId;
        private decimal _harga;

        public event Action<int, int, decimal> LanjutKePembayaran;

        public MasukkanAlamat()
        {
            InitializeComponent();

            var kecamatanList = controller.GetAllKecamatan();

            cbKecamatan.DataSource = kecamatanList;
            cbKecamatan.DisplayMember = "NamaKecamatan";
            cbKecamatan.ValueMember = "KecamatanId";
            cbKecamatan.SelectedIndex = -1;
        }
        public MasukkanAlamat(int hewanId, decimal harga) : this()
        {
            _hewanId = hewanId;
            _harga = harga;
        }


        private void AlamatForm_Load(object sender, EventArgs e)
        {

        }

        private void cbKecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDesa.DataSource = null;
            cbDesa.Enabled = false;

            if (cbKecamatan.SelectedItem == null) return;

            var selected = (Kecamatan)cbKecamatan.SelectedItem;
            int kecamatanId = selected.KecamatanId;

            var desaList = controller.GetDesaByKecamatan(kecamatanId);

            cbDesa.DataSource = desaList;
            cbDesa.DisplayMember = "NamaDesa";
            cbDesa.ValueMember = "DesaId";
            cbDesa.SelectedIndex = -1;
            cbDesa.Enabled = true;
        }

        private void cbDesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbAlamatLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelanjutnya_Click(object sender, EventArgs e)
        {
            if (cbDesa.SelectedItem == null)
            {
                MessageBox.Show(
                    "Pilih desa terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(tbAlamatLengkap.Text))
            {
                MessageBox.Show(
                    "Alamat lengkap wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                Desa desa = (Desa)cbDesa.SelectedItem;

                int alamatId = controller.InsertAlamat(tbAlamatLengkap.Text.Trim(), desa.DesaId);

                LanjutKePembayaran?.Invoke(_hewanId, alamatId, _harga);

                //this.Parent.Controls.Clear();
                //this.Parent.Controls.Add(pembayaran);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            BtnKembaliClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
