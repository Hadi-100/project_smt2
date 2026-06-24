using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using project_smt2.Controllers;
using Npgsql;
using project_smt2.Helpers;
using System.Security.Cryptography.X509Certificates;

namespace project_smt2.Views
{
    public partial class ListHewanTernak : UserControl
    {
        public event EventHandler BtnKembaliClicked;
        public ListHewanTernak()
        {
            InitializeComponent();

            this.Load += ListHewanTernak_Load;
        }

        public event Action<int, decimal> BtnBeliClicked;

        private void ListHewanTernak_Load(object sender, EventArgs e)
        {
            cbJenisHewan.Items.Add("Semua");
            cbJenisHewan.Items.Add("Sapi Brahman");
            cbJenisHewan.Items.Add("Sapi Limousin");
            cbJenisHewan.Items.Add("Sapi Ongole");
            cbJenisHewan.Items.Add("Kambing Boer");
            cbJenisHewan.Items.Add("Kambing Kacang");

            cbJenisKelamin.Items.Add("Semua");
            cbJenisKelamin.Items.Add("Jantan");
            cbJenisKelamin.Items.Add("Betina");

            cbUmur.Items.Add("Semua");
            cbUmur.Items.Add("1 - 2 Tahun");
            cbUmur.Items.Add("3 - 4 Tahun");
            cbUmur.Items.Add("> 5 Tahun");

            cbBerat.Items.Add("Semua");
            cbBerat.Items.Add("0 - 50 Kg");
            cbBerat.Items.Add("51 - 200 Kg");
            cbBerat.Items.Add("> 200 Kg");

            cbJenisHewan.SelectedIndex = 0;
            cbJenisKelamin.SelectedIndex = 0;
            cbUmur.SelectedIndex = 0;
            cbBerat.SelectedIndex = 0;

            btnKembali.BringToFront();

            LoadDataHewan();
        }

        private void LoadDataHewan()
        {
            HewanController controller = new HewanController();

            DataTable dt = controller.GetHewan();

            dgvListHewanTernak.DataSource = dt;

            foreach (DataRow row in dt.Rows)
            {
                row["harga"] = Convert.ToDecimal(row["harga"]) + 1000000;
            }

            dgvListHewanTernak.Columns["hewan_ternak_id"].HeaderText = "ID Hewan";
            dgvListHewanTernak.Columns["jenis_kelamin"].HeaderText = "Jenis Kelamin";
            dgvListHewanTernak.Columns["umur"].HeaderText = "Umur (th)";
            dgvListHewanTernak.Columns["berat"].HeaderText = "Berat (kg)";
            dgvListHewanTernak.Columns["harga"].HeaderText = "Harga (Rp)";
            dgvListHewanTernak.Columns["nama_peternak"].HeaderText = "Peternak";
            dgvListHewanTernak.Columns["status_hewan"].HeaderText = "Status Hewan";
            dgvListHewanTernak.AutoResizeColumns();
            dgvListHewanTernak.AutoResizeRows();

        }

        private void FilterData()
        {

            if (dgvListHewanTernak.DataSource == null)
                return;

            DataTable dt =
                (DataTable)dgvListHewanTernak.DataSource;

            string filter = "";

            if (cbJenisHewan.Text != "Semua")
            {
                filter += $"nama_jenis LIKE '%{cbJenisHewan.Text}%'";
            }

            if (cbJenisKelamin.Text != "Semua")
            {
                if (filter != "")
                    filter += " AND ";

                filter += $"jenis_kelamin = '{cbJenisKelamin.Text}'";
            }

            if (cbUmur.Text == "1 - 2 Tahun")
            {
                if (filter != "") filter += " AND ";
                filter += "umur >= 1 AND umur <= 2";
            }
            else if (cbUmur.Text == "3 - 4 Tahun")
            {
                if (filter != "") filter += " AND ";
                filter += "umur >= 3 AND umur <= 4";
            }
            else if (cbUmur.Text == "> 5 Tahun")
            {
                if (filter != "") filter += " AND ";
                filter += "umur >= 5";
            }

            if (cbBerat.Text == "0 - 50 Kg")
            {
                if (filter != "") filter += " AND ";
                filter += "berat >= 0 AND berat <= 50";
            }
            else if (cbBerat.Text == "51 - 200 Kg")
            {
                if (filter != "") filter += " AND ";
                filter += "berat >= 51 AND berat <= 200";
            }
            else if (cbBerat.Text == "> 200 Kg")
            {
                if (filter != "") filter += " AND ";
                filter += "berat > 200";
            }


            dt.DefaultView.RowFilter = filter;
        }

        private void dgvListHewanTernak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbJenisHewan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbJenisKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbStatusQurban_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbUmur_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbBerat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            BtnKembaliClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (dgvListHewanTernak.CurrentRow == null)
            {
                MessageBox.Show("Pilih hewan terlebih dahulu");
                return;
            }

            string statusHewan =
                dgvListHewanTernak.CurrentRow
                .Cells["status_hewan"]
                .Value.ToString();

            MessageBox.Show(statusHewan);

            if (statusHewan == "Terjual")
            {
                MessageBox.Show(
                    "Hewan ini sudah terjual!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int hewanId = Convert.ToInt32(
                dgvListHewanTernak.CurrentRow.Cells["hewan_ternak_id"].Value);

            decimal hargaDasar = Convert.ToDecimal(
                dgvListHewanTernak.CurrentRow.Cells["harga"].Value);

            decimal hargaJual = hargaDasar + 1000000;

            BtnBeliClicked?.Invoke(hewanId, hargaJual);
        }
    }
}
