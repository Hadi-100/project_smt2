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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdminForm));
            dataUserForm1 = new DataUserForm();
            tambah_hewan_ternak1 = new Tambah_hewan_ternak();
            riwayatTransaksiForm1 = new RiwayatTransaksiForm();
            distribusiHewanForm1 = new DistribusiHewanForm();
            dataHewanForm2 = new DataHewanForm();
            SuspendLayout();
            // 
            // dataUserForm1
            // 
            dataUserForm1.BackgroundImage = (Image)resources.GetObject("dataUserForm1.BackgroundImage");
            dataUserForm1.BackgroundImageLayout = ImageLayout.Stretch;
            dataUserForm1.Location = new Point(294, 0);
            dataUserForm1.Name = "dataUserForm1";
            dataUserForm1.Size = new Size(1604, 1029);
            dataUserForm1.TabIndex = 0;
            // 
            // tambah_hewan_ternak1
            // 
            tambah_hewan_ternak1.BackgroundImage = (Image)resources.GetObject("tambah_hewan_ternak1.BackgroundImage");
            tambah_hewan_ternak1.BackgroundImageLayout = ImageLayout.Stretch;
            tambah_hewan_ternak1.Location = new Point(294, 0);
            tambah_hewan_ternak1.Name = "tambah_hewan_ternak1";
            tambah_hewan_ternak1.Size = new Size(1596, 1029);
            tambah_hewan_ternak1.TabIndex = 2;
            // 
            // riwayatTransaksiForm1
            // 
            riwayatTransaksiForm1.BackgroundImage = (Image)resources.GetObject("riwayatTransaksiForm1.BackgroundImage");
            riwayatTransaksiForm1.BackgroundImageLayout = ImageLayout.Stretch;
            riwayatTransaksiForm1.Location = new Point(289, 0);
            riwayatTransaksiForm1.Name = "riwayatTransaksiForm1";
            riwayatTransaksiForm1.Size = new Size(1609, 1029);
            riwayatTransaksiForm1.TabIndex = 3;
            // 
            // distribusiHewanForm1
            // 
            distribusiHewanForm1.BackgroundImage = (Image)resources.GetObject("distribusiHewanForm1.BackgroundImage");
            distribusiHewanForm1.BackgroundImageLayout = ImageLayout.Stretch;
            distribusiHewanForm1.Location = new Point(286, 0);
            distribusiHewanForm1.Name = "distribusiHewanForm1";
            distribusiHewanForm1.Size = new Size(1609, 1029);
            distribusiHewanForm1.TabIndex = 4;
            distribusiHewanForm1.Load += distribusiHewanForm1_Load;
            // 
            // dataHewanForm2
            // 
            dataHewanForm2.BackColor = SystemColors.ButtonShadow;
            dataHewanForm2.BackgroundImage = (Image)resources.GetObject("dataHewanForm2.BackgroundImage");
            dataHewanForm2.BackgroundImageLayout = ImageLayout.Stretch;
            dataHewanForm2.Location = new Point(286, 0);
            dataHewanForm2.Name = "dataHewanForm2";
            dataHewanForm2.Size = new Size(1620, 1029);
            dataHewanForm2.TabIndex = 5;
            dataHewanForm2.Load += dataHewanForm2_Load;
            // 
            // DashboardAdminForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1029);
            Controls.Add(dataHewanForm2);
            Controls.Add(distribusiHewanForm1);
            Controls.Add(riwayatTransaksiForm1);
            Controls.Add(tambah_hewan_ternak1);
            Controls.Add(dataUserForm1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += DashboardAdminForm_Load_1;
            ResumeLayout(false);
        }

        private DataUserForm dataUserForm1;
        private DataHewanForm dataHewanForm1;
        private Tambah_hewan_ternak tambah_hewan_ternak1;
        private RiwayatTransaksiForm riwayatTransaksiForm1;
        private DistribusiHewanForm distribusiHewanForm1;
        private DataHewanForm dataHewanForm2;
    }
    #endregion
}