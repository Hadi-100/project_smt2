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
        private string username;
        public DashboardUserForm(string namaLengkap)
        {
            InitializeComponent();

            this.username = namaLengkap;
            lblNamaUser.Text = namaLengkap;

            new AutoScaleHelper(this);
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
            lblNamaUser = new Label();
            riwayatTransaksiUSER = new RiwayatTransaksiUSER();
            pesananSaya1 = new PesananSaya();
            lblNamaRole = new Label();
            //masukkanAlamat1 = new MasukkanAlamat();
            SuspendLayout();
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
            btnHewanQurban.Font = new Font("Arial", 16F, FontStyle.Bold);
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
            btnHalamanUtama.FlatStyle = FlatStyle.Popup;
            btnHalamanUtama.Font = new Font("Arial", 1.8F);
            btnHalamanUtama.ForeColor = Color.White;
            btnHalamanUtama.Location = new Point(304, 39);
            btnHalamanUtama.Name = "btnHalamanUtama";
            btnHalamanUtama.Size = new Size(190, 68);
            btnHalamanUtama.TabIndex = 2;
            btnHalamanUtama.Text = ".";
            btnHalamanUtama.UseVisualStyleBackColor = false;
            btnHalamanUtama.Click += btnHalamanUtama_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.Transparent;
            btnRiwayatTransaksi.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiwayatTransaksi.FlatStyle = FlatStyle.Popup;
            btnRiwayatTransaksi.Font = new Font("Arial", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.ForeColor = Color.White;
            btnRiwayatTransaksi.Location = new Point(521, 39);
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
            btnPesananSaya.Font = new Font("Arial", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Arial", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(1406, 46);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(107, 55);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = ".";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.BackColor = Color.Transparent;
            lblNamaUser.FlatStyle = FlatStyle.Popup;
            lblNamaUser.Font = new Font("Arial", 8F);
            lblNamaUser.ForeColor = Color.White;
            lblNamaUser.Location = new Point(106, 56);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(68, 25);
            lblNamaUser.TabIndex = 6;
            lblNamaUser.Text = "label1";
            lblNamaUser.Click += lblNamaUser_Click_1;
            // 
            // riwayatTransaksiUSER
            // 
            riwayatTransaksiUSER.BackgroundImage = (Image)resources.GetObject("riwayatTransaksiUSER.BackgroundImage");
            riwayatTransaksiUSER.BackgroundImageLayout = ImageLayout.Stretch;
            riwayatTransaksiUSER.Location = new Point(0, 156);
            riwayatTransaksiUSER.Name = "riwayatTransaksiUSER";
            riwayatTransaksiUSER.Size = new Size(1538, 832);
            riwayatTransaksiUSER.TabIndex = 7;
            riwayatTransaksiUSER.Load += riwayat_transaksi_user1_Load;
            // 
            // pesananSaya1
            // 
            pesananSaya1.BackgroundImage = (Image)resources.GetObject("pesananSaya1.BackgroundImage");
            pesananSaya1.BackgroundImageLayout = ImageLayout.Stretch;
            pesananSaya1.Location = new Point(0, 156);
            pesananSaya1.Margin = new Padding(2);
            pesananSaya1.Name = "pesananSaya1";
            pesananSaya1.Size = new Size(1538, 832);
            pesananSaya1.TabIndex = 8;
            pesananSaya1.Load += pesananSaya1_Load;
            // 
            // lblNamaRole
            // 
            lblNamaRole.AutoSize = true;
            lblNamaRole.BackColor = Color.Transparent;
            lblNamaRole.FlatStyle = FlatStyle.Popup;
            lblNamaRole.Font = new Font("Arial", 7.8F);
            lblNamaRole.ForeColor = Color.Yellow;
            lblNamaRole.Location = new Point(106, 80);
            lblNamaRole.Name = "lblNamaRole";
            lblNamaRole.Size = new Size(54, 24);
            lblNamaRole.TabIndex = 9;
            lblNamaRole.Text = "User";
            lblNamaRole.Click += label1_Click;
            // 
            // masukkanAlamat1
            // 
            // 
            masukkanAlamat1.BackgroundImageLayout = ImageLayout.Stretch;
            masukkanAlamat1.Location = new Point(0, 156);
            masukkanAlamat1.Name = "masukkanAlamat1";
            masukkanAlamat1.Size = new Size(1538, 832);
            masukkanAlamat1.TabIndex = 10;
            masukkanAlamat1.Load += masukkanAlamat1_Load;
            // 
            // DashboardUserForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1538, 988);
            Controls.Add(masukkanAlamat1);
            Controls.Add(lblNamaRole);
            Controls.Add(pesananSaya1);
            Controls.Add(riwayatTransaksiUSER);
            Controls.Add(lblNamaUser);
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
            Text = "2";
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
        private Label lblNamaUser;

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
            riwayatTransaksiUSER.Show();
            pesananSaya1.Hide();
        }

        private void btnPesananSaya_Click(object sender, EventArgs e)
        {
            pesananSaya1.Show();
            riwayatTransaksiUSER.Hide();
        }

        private void btnHalamanUtama_Click(object sender, EventArgs e)
        {
            riwayatTransaksiUSER.Hide();
            pesananSaya1.Hide();
        }

        private void riwayat_transaksi_user1_Load(object sender, EventArgs e)
        {

        }

        private void pesananSaya1_Load(object sender, EventArgs e)
        {

        }

        private void lblNamaUser_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaUser_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void masukkanAlamat1_Load(object sender, EventArgs e)
        {

        }
    }
}

