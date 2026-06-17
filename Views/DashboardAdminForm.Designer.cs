using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class DashboardAdminForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button btnLogout;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdminForm));
            dataUserForm1 = new DataUserForm();
            tambah_hewan_ternak1 = new Tambah_hewan_ternak();
            riwayatTransaksiForm1 = new RiwayatTransaksiForm();
            btnLogout = new Button();
            btnDashboard = new Button();
            btnUsers = new Button();
            btnHewanTernak = new Button();
            btnRiwayat = new Button();
            btnLaporan = new Button();
            btnDistribusi = new Button();
            lbJumlahuser = new Label();
            lbTotalTransaksi = new Label();
            lbHewanTersedia = new Label();
            lbHewanTerjual = new Label();
            lbDistribusi = new Label();
            lbPendapatanTotal = new Label();
            dataHewanForm2 = new DataHewanForm();
            dgvDashAdmin = new DataGridView();
            transaksi_id = new DataGridViewTextBoxColumn();
            nama_lengkap = new DataGridViewTextBoxColumn();
            tanggal_transaksi = new DataGridViewTextBoxColumn();
            harga_jual = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            status_pembayaran = new DataGridViewTextBoxColumn();
            distribusiHewanForm2 = new DistribusiHewanForm();
            laporanPenjualanForm1 = new LaporanPenjualanForm();
            editKlasifikasiQurbanForm1 = new EditKlasifikasiQurbanForm();
            ((System.ComponentModel.ISupportInitialize)dgvDashAdmin).BeginInit();
            SuspendLayout();
            // 
            // dataUserForm1
            // 
            dataUserForm1.BackgroundImage = (Image)resources.GetObject("dataUserForm1.BackgroundImage");
            dataUserForm1.BackgroundImageLayout = ImageLayout.Stretch;
            dataUserForm1.Location = new Point(280, 0);
            dataUserForm1.Margin = new Padding(2);
            dataUserForm1.Name = "dataUserForm1";
            dataUserForm1.Size = new Size(1538, 987);
            dataUserForm1.TabIndex = 0;
            // 
            // tambah_hewan_ternak1
            // 
            tambah_hewan_ternak1.BackgroundImage = (Image)resources.GetObject("tambah_hewan_ternak1.BackgroundImage");
            tambah_hewan_ternak1.BackgroundImageLayout = ImageLayout.Stretch;
            tambah_hewan_ternak1.Location = new Point(280, 0);
            tambah_hewan_ternak1.Margin = new Padding(2);
            tambah_hewan_ternak1.Name = "tambah_hewan_ternak1";
            tambah_hewan_ternak1.Size = new Size(1538, 987);
            tambah_hewan_ternak1.TabIndex = 2;
            // 
            // riwayatTransaksiForm1
            // 
            riwayatTransaksiForm1.BackgroundImage = (Image)resources.GetObject("riwayatTransaksiForm1.BackgroundImage");
            riwayatTransaksiForm1.BackgroundImageLayout = ImageLayout.Stretch;
            riwayatTransaksiForm1.Location = new Point(280, 0);
            riwayatTransaksiForm1.Margin = new Padding(2);
            riwayatTransaksiForm1.Name = "riwayatTransaksiForm1";
            riwayatTransaksiForm1.Size = new Size(1538, 987);
            riwayatTransaksiForm1.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(22, 851);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 41);
            btnLogout.TabIndex = 0;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button1_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.Location = new Point(22, 241);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(236, 52);
            btnDashboard.TabIndex = 5;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Transparent;
            btnUsers.BackgroundImage = (Image)resources.GetObject("btnUsers.BackgroundImage");
            btnUsers.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsers.FlatStyle = FlatStyle.Popup;
            btnUsers.ForeColor = Color.Transparent;
            btnUsers.Location = new Point(22, 324);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(236, 52);
            btnUsers.TabIndex = 6;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnHewanTernak
            // 
            btnHewanTernak.BackColor = Color.Transparent;
            btnHewanTernak.BackgroundImage = (Image)resources.GetObject("btnHewanTernak.BackgroundImage");
            btnHewanTernak.BackgroundImageLayout = ImageLayout.Stretch;
            btnHewanTernak.FlatStyle = FlatStyle.Popup;
            btnHewanTernak.ForeColor = Color.Transparent;
            btnHewanTernak.Location = new Point(22, 404);
            btnHewanTernak.Name = "btnHewanTernak";
            btnHewanTernak.Size = new Size(236, 52);
            btnHewanTernak.TabIndex = 7;
            btnHewanTernak.UseVisualStyleBackColor = false;
            btnHewanTernak.Click += btnHewanTernak_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.Transparent;
            btnRiwayat.BackgroundImage = (Image)resources.GetObject("btnRiwayat.BackgroundImage");
            btnRiwayat.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiwayat.FlatStyle = FlatStyle.Popup;
            btnRiwayat.ForeColor = Color.Transparent;
            btnRiwayat.Location = new Point(22, 490);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(236, 52);
            btnRiwayat.TabIndex = 8;
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.BackgroundImage = (Image)resources.GetObject("btnLaporan.BackgroundImage");
            btnLaporan.BackgroundImageLayout = ImageLayout.Stretch;
            btnLaporan.FlatStyle = FlatStyle.Popup;
            btnLaporan.ForeColor = Color.Transparent;
            btnLaporan.Location = new Point(22, 655);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(236, 52);
            btnLaporan.TabIndex = 9;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnDistribusi
            // 
            btnDistribusi.BackColor = Color.Transparent;
            btnDistribusi.BackgroundImage = (Image)resources.GetObject("btnDistribusi.BackgroundImage");
            btnDistribusi.BackgroundImageLayout = ImageLayout.Stretch;
            btnDistribusi.FlatStyle = FlatStyle.Popup;
            btnDistribusi.ForeColor = Color.Transparent;
            btnDistribusi.Location = new Point(22, 573);
            btnDistribusi.Name = "btnDistribusi";
            btnDistribusi.Size = new Size(236, 52);
            btnDistribusi.TabIndex = 10;
            btnDistribusi.UseVisualStyleBackColor = false;
            btnDistribusi.Click += btnDistribusi_Click;
            // 
            // lbJumlahuser
            // 
            lbJumlahuser.BackColor = Color.Transparent;
            lbJumlahuser.Font = new Font("Arial", 15F, FontStyle.Bold);
            lbJumlahuser.Location = new Point(442, 306);
            lbJumlahuser.Name = "lbJumlahuser";
            lbJumlahuser.Size = new Size(56, 28);
            lbJumlahuser.TabIndex = 11;
            lbJumlahuser.Text = "0";
            // 
            // lbTotalTransaksi
            // 
            lbTotalTransaksi.BackColor = Color.Transparent;
            lbTotalTransaksi.Font = new Font("Arial", 15F, FontStyle.Bold);
            lbTotalTransaksi.Location = new Point(713, 310);
            lbTotalTransaksi.Name = "lbTotalTransaksi";
            lbTotalTransaksi.Size = new Size(56, 28);
            lbTotalTransaksi.TabIndex = 12;
            lbTotalTransaksi.Text = "0";
            // 
            // lbHewanTersedia
            // 
            lbHewanTersedia.BackColor = Color.Transparent;
            lbHewanTersedia.Font = new Font("Arial", 15F, FontStyle.Bold);
            lbHewanTersedia.Location = new Point(1000, 310);
            lbHewanTersedia.Name = "lbHewanTersedia";
            lbHewanTersedia.Size = new Size(56, 28);
            lbHewanTersedia.TabIndex = 13;
            lbHewanTersedia.Text = "0";
            lbHewanTersedia.Click += lbHewanTersedia_Click;
            // 
            // lbHewanTerjual
            // 
            lbHewanTerjual.BackColor = Color.Transparent;
            lbHewanTerjual.Font = new Font("Arial", 15F, FontStyle.Bold);
            lbHewanTerjual.Location = new Point(1314, 310);
            lbHewanTerjual.Name = "lbHewanTerjual";
            lbHewanTerjual.Size = new Size(56, 28);
            lbHewanTerjual.TabIndex = 14;
            lbHewanTerjual.Text = "0";
            // 
            // lbDistribusi
            // 
            lbDistribusi.BackColor = Color.Transparent;
            lbDistribusi.Font = new Font("Arial", 15F, FontStyle.Bold);
            lbDistribusi.Location = new Point(1617, 310);
            lbDistribusi.Name = "lbDistribusi";
            lbDistribusi.Size = new Size(56, 28);
            lbDistribusi.TabIndex = 15;
            lbDistribusi.Text = "0";
            lbDistribusi.Click += lbDistribusi_Click;
            // 
            // lbPendapatanTotal
            // 
            lbPendapatanTotal.BackColor = Color.Transparent;
            lbPendapatanTotal.Font = new Font("Arial", 15F, FontStyle.Bold);
            lbPendapatanTotal.Location = new Point(1390, 514);
            lbPendapatanTotal.Name = "lbPendapatanTotal";
            lbPendapatanTotal.Size = new Size(250, 28);
            lbPendapatanTotal.TabIndex = 16;
            lbPendapatanTotal.Text = "0";
            // 
            // dataHewanForm2
            // 
            dataHewanForm2.BackColor = SystemColors.ButtonShadow;
            dataHewanForm2.BackgroundImage = (Image)resources.GetObject("dataHewanForm2.BackgroundImage");
            dataHewanForm2.BackgroundImageLayout = ImageLayout.Stretch;
            dataHewanForm2.Font = new Font("Arial", 9F);
            dataHewanForm2.Location = new Point(280, 0);
            dataHewanForm2.Margin = new Padding(2);
            dataHewanForm2.Name = "dataHewanForm2";
            dataHewanForm2.Size = new Size(1538, 988);
            dataHewanForm2.TabIndex = 18;
            dataHewanForm2.Load += dataHewanForm2_Load;
            // 
            // dgvDashAdmin
            // 
            dgvDashAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDashAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDashAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashAdmin.Columns.AddRange(new DataGridViewColumn[] { transaksi_id, nama_lengkap, tanggal_transaksi, harga_jual, subtotal, status_pembayaran });
            dgvDashAdmin.Location = new Point(357, 467);
            dgvDashAdmin.Name = "dgvDashAdmin";
            dgvDashAdmin.RowHeadersWidth = 51;
            dgvDashAdmin.Size = new Size(839, 455);
            dgvDashAdmin.TabIndex = 19;
            // 
            // transaksi_id
            // 
            transaksi_id.HeaderText = "Column1";
            transaksi_id.MinimumWidth = 6;
            transaksi_id.Name = "transaksi_id";
            // 
            // nama_lengkap
            // 
            nama_lengkap.HeaderText = "Column1";
            nama_lengkap.MinimumWidth = 6;
            nama_lengkap.Name = "nama_lengkap";
            // 
            // tanggal_transaksi
            // 
            tanggal_transaksi.HeaderText = "Column1";
            tanggal_transaksi.MinimumWidth = 6;
            tanggal_transaksi.Name = "tanggal_transaksi";
            // 
            // harga_jual
            // 
            harga_jual.HeaderText = "Column1";
            harga_jual.MinimumWidth = 6;
            harga_jual.Name = "harga_jual";
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Column1";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            // 
            // status_pembayaran
            // 
            status_pembayaran.HeaderText = "Column1";
            status_pembayaran.MinimumWidth = 6;
            status_pembayaran.Name = "status_pembayaran";
            // 
            // distribusiHewanForm2
            // 
            distribusiHewanForm2.BackgroundImage = (Image)resources.GetObject("distribusiHewanForm2.BackgroundImage");
            distribusiHewanForm2.BackgroundImageLayout = ImageLayout.Stretch;
            distribusiHewanForm2.Location = new Point(280, 0);
            distribusiHewanForm2.Name = "distribusiHewanForm2";
            distribusiHewanForm2.Size = new Size(1536, 988);
            distribusiHewanForm2.TabIndex = 20;
            // 
            // laporanPenjualanForm1
            // 
            laporanPenjualanForm1.BackgroundImage = (Image)resources.GetObject("laporanPenjualanForm1.BackgroundImage");
            laporanPenjualanForm1.BackgroundImageLayout = ImageLayout.Stretch;
            laporanPenjualanForm1.Location = new Point(280, 0);
            laporanPenjualanForm1.Name = "laporanPenjualanForm1";
            laporanPenjualanForm1.Size = new Size(1536, 988);
            laporanPenjualanForm1.TabIndex = 21;
            // 
            // editKlasifikasiQurbanForm1
            // 
            editKlasifikasiQurbanForm1.BackColor = Color.DarkGreen;
            editKlasifikasiQurbanForm1.Location = new Point(280, 1);
            editKlasifikasiQurbanForm1.Name = "editKlasifikasiQurbanForm1";
            editKlasifikasiQurbanForm1.Size = new Size(750, 1062);
            editKlasifikasiQurbanForm1.TabIndex = 22;
            // 
            // DashboardAdminForm
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1817, 988);
            Controls.Add(editKlasifikasiQurbanForm1);
            Controls.Add(laporanPenjualanForm1);
            Controls.Add(distribusiHewanForm2);
            Controls.Add(dgvDashAdmin);
            Controls.Add(dataHewanForm2);
            Controls.Add(lbPendapatanTotal);
            Controls.Add(lbDistribusi);
            Controls.Add(lbHewanTerjual);
            Controls.Add(lbHewanTersedia);
            Controls.Add(lbTotalTransaksi);
            Controls.Add(lbJumlahuser);
            Controls.Add(btnDistribusi);
            Controls.Add(btnLaporan);
            Controls.Add(btnRiwayat);
            Controls.Add(btnHewanTernak);
            Controls.Add(btnUsers);
            Controls.Add(btnDashboard);
            Controls.Add(riwayatTransaksiForm1);
            Controls.Add(tambah_hewan_ternak1);
            Controls.Add(dataUserForm1);
            Controls.Add(btnLogout);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += DashboardAdminForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvDashAdmin).EndInit();
            ResumeLayout(false);
        }

        private DataUserForm dataUserForm1;
        private Tambah_hewan_ternak tambah_hewan_ternak1;
        private RiwayatTransaksiForm riwayatTransaksiForm1;
        private Button btnDashboard;
        private Button btnUsers;
        private Button btnHewanTernak;
        private Button btnRiwayat;
        private Button btnLaporan;
        private Button btnDistribusi;
        private Label lbJumlahuser;
        private Label lbTotalTransaksi;
        private Label lbHewanTersedia;
        private Label lbHewanTerjual;
        private Label lbDistribusi;
        private Label lbPendapatanTotal;
        private DataHewanForm dataHewanForm2;
        private DistribusiHewanForm distribusiHewanForm1;
        private DataGridView dgvDashAdmin;
        private DataGridViewTextBoxColumn transaksi_id;
        private DataGridViewTextBoxColumn nama_lengkap;
        private DataGridViewTextBoxColumn tanggal_transaksi;
        private DataGridViewTextBoxColumn harga_jual;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewTextBoxColumn status_pembayaran;
        private DistribusiHewanForm distribusiHewanForm2;
        private LaporanPenjualanForm laporanPenjualanForm1;
        private EditKlasifikasiQurbanForm editKlasifikasiQurbanForm1;
        //private DistribusiHewanForm distribusiHewanForm1;
    }
    #endregion
}