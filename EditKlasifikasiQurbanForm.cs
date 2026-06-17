using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace project_smt2
{
    public partial class EditKlasifikasiQurbanForm : UserControl
    {
        // expose selected hewan id so dashboard can set it before showing
        public event EventHandler btnKonfirmasiClick;
        public event EventHandler btnBatalClick;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int HewanTernakId { get; set; }
        public event EventHandler BtnKonfirmasiClicked;

        private readonly Controllers.HewanController _hewanController = new Controllers.HewanController();

        public EditKlasifikasiQurbanForm()
        {
            InitializeComponent();
            // placeholders
            const string PlaceholderUmur = "Umur";
            const string PlaceholderHarga = "Harga";
            const string PlaceholderBerat = "Berat";
            const string PlaceholderJenisHewan = "Jenis Hewan";
            const string PlaceholderPeternak = "Nama Peternak";
            const string PlaceholderJenisKelamin = "Jenis Kelamin";
            const string PlaceholderStatus = "Status Hewan";

            SetupPlaceholder(tbUmur, PlaceholderUmur);
            SetupPlaceholder(tbHarga, PlaceholderHarga);
            SetupPlaceholder(tbBerat, PlaceholderBerat);

            SetupPlaceholder(cbxJenisHewan, PlaceholderJenisHewan);
            SetupPlaceholder(cbxPeternak, PlaceholderPeternak);
            SetupPlaceholder(cbxJenisKelamin, PlaceholderJenisKelamin);
            SetupPlaceholder(cbxKondisiHewan, PlaceholderStatus);

            tbUmur.Enter += (s, e) => RemovePlaceholder(tbUmur, PlaceholderUmur);
            tbUmur.Leave += (s, e) => SetPlaceholderIfEmpty(tbUmur, PlaceholderUmur);
            tbUmur.TextChanged += (s, e) => { if (tbUmur.Text != PlaceholderUmur) tbUmur.ForeColor = Color.Black; };

            tbHarga.Enter += (s, e) => RemovePlaceholder(tbHarga, PlaceholderHarga);
            tbHarga.Leave += (s, e) => SetPlaceholderIfEmpty(tbHarga, PlaceholderHarga);
            tbHarga.TextChanged += (s, e) => { if (tbHarga.Text != PlaceholderHarga) tbHarga.ForeColor = Color.Black; };

            tbBerat.Enter += (s, e) => RemovePlaceholder(tbBerat, PlaceholderBerat);
            tbBerat.Leave += (s, e) => SetPlaceholderIfEmpty(tbBerat, PlaceholderBerat);
            tbBerat.TextChanged += (s, e) => { if (tbBerat.Text != PlaceholderBerat) tbBerat.ForeColor = Color.Black; };

            cbxJenisHewan.SelectedIndexChanged += (s, e) => { cbxJenisHewan.ForeColor = Color.Black; };
            cbxJenisHewan.Enter += (s, e) => RemovePlaceholder(cbxJenisHewan, PlaceholderJenisHewan);
            cbxJenisHewan.Leave += (s, e) => SetPlaceholderIfEmpty(cbxJenisHewan, PlaceholderJenisHewan);

            cbxPeternak.SelectedIndexChanged += (s, e) => { cbxPeternak.ForeColor = Color.Black; };
            cbxPeternak.Enter += (s, e) => RemovePlaceholder(cbxPeternak, PlaceholderPeternak);
            cbxPeternak.Leave += (s, e) => SetPlaceholderIfEmpty(cbxPeternak, PlaceholderPeternak);

            cbxJenisKelamin.SelectedIndexChanged += (s, e) => { cbxJenisKelamin.ForeColor = Color.Black; };
            cbxJenisKelamin.Enter += (s, e) => RemovePlaceholder(cbxJenisKelamin, PlaceholderJenisKelamin);
            cbxJenisKelamin.Leave += (s, e) => SetPlaceholderIfEmpty(cbxJenisKelamin, PlaceholderJenisKelamin);

            cbxKondisiHewan.SelectedIndexChanged += (s, e) => { cbxKondisiHewan.ForeColor = Color.Black; };
            cbxKondisiHewan.Enter += (s, e) => RemovePlaceholder(cbxKondisiHewan, PlaceholderStatus);
            cbxKondisiHewan.Leave += (s, e) => SetPlaceholderIfEmpty(cbxKondisiHewan, PlaceholderStatus);
            this.VisibleChanged += EditKlasifikasiQurbanForm_VisibleChanged;
        }

        private void EditKlasifikasiQurbanForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) return;
            if (HewanTernakId <= 0) return;
            FillFromDb(HewanTernakId);
        }


        public void OpenFor(int hewanId)
        {
            this.HewanTernakId = hewanId;
            FillFromDb(hewanId);
            this.Show();
        }

        private void FillFromDb(int hewanId)
        {
            try
            {
                var dt = _hewanController.GetHewanById(hewanId);
                if (dt.Rows.Count == 0) return;
                var row = dt.Rows[0];

                // Prefer selecting by numeric id if available
                if (row.Table.Columns.Contains("jenis_hewan_id") && row["jenis_hewan_id"] != DBNull.Value)
                {
                    int jenisId = Convert.ToInt32(row["jenis_hewan_id"]);
                    object matchById = cbxJenisHewan.Items.Cast<object>()
                        .FirstOrDefault(it => ParseLeadingInt(it.ToString()) == jenisId);
                    if (matchById != null)
                    {
                        cbxJenisHewan.SelectedItem = matchById;
                        cbxJenisHewan.ForeColor = Color.Black;
                    }
                }
                else if (row.Table.Columns.Contains("jenis_hewan") && row["jenis_hewan"] != DBNull.Value)
                {
                    var jenisText = row["jenis_hewan"].ToString().Trim();
                    var match = cbxJenisHewan.Items.Cast<object>()
                                 .FirstOrDefault(it => it.ToString().Trim().IndexOf(jenisText, StringComparison.OrdinalIgnoreCase) >= 0);
                    if (match != null)
                    {
                        cbxJenisHewan.SelectedItem = match;
                        cbxJenisHewan.ForeColor = Color.Black;
                    }
                    else
                    {
                        cbxJenisHewan.Text = jenisText;
                        cbxJenisHewan.ForeColor = Color.Black;
                    }
                }

                if (row.Table.Columns.Contains("peternak_id") && row["peternak_id"] != DBNull.Value)
                {
                    int peternakId = Convert.ToInt32(row["peternak_id"]);
                    object matchById = cbxPeternak.Items.Cast<object>()
                        .FirstOrDefault(it => ParseLeadingInt(it.ToString()) == peternakId);
                    if (matchById != null)
                    {
                        cbxPeternak.SelectedItem = matchById;
                        cbxPeternak.ForeColor = Color.Black;
                    }
                }
                else if (row.Table.Columns.Contains("nama_peternak") && row["nama_peternak"] != DBNull.Value)
                {
                    var peternakText = row["nama_peternak"].ToString().Trim();
                    var match = cbxPeternak.Items.Cast<object>()
                                 .FirstOrDefault(it => it.ToString().Trim().IndexOf(peternakText, StringComparison.OrdinalIgnoreCase) >= 0);
                    if (match != null)
                    {
                        cbxPeternak.SelectedItem = match;
                        cbxPeternak.ForeColor = Color.Black;
                    }
                    else
                    {
                        cbxPeternak.Text = peternakText;
                        cbxPeternak.ForeColor = Color.Black;
                    }
                }

                if (row.Table.Columns.Contains("jenis_kelamin") && row["jenis_kelamin"] != DBNull.Value)
                {
                    var jk = row["jenis_kelamin"].ToString().Trim();
                    var jkMatch = cbxJenisKelamin.Items.Cast<object>().FirstOrDefault(it => string.Equals(it.ToString().Trim(), jk, StringComparison.OrdinalIgnoreCase));
                    if (jkMatch != null)
                    {
                        cbxJenisKelamin.SelectedItem = jkMatch;
                        cbxJenisKelamin.ForeColor = Color.Black;
                    }
                    else
                    {
                        cbxJenisKelamin.Text = jk;
                        cbxJenisKelamin.ForeColor = Color.Black;
                    }
                }

                if (row.Table.Columns.Contains("umur") && row["umur"] != DBNull.Value)
                {
                    tbUmur.Text = row["umur"].ToString();
                    tbUmur.ForeColor = Color.Black;
                }
                if (row.Table.Columns.Contains("berat") && row["berat"] != DBNull.Value)
                {
                    tbBerat.Text = row["berat"].ToString();
                    tbBerat.ForeColor = Color.Black;
                }
                if (row.Table.Columns.Contains("harga") && row["harga"] != DBNull.Value)
                {
                    tbHarga.Text = row["harga"].ToString();
                    tbHarga.ForeColor = Color.Black;
                }

                if (row.Table.Columns.Contains("kondisi_fisik") && row["kondisi_fisik"] != DBNull.Value)
                {
                    var k = row["kondisi_fisik"].ToString().Trim();
                    var statusMatch = cbxKondisiHewan.Items.Cast<object>().FirstOrDefault(it => string.Equals(it.ToString().Trim(), k, StringComparison.OrdinalIgnoreCase));
                    if (statusMatch != null)
                    {
                        cbxKondisiHewan.SelectedItem = statusMatch;
                        cbxKondisiHewan.ForeColor = Color.Black;
                    }
                    else
                    {
                        cbxKondisiHewan.Text = k;
                        cbxKondisiHewan.ForeColor = Color.Black;
                    }
                }

                if (row.Table.Columns.Contains("tanggal_pemeriksaan") && row["tanggal_pemeriksaan"] != DBNull.Value)
                {
                    if (DateTime.TryParse(row["tanggal_pemeriksaan"].ToString(), out DateTime dtp))
                        dtpTglCek.Value = dtp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data hewan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditKlasifikasiQurbanForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (HewanTernakId <= 0)
                {
                    MessageBox.Show($"Validasi Gagal: ID Hewan tidak valid (ID: {HewanTernakId}).", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int jenisHewanId = 0;
                int peternakId = 0;

                if (cbxJenisHewan.SelectedItem != null)
                    jenisHewanId = ParseLeadingInt(cbxJenisHewan.SelectedItem.ToString());
                if (jenisHewanId == 0)
                    jenisHewanId = ParseLeadingInt(cbxJenisHewan.Text);

                if (cbxPeternak.SelectedItem != null)
                    peternakId = ParseLeadingInt(cbxPeternak.SelectedItem.ToString());
                if (peternakId == 0)
                    peternakId = ParseLeadingInt(cbxPeternak.Text);

                if (jenisHewanId <= 0 || peternakId <= 0)
                {
                    MessageBox.Show("Pilih jenis hewan dan nama peternak yang valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string jenisKelamin = cbxJenisKelamin.SelectedItem?.ToString() ?? cbxJenisKelamin.Text ?? string.Empty;
                int umur = int.TryParse(tbUmur.Text, out int u) ? u : 0;
                int berat = int.TryParse(tbBerat.Text, out int b) ? b : 0;
                int harga = int.TryParse(tbHarga.Text, out int h) ? h : 0;
                string kondisiFisik = cbxKondisiHewan.SelectedItem?.ToString() ?? cbxKondisiHewan.Text ?? string.Empty;
                DateTime tanggalPemeriksaan = dtpTglCek.Value;
                kondisiFisik = kondisiFisik.Trim();
                if (string.IsNullOrWhiteSpace(kondisiFisik) || kondisiFisik == "Kondisi Hewan" || kondisiFisik == "")
                {
                    MessageBox.Show($"Validasi Gagal: Kondisi fisik hewan yang dibaca sistem adalah '{kondisiFisik}'. Silakan pilih Sehat/Sakit/Cacat!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _hewanController.UpdateHewan(HewanTernakId, peternakId, jenisHewanId, jenisKelamin, umur, berat, harga, kondisiFisik, tanggalPemeriksaan);

                MessageBox.Show("Data berhasil diperbarui ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnKonfirmasiClick?.Invoke(this, EventArgs.Empty);
                BtnKonfirmasiClicked?.Invoke(this, EventArgs.Empty);
            }
            catch (PostgresException pex)
            {
                MessageBox.Show($"Database error: {pex.SqlState}\n{pex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memperbarui: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnBatalClick?.Invoke(this, EventArgs.Empty);
        }

        private int ParseLeadingInt(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;
            var parts = text.Trim().Split(' ');
            if (int.TryParse(parts[0], out int id)) return id;
            // try to find digits at start
            var digits = new string(text.TakeWhile(char.IsDigit).ToArray());
            if (int.TryParse(digits, out id)) return id;
            return 0;
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

        private void SetupPlaceholder(ComboBox cb, string placeholder)
        {
            if (string.IsNullOrEmpty(cb.Text) || cb.Text == placeholder)
            {
                cb.Text = placeholder;
                cb.ForeColor = Color.Gray;
            }
            else
            {
                cb.ForeColor = Color.Black;
            }
        }

        private void RemovePlaceholder(ComboBox cb, string placeholder)
        {
            if (cb.Text == placeholder)
            {
                cb.Text = string.Empty;
                cb.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderIfEmpty(ComboBox cb, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(cb.Text))
            {
                cb.Text = placeholder;
                cb.ForeColor = Color.Gray;
            }
            else
            {
                cb.ForeColor = Color.Black;
            }
        }
    }
}
