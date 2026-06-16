using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class DashboardUserForm : Form
    {
        public DashboardUserForm()
        {
            InitializeComponent();

            new AutoScaleHelper(this);

            //MessageBox.Show("Dashboard User Form Loaded");
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(DashboardUserForm));
            btnHewanTernak = new Button();
            btnHewanQurban = new Button();
            btnHalamanUtama = new Button();
            btnRiwayatTransaksi = new Button();
            btnPesananSaya = new Button();
            btnLogOut = new Button();
            label1 = new Label();
            riwayat_transaksi_user1 = new Riwayat_transaksi_USER();
            pesananSaya1 = new PesananSaya();
            SuspendLayout();

            pesananSaya1.Hide();
            riwayat_transaksi_user1.Hide();
            // 
            // btnHewanTernak
            // 
            btnHewanTernak.BackColor = Color.White;
            btnHewanTernak.BackgroundImageLayout = ImageLayout.Stretch;
            btnHewanTernak.FlatStyle = FlatStyle.Popup;
            btnHewanTernak.Font = new Font("Arial", 18.2F, FontStyle.Bold);
            btnHewanTernak.ForeColor = Color.Green;
            btnHewanTernak.Location = new Point(376, 802);
            btnHewanTernak.Name = "btnHewanTernak";
            btnHewanTernak.Size = new Size(369, 100);
            btnHewanTernak.TabIndex = 0;
            btnHewanTernak.Text = "Hewan Ternak";
            btnHewanTernak.UseVisualStyleBackColor = false;
            btnHewanTernak.Click += btnHewanTernak_Click;
            // 
            // btnHewanQurban
            // 
            btnHewanQurban.BackColor = Color.Green;
            btnHewanQurban.BackgroundImageLayout = ImageLayout.Stretch;
            btnHewanQurban.FlatStyle = FlatStyle.Popup;
            btnHewanQurban.ForeColor = Color.White;
            btnHewanQurban.Location = new Point(789, 802);
            btnHewanQurban.Name = "btnHewanQurban";
            btnHewanQurban.Size = new Size(367, 100);
            btnHewanQurban.TabIndex = 0;
            btnHewanQurban.Text = "Hewan Qurban";
            btnHewanQurban.UseVisualStyleBackColor = false;
            btnHewanQurban.Click += btnHewanQurban_Click;
            // 
            // btnHalamanUtama
            // 
            btnHalamanUtama.BackColor = Color.Transparent;
            btnHalamanUtama.BackgroundImageLayout = ImageLayout.Stretch;
            btnHalamanUtama.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHalamanUtama.ForeColor = Color.Black;
            btnHalamanUtama.Location = new Point(303, 39);
            btnHalamanUtama.Name = "btnHalamanUtama";
            btnHalamanUtama.Size = new Size(190, 68);
            btnHalamanUtama.TabIndex = 2;
            btnHalamanUtama.Text = "Halaman utama";
            btnHalamanUtama.UseVisualStyleBackColor = false;
            btnHalamanUtama.Click += btnHalamanUtama_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.Transparent;
            btnRiwayatTransaksi.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiwayatTransaksi.FlatStyle = FlatStyle.Popup;
            btnRiwayatTransaksi.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.ForeColor = Color.White;
            btnRiwayatTransaksi.Location = new Point(520, 39);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(188, 68);
            btnRiwayatTransaksi.TabIndex = 3;
            btnRiwayatTransaksi.Text = ".";
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += button4_Click;
            // 
            // btnPesananSaya
            // 
            btnPesananSaya.BackColor = Color.Transparent;
            btnPesananSaya.BackgroundImageLayout = ImageLayout.Stretch;
            btnPesananSaya.FlatStyle = FlatStyle.Popup;
            btnPesananSaya.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesananSaya.ForeColor = Color.White;
            btnPesananSaya.Location = new Point(736, 39);
            btnPesananSaya.Name = "btnPesananSaya";
            btnPesananSaya.Size = new Size(191, 68);
            btnPesananSaya.TabIndex = 4;
            btnPesananSaya.Text = ".";
            btnPesananSaya.UseVisualStyleBackColor = false;
            btnPesananSaya.Click += btnPesananSaya_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(1406, 46);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(107, 55);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 59);
            label1.Name = "label1";
            label1.Size = new Size(114, 42);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // riwayat_transaksi_user1
            // 
            riwayat_transaksi_user1.BackgroundImage = (Image)resources.GetObject("riwayat_transaksi_user1.BackgroundImage");
            riwayat_transaksi_user1.BackgroundImageLayout = ImageLayout.Stretch;
            riwayat_transaksi_user1.Location = new Point(0, 156);
            riwayat_transaksi_user1.Name = "riwayat_transaksi_user1";
            riwayat_transaksi_user1.Size = new Size(1538, 832);
            riwayat_transaksi_user1.TabIndex = 7;
            riwayat_transaksi_user1.Load += riwayat_transaksi_user1_Load;
            // 
            // pesananSaya1
            // 
            pesananSaya1.BackgroundImage = (Image)resources.GetObject("pesananSaya1.BackgroundImage");
            pesananSaya1.BackgroundImageLayout = ImageLayout.Stretch;
            pesananSaya1.Location = new Point(0, 156);
            pesananSaya1.Name = "pesananSaya1";
            pesananSaya1.Size = new Size(1538, 832);
            pesananSaya1.TabIndex = 8;
            pesananSaya1.Load += pesananSaya1_Load;
            // 
            // DashboardUserForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1538, 988);
            Controls.Add(pesananSaya1);
            Controls.Add(riwayat_transaksi_user1);
            Controls.Add(label1);
            Controls.Add(btnLogOut);
            Controls.Add(btnPesananSaya);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnHalamanUtama);
            Controls.Add(btnHewanQurban);
            Controls.Add(btnHewanTernak);
            DoubleBuffered = true;
            Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardUserForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();

        }

        private Button btnHewanTernak;
        private Button btnHewanQurban;
        private Button btnHalamanUtama;
        private Button btnRiwayatTransaksi;
        private Button btnPesananSaya;
        private Button btnLogOut;
        private Label label1;

        private void btnHewanTernak_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tombol Hewan Ternak diklik");
        }

        private void btnHewanQurban_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tombol Hewan Qurban diklik");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            riwayat_transaksi_user1.Show();
            pesananSaya1.Hide();
        }

        private void btnPesananSaya_Click(object sender, EventArgs e)
        {
            pesananSaya1.Show();
            riwayat_transaksi_user1.Hide();
        }

        private void btnHalamanUtama_Click(object sender, EventArgs e)
        {
            riwayat_transaksi_user1.Hide();
            pesananSaya1.Hide();
        }

        private void riwayat_transaksi_user1_Load(object sender, EventArgs e)
        {

        }

        private void pesananSaya1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

