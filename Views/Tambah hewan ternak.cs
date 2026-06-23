using project_smt2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_smt2
{
    //public enum JenisHewan
    //{
    //    Sapi = 1,
    //    Kambing = 2
    //}
    public partial class Tambah_hewan_ternak : UserControl
    {
        private readonly string PlaceholderUmur = "Umur";
        private readonly string PlaceholderHarga = "Harga";
        private readonly string PlaceholderBerat = "Berat (KG)";
        public event EventHandler BtnBatalClicked;
        public event EventHandler BtnTambahClicked;

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
            //cbxJenisHewan.SelectedIndexChanged += (s, e) => { cbxJenis.ForeColor = Color.Black; };
            cbxNamaPeternak.SelectedIndexChanged += (s, e) => { cbxNamaPeternak.ForeColor = Color.Black; };

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

            BtnTambahClicked?.Invoke(this, e);
            HewanController controller = new HewanController();
            if (cbxJenisHewan.SelectedItem == null)
            {
                MessageBox.Show("Pilih hewan terlebih dahulu");
                return;
            }
            if (cbxNamaPeternak.SelectedItem == null)
            {
                MessageBox.Show("Pilih peternak terlebih dahulu");
                return;
            }
            string teksTerpilih1 = cbxJenisHewan.SelectedItem.ToString();
            string[] potongan1 = teksTerpilih1.Split(' ');
            int jenis_hewan_id = int.Parse(potongan1[0]);
            string teksTerpilih2 = cbxNamaPeternak.SelectedItem.ToString();
            string[] potongan2 = teksTerpilih2.Split(' ');
            int peternak_id = int.Parse(potongan2[0]);

            string jenis_kelamin = cbxJenisKelamin.SelectedItem?.ToString() ?? string.Empty;

            // 2. Validasi awal: Pastikan semua dropdown utama sudah dipilih
            if (jenis_hewan_id == 0 || peternak_id == 0 || string.IsNullOrWhiteSpace(jenis_kelamin))
            {
                MessageBox.Show("Pilih jenis hewan, peternak, dan jenis kelamin terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Parsing nilai TextBox dengan aman menggunakan int.TryParse
            if (!int.TryParse(tbUmur.Text, out int umur) || umur <= 0)
            {
                MessageBox.Show("Masukkan umur hewan dengan angka yang valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbBerat.Text, out int berat) || berat <= 0)
            {
                MessageBox.Show("Masukkan berat hewan dengan angka yang valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbHarga.Text, out int harga) || harga <= 0)
            {
                MessageBox.Show("Masukkan harga hewan dengan angka yang valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Proses Eksekusi ke Database via Controller
            try
            {
                HewanController hewanController = new HewanController();

                hewanController.TambahkanHewan(
                    jenis_hewan_id,
                    peternak_id,
                    jenis_kelamin,
                    umur,
                    berat,
                    harga
                );

                // Jika berhasil, munculkan pesan sukses
                MessageBox.Show("Hewan berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Opsional: Bersihkan form atau refresh DataGridView di sini setelah sukses
                // ClearForm();
            }
            catch (Exception ex)
            {
                // Menangkap error dari database (termasuk jika ada error ENUM atau constraint lain)
                MessageBox.Show($"Gagal menambahkan hewan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            BtnBatalClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

