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
    public partial class DataHewanForm : UserControl
    {
        // Event raised when the Tambah button is clicked so parent forms can respond
        public event EventHandler BtnTambahClicked;
        // Event raised when edit link in grid is clicked. Passes the hewan_ternak_id as int in EventArgs (as sender)
        public event EventHandler<int> EditRequested;

        public DataHewanForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.Font = new Font("Arial", 9F); // pick one consistent font/size
            dgvDataHewan.CellContentClick += dataGridViewDataHewan_CellContentClick;
            dgvDataHewan.CellDoubleClick += dataGridViewDataHewan_CellDoubleClick;
        }

        public void RefreshDataHewan()
        {
            try
            {
                HewanController hewanController = new HewanController();

                // Panggil view atau query select list hewan milikmu
                // Misal dimasukkan ke DataTable atau langsung ke DataSource
                dgvDataHewan.DataSource = hewanController.GetHewan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat ulang data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            HewanController controller = new HewanController();
            DataTable dt = controller.GetHewan();
            PanellHelper.MakeButtonRounded(btnTambah, 25);
            dgvDataHewan.DataSource = dt;
            dgvDataHewan.AutoResizeColumns();
            dgvDataHewan.AutoResizeRows();
            dgvDataHewan.Columns["hewan_ternak_id"].HeaderText = "ID Hewan";
            dgvDataHewan.Columns["nama_jenis"].HeaderText = "Jenis Hewan";
            dgvDataHewan.Columns["jenis_kelamin"].HeaderText = "Jenis Kelamin";
            dgvDataHewan.Columns["umur"].HeaderText = "Umur (th)";
            dgvDataHewan.Columns["berat"].HeaderText = "Berat (kg)";
            dgvDataHewan.Columns["harga"].HeaderText = "Harga (Rp)";
            dgvDataHewan.Columns["kondisi_fisik"].HeaderText = "Kondisi Fisik";
            dgvDataHewan.Columns["nama_peternak"].HeaderText = "Peternak";
            dgvDataHewan.Columns["status_hewan"].HeaderText = "Status Hewan";
            lblhewantersedia.Text = controller.GetTotalTersedia().ToString();
            lbltotalsapi.Text = controller.GetTotalSapi().ToString();
            lbltotalkambing.Text = controller.GetTotalKambing().ToString();
            lblhewanterjual.Text = controller.GetTotalTerjual().ToString();
        }

        private void DataHewanForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lbltotalsapi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblhewanterjual_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void dataGridViewDataHewan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dgvDataHewan.Columns[e.ColumnIndex];
            if (col != null && col.Name == "EditHewan")
            {
                var cellValue = dgvDataHewan.Rows[e.RowIndex].Cells["hewan_ternak_id"].Value;
                if (cellValue != null && cellValue != DBNull.Value && int.TryParse(cellValue.ToString(), out int idHewan))
                {
                    // raise event so dashboard handles opening the edit form
                    EditRequested?.Invoke(this, idHewan);
                }
            }
        }

        public void dataGridViewDataHewan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex < 0) return;
            var cell = dgvDataHewan.Rows[e.RowIndex].Cells["hewan_ternak_id"];
            if (cell != null && cell.Value != null && int.TryParse(cell.Value.ToString(), out int idHewan))
            {
                EditRequested?.Invoke(this, idHewan);
            }
        }

        public void btnTambah_Click(object sender, EventArgs e)
        {
            BtnTambahClicked?.Invoke(this, e);
            LoadData();
        }

        private void dgvDataHewan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
