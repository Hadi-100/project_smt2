using project_smt2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2
{
    public partial class Tambah_hewan_ternak : UserControl
    {
        private readonly string PlaceholderUmur = "Umur";
        private readonly string PlaceholderHarga = "Harga";
        private readonly string PlaceholderBerat = "Berat (KG)";
        public event EventHandler BtnBatalClicked;

        public Tambah_hewan_ternak()
        {
            InitializeComponent();
            cbxJenisHewan.Size = new Size(521, 60);
            PanellHelper.MakeButtonRounded(btnTambah, 15);
            PanellHelper.MakeButtonRounded(btnBatal, 15);

            SetupPlaceholder(tbUmur, PlaceholderUmur);
            SetupPlaceholder(tbHarga, PlaceholderHarga);
            SetupPlaceholder(tbBerat, PlaceholderBerat);


            tbUmur.Enter += (s, e) => RemovePlaceholder(tbUmur, PlaceholderUmur);
            tbUmur.Leave += (s, e) => SetPlaceholderIfEmpty(tbUmur, PlaceholderUmur);
            tbUmur.TextChanged += (s, e) => { if (tbUmur.Text != PlaceholderUmur) tbUmur.ForeColor = Color.Black; };

            tbHarga.Enter += (s, e) => RemovePlaceholder(tbHarga, PlaceholderHarga);
            tbHarga.Leave += (s, e) => SetPlaceholderIfEmpty(tbHarga, PlaceholderHarga);
            tbHarga.TextChanged += (s, e) => { if (tbHarga.Text != PlaceholderHarga) tbHarga.ForeColor = Color.Black; };

            tbBerat.Enter += (s, e) => RemovePlaceholder(tbBerat, PlaceholderBerat);
            tbBerat.Leave += (s, e) => SetPlaceholderIfEmpty(tbBerat, PlaceholderBerat);
            tbBerat.TextChanged += (s, e) => { if (tbBerat.Text != PlaceholderBerat) tbBerat.ForeColor = Color.Black; };

            // comboboxes: when user selects an item, make text color black
            cbxJenisHewan.SelectedIndexChanged += (s, e) => { cbxJenisHewan.ForeColor = Color.Black; };
            cbxJenisKelamin.SelectedIndexChanged += (s, e) => { cbxJenisKelamin.ForeColor = Color.Black; };
            cbxKondisiFisik.SelectedIndexChanged += (s, e) => { cbxKondisiFisik.ForeColor = Color.Black; };
            cbxNamaPeternak.SelectedIndexChanged += (s, e) => { cbxNamaPeternak.ForeColor = Color.Black; };

            // Setup date placeholder-like behavior: show text and gray color until user picks a date
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.CustomFormat = "Tanggal Lahir";
            dtpTanggalLahir.ForeColor = Color.Gray;
            dtpTanggalLahir.ValueChanged += (s, e) =>
            {
                // when a date is chosen, show a normal date format and black color
                dtpTanggalLahir.Format = DateTimePickerFormat.Short;
                dtpTanggalLahir.ForeColor = Color.Black;
            };
        }

        private void cbxJenisHewan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetupPlaceholder(TextBox tb, string placeholder)
        {
            if (string.IsNullOrEmpty(tb.Text) || tb.Text == placeholder)
            {
                tb.Text = placeholder;
                tb.ForeColor = Color.Gray;
            }
            else
            {
                tb.ForeColor = Color.Black;
            }
        }

        private void RemovePlaceholder(TextBox tb, string placeholder)
        {
            if (tb.Text == placeholder)
            {
                tb.Text = string.Empty;
                tb.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderIfEmpty(TextBox tb, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = placeholder;
                tb.ForeColor = Color.Gray;
            }
            else
            {
                tb.ForeColor = Color.Black;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            HewanController hewanController = new HewanController();

            string jenis_kelamin =
                cbxJenisKelamin.SelectedItem?.ToString() ?? "";

            if (cbxJenisHewan.SelectedValue == null ||
                cbxNamaPeternak.SelectedValue == null ||
                string.IsNullOrWhiteSpace(jenis_kelamin))
            {
                MessageBox.Show(
                    "Lengkapi data terlebih dahulu!",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int jenisHewanId =
                Convert.ToInt32(cbxJenisHewan.SelectedValue);

            int peternakId =
                Convert.ToInt32(cbxNamaPeternak.SelectedValue);

            int umur =
                int.TryParse(tbUmur.Text, out int u) ? u : 0;

            int berat =
                int.TryParse(tbBerat.Text, out int b) ? b : 0;

            int harga =
                int.TryParse(tbHarga.Text, out int h) ? h : 0;

            try
            {
                hewanController.TambahkanHewanTernak(
                    jenisHewanId,
                    jenis_kelamin,
                    umur,
                    berat,
                    harga,
                    peternakId
                );

                MessageBox.Show(
                    "Hewan berhasil ditambahkan.",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            BtnBatalClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

