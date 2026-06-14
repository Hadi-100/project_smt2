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
            //distribusiHewanForm1 = new DistribusiHewanForm();
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
            dgvRiwayatTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).BeginInit();
            SuspendLayout();
            // 
            // dataUserForm1
            // 
            dataUserForm1.BackgroundImage = (Image)resources.GetObject("dataUserForm1.BackgroundImage");
            dataUserForm1.BackgroundImageLayout = ImageLayout.Stretch;
            dataUserForm1.Location = new Point(280, 0);
            dataUserForm1.Margin = new Padding(2);
            dataUserForm1.Name = "dataUserForm1";
            dataUserForm1.Size = new Size(1536, 988);
            dataUserForm1.TabIndex = 0;
            // 
            // dataHewanForm1
            // 
            //dataHewanForm1.BackColor = SystemColors.ButtonShadow;
            //dataHewanForm1.BackgroundImage = (Image)resources.GetObject("dataHewanForm1.BackgroundImage");
            //dataHewanForm1.BackgroundImageLayout = ImageLayout.Stretch;
            //dataHewanForm1.Font = new Font("Arial", 9F);
            //dataHewanForm1.Location = new Point(280, 0);
            //dataHewanForm1.Margin = new Padding(2, 2, 2, 2);
            //dataHewanForm1.Name = "dataHewanForm1";
            //dataHewanForm1.Size = new Size(1536, 986);
            //dataHewanForm1.TabIndex = 1;
            // 
            // tambah_hewan_ternak1
            // 
            tambah_hewan_ternak1.BackgroundImage = (Image)resources.GetObject("tambah_hewan_ternak1.BackgroundImage");
            tambah_hewan_ternak1.BackgroundImageLayout = ImageLayout.Stretch;
            tambah_hewan_ternak1.Location = new Point(280, 0);
            tambah_hewan_ternak1.Margin = new Padding(2);
            tambah_hewan_ternak1.Name = "tambah_hewan_ternak1";
            tambah_hewan_ternak1.Size = new Size(1536, 986);
            tambah_hewan_ternak1.TabIndex = 2;
            // 
            // riwayatTransaksiForm1
            // 
            riwayatTransaksiForm1.BackgroundImage = (Image)resources.GetObject("riwayatTransaksiForm1.BackgroundImage");
            riwayatTransaksiForm1.BackgroundImageLayout = ImageLayout.Stretch;
            riwayatTransaksiForm1.Location = new Point(280, 0);
            riwayatTransaksiForm1.Margin = new Padding(2, 2, 2, 2);
            riwayatTransaksiForm1.Name = "riwayatTransaksiForm1";
            riwayatTransaksiForm1.Size = new Size(1538, 987);
            riwayatTransaksiForm1.TabIndex = 3;
            // 
            // distribusiHewanForm1
            // 
            //distribusiHewanForm1.AutoSize = true;
            //distribusiHewanForm1.BackgroundImage = (Image)resources.GetObject("distribusiHewanForm1.BackgroundImage");
            //distribusiHewanForm1.BackgroundImageLayout = ImageLayout.Stretch;
            //distribusiHewanForm1.Location = new Point(280, 0);
            //distribusiHewanForm1.Margin = new Padding(2, 2, 2, 2);
            //distribusiHewanForm1.Name = "distribusiHewanForm1";
            //distribusiHewanForm1.Size = new Size(1536, 988);
            //distribusiHewanForm1.TabIndex = 4;
            ////distribusiHewanForm1.Load += distribusiHewanForm1_Load;
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
            lbJumlahuser.AutoSize = true;
            lbJumlahuser.Font = new Font("Arial", 15F);
            lbJumlahuser.Location = new Point(426, 306);
            lbJumlahuser.Name = "lbJumlahuser";
            lbJumlahuser.Size = new Size(56, 28);
            lbJumlahuser.TabIndex = 11;
            lbJumlahuser.Text = "Null";
            // 
            // lbTotalTransaksi
            // 
            lbTotalTransaksi.AutoSize = true;
            lbTotalTransaksi.Font = new Font("Arial", 15F);
            lbTotalTransaksi.Location = new Point(690, 306);
            lbTotalTransaksi.Name = "lbTotalTransaksi";
            lbTotalTransaksi.Size = new Size(56, 28);
            lbTotalTransaksi.TabIndex = 12;
            lbTotalTransaksi.Text = "Null";
            // 
            // lbHewanTersedia
            // 
            lbHewanTersedia.AutoSize = true;
            lbHewanTersedia.Font = new Font("Arial", 15F);
            lbHewanTersedia.Location = new Point(982, 306);
            lbHewanTersedia.Name = "lbHewanTersedia";
            lbHewanTersedia.Size = new Size(56, 28);
            lbHewanTersedia.TabIndex = 13;
            lbHewanTersedia.Text = "Null";
            // 
            // lbHewanTerjual
            // 
            lbHewanTerjual.AutoSize = true;
            lbHewanTerjual.Font = new Font("Arial", 15F);
            lbHewanTerjual.Location = new Point(1296, 306);
            lbHewanTerjual.Name = "lbHewanTerjual";
            lbHewanTerjual.Size = new Size(56, 28);
            lbHewanTerjual.TabIndex = 14;
            lbHewanTerjual.Text = "Null";
            // 
            // lbDistribusi
            // 
            lbDistribusi.AutoSize = true;
            lbDistribusi.Font = new Font("Arial", 15F);
            lbDistribusi.Location = new Point(1596, 306);
            lbDistribusi.Name = "lbDistribusi";
            lbDistribusi.Size = new Size(56, 28);
            lbDistribusi.TabIndex = 15;
            lbDistribusi.Text = "Null";
            // 
            // lbPendapatanTotal
            // 
            lbPendapatanTotal.AutoSize = true;
            lbPendapatanTotal.Font = new Font("Arial", 15F);
            lbPendapatanTotal.Location = new Point(1466, 514);
            lbPendapatanTotal.Name = "lbPendapatanTotal";
            lbPendapatanTotal.Size = new Size(56, 28);
            lbPendapatanTotal.TabIndex = 16;
            lbPendapatanTotal.Text = "Null";
            // 
            // dgvRiwayatTransaksi
            // 
            dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksi.Location = new Point(358, 466);
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersWidth = 51;
            dgvRiwayatTransaksi.Size = new Size(840, 454);
            dgvRiwayatTransaksi.TabIndex = 17;
            // 
            // DashboardAdminForm
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1817, 988);
            Controls.Add(dgvRiwayatTransaksi);
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
            //Controls.Add(distribusiHewanForm1);
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
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataUserForm dataUserForm1;
        private DataHewanForm dataHewanForm1;
        private Tambah_hewan_ternak tambah_hewan_ternak1;
        private RiwayatTransaksiForm riwayatTransaksiForm1;
        //private DistribusiHewanForm distribusiHewanForm1;
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
        private DataGridView dgvRiwayatTransaksi;
    }
    #endregion
}