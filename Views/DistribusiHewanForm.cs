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
    public partial class DistribusiHewanForm : UserControl
    {
        private PengirimanController controller = new PengirimanController();
        private int selectedPengirimanId = 0;

        public DistribusiHewanForm()
        {
            InitializeComponent();
            LoadDistribusiHewan();
            LoadStatistik();
            pnlEditStatus.Hide();
        }

        private void LoadDistribusiHewan()
        {
            try
            {
                dgvDistribusiHewan.AllowUserToAddRows = false;

                if (dgvDistribusiHewan.Columns.Contains("Edit"))
                {
                    dgvDistribusiHewan.Columns.Remove("Edit");
                }

                dgvDistribusiHewan.DataSource = controller.GetDistribusiHewan();

                dgvDistribusiHewan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDistribusiHewan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDistribusiHewan.ReadOnly = false;

                AddActionColumn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data!\n" + ex.Message);
            }
        }

        private void AddActionColumn()
        {
            DataGridViewLinkColumn linkCol = new DataGridViewLinkColumn();
            linkCol.Name = "Edit";
            linkCol.HeaderText = "Aksi";
            linkCol.Text = "Edit Status Pengiriman";
            linkCol.UseColumnTextForLinkValue = true;
            linkCol.LinkBehavior = LinkBehavior.SystemDefault;
            linkCol.LinkColor = Color.Blue;

            foreach (DataGridViewColumn col in dgvDistribusiHewan.Columns)
            {
                col.ReadOnly = true;
            }

            dgvDistribusiHewan.Columns.Add(linkCol);
        }

        private void LoadStatistik()
        {
            lbTerkirim.Text = controller.GetTotalTerkirim().ToString();
            lbProses.Text = controller.GetTotalProses().ToString();
            lbDistribusi.Text = controller.GetTotalDistribusi().ToString();
        }
        private void DistribusiHewanForm_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblDistribusi_Click(object sender, EventArgs e) { }

        private void DistribusiHewanForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvDistribusiHewan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDistribusiHewan.Columns[e.ColumnIndex].Name == "Edit")
            {
                selectedPengirimanId = Convert.ToInt32(dgvDistribusiHewan.Rows[e.RowIndex].Cells["data_pengiriman_id"].Value);
                string statusSaatIni = dgvDistribusiHewan.Rows[e.RowIndex].Cells["status_pengiriman"].Value.ToString();

                var cellValue = dgvDistribusiHewan.Rows[e.RowIndex].Cells["tanggal_kirim"].Value;
                if (cellValue is DateOnly dateOnlyValue)
                {
                    dtpTanggalPengiriman.Value = dateOnlyValue.ToDateTime(TimeOnly.MinValue);
                }
                else
                {
                    dtpTanggalPengiriman.Value = Convert.ToDateTime(cellValue);
                }

                cbxStatus.SelectedItem = statusSaatIni;

                pnlEditStatus.Show();
                pnlEditStatus.BringToFront();
            }
        }

        private void btnKonfirmasi_Click_1(object sender, EventArgs e)
        {
            if (cbxStatus.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih status pengiriman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string statusBaru = cbxStatus.SelectedItem.ToString();
                DateTime tanggalBaru = dtpTanggalPengiriman.Value;

                controller.UpdateStatusPengiriman(selectedPengirimanId, statusBaru, tanggalBaru);

                MessageBox.Show("Data distribusi hewan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlEditStatus.Hide();
                selectedPengirimanId = 0;

                LoadDistribusiHewan();
                LoadStatistik();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data pengiriman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {

            pnlEditStatus.Hide();
            selectedPengirimanId = 0;
        }
    }
}