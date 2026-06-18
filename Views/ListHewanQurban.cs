using project_smt2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class ListHewanQurban : UserControl
    {
        public event EventHandler BtnKembaliClicked;

        public event Action<int, decimal> BtnBeliClicked;
        public ListHewanQurban()
        {
            InitializeComponent();

            this.Load += ListHewanQurban_Load;
        }

        private void ListHewanQurban_Load(object sender, EventArgs e)
        {
            cbBerat.Items.Add("Semua");
            cbBerat.Items.Add("0 - 50 Kg");
            cbBerat.Items.Add("51 - 200 Kg");
            cbBerat.Items.Add("> 200 Kg");

            cbHarga.Items.Add("Semua");
            cbHarga.Items.Add("< 5 Juta");
            cbHarga.Items.Add("5 - 10 Juta");
            cbHarga.Items.Add("10 - 20 Juta");
            cbHarga.Items.Add("> 20 Juta");

            cbBerat.SelectedIndex = 0;
            cbHarga.SelectedIndex = 0;

            LoadDataHewan();
        }

        private void LoadDataHewan()
        {
            HewanController controller = new HewanController();

            DataTable dt = controller.GetHewan();

            dgvListHewanQurban.DataSource = dt;

            dgvListHewanQurban.Columns["hewan_ternak_id"].HeaderText = "ID Hewan";
            //dgvListHewanQurban.Columns["jenis_hewan"].HeaderText = "Jenis Hewan";
            dgvListHewanQurban.Columns["jenis_kelamin"].HeaderText = "Jenis Kelamin";
            dgvListHewanQurban.Columns["umur"].HeaderText = "Umur (th)";
            dgvListHewanQurban.Columns["berat"].HeaderText = "Berat (kg)";
            dgvListHewanQurban.Columns["harga"].HeaderText = "Harga (Rp)";
            dgvListHewanQurban.Columns["nama_peternak"].HeaderText = "Peternak";
            dgvListHewanQurban.Columns["status_hewan"].HeaderText = "Status Hewan";

            dgvListHewanQurban.AutoResizeColumns();
            dgvListHewanQurban.AutoResizeRows();
        }

        private void FilterData()
        {
            if (dgvListHewanQurban.DataSource == null)
                return;

            DataTable dt =
                (DataTable)dgvListHewanQurban.DataSource;

            string filter = "";

            //Filter Berat
            if (cbBerat.Text == "0 - 50 Kg")
            {
                filter += "berat >= 0 AND berat <= 50";
            }
            else if (cbBerat.Text == "51 - 200 Kg")
            {
                filter += "berat >= 51 AND berat <= 200";
            }
            else if (cbBerat.Text == "> 200 Kg")
            {
                filter += "berat > 200";
            }

            //Filter Harga
            if (cbHarga.Text != "Semua")
            {
                if (filter != "")
                    filter += " AND ";

                if (cbHarga.Text == "< 5 Juta")
                    filter += "harga < 5000000";
                else if (cbHarga.Text == "5 - 10 Juta")
                    filter += "harga >= 5000000 AND harga <= 10000000";
                else if (cbHarga.Text == "10 - 20 Juta")
                    filter += "harga >= 10000000 AND harga <= 20000000";
                else if (cbHarga.Text == "> 20 Juta")
                    filter += "harga > 20000000";
            }

            dt.DefaultView.RowFilter = filter;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            BtnKembaliClicked?.Invoke(this, EventArgs.Empty);
        }

        private void cbBerat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dgvListHewanQurban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBeli_Click(object sender, EventArgs e)
        {
            if (dgvListHewanQurban.CurrentRow == null)
            {
                MessageBox.Show("Pilih hewan qurban terlebih dahulu");
                return;
            }
            string statusHewan =
                dgvListHewanQurban.CurrentRow
                .Cells["Status_hewan"]
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
                dgvListHewanQurban.CurrentRow.Cells["hewan_ternak_id"].Value);

            decimal harga = Convert.ToDecimal(
                dgvListHewanQurban.CurrentRow.Cells["harga"].Value);

            BtnBeliClicked?.Invoke(hewanId, harga);
        }
    }
}
