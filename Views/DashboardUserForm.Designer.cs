using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class DashboardUserForm : Form
    {
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
            listHewanTernak1 = new ListHewanTernak();
            listHewanQurban1 = new ListHewanQurban();
            riwayatTransaksiuser1 = new RiwayatTransaksiUSER();
            masukkanAlamat2 = new MasukkanAlamat();
            pembayaranForm1 = new PembayaranForm();
            SuspendLayout();

            pembayaranForm1.Hide();
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
            lblNamaUser.Size = new Size(45, 16);
            lblNamaUser.TabIndex = 6;
            lblNamaUser.Text = "label1";
            lblNamaUser.Click += lblNamaUser_Click_1;
            // 
            // riwayatTransaksiUSER
            // 
            riwayatTransaksiUSER.BackgroundImage = (Image)resources.GetObject("riwayatTransaksiUSER.BackgroundImage");
            riwayatTransaksiUSER.BackgroundImageLayout = ImageLayout.Stretch;
            riwayatTransaksiUSER.Location = new Point(0, 156);
            riwayatTransaksiUSER.Margin = new Padding(2);
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
            lblNamaRole.Size = new Size(34, 16);
            lblNamaRole.TabIndex = 9;
            lblNamaRole.Text = "User";
            lblNamaRole.Click += label1_Click;
            // 
            // listHewanTernak1
            // 
            listHewanTernak1.BackgroundImage = (Image)resources.GetObject("listHewanTernak1.BackgroundImage");
            listHewanTernak1.BackgroundImageLayout = ImageLayout.Stretch;
            listHewanTernak1.Location = new Point(0, 156);
            listHewanTernak1.Name = "listHewanTernak1";
            listHewanTernak1.Size = new Size(1538, 832);
            listHewanTernak1.TabIndex = 10;
            // 
            // listHewanQurban1
            // 
            listHewanQurban1.BackgroundImage = (Image)resources.GetObject("listHewanQurban1.BackgroundImage");
            listHewanQurban1.BackgroundImageLayout = ImageLayout.Stretch;
            listHewanQurban1.Location = new Point(0, 156);
            listHewanQurban1.Name = "listHewanQurban1";
            listHewanQurban1.Size = new Size(1538, 832);
            listHewanQurban1.TabIndex = 11;
            // 
            // riwayatTransaksiuser1
            // 
            riwayatTransaksiuser1.BackgroundImage = (Image)resources.GetObject("riwayatTransaksiuser1.BackgroundImage");
            riwayatTransaksiuser1.BackgroundImageLayout = ImageLayout.Stretch;
            riwayatTransaksiuser1.Location = new Point(0, 156);
            riwayatTransaksiuser1.Margin = new Padding(2);
            riwayatTransaksiuser1.Name = "riwayatTransaksiuser1";
            riwayatTransaksiuser1.Size = new Size(1538, 832);
            riwayatTransaksiuser1.TabIndex = 12;
            riwayatTransaksiuser1.Load += riwayatTransaksiuser1_Load;
            // 
            // masukkanAlamat2
            // 
            masukkanAlamat2.BackgroundImage = (Image)resources.GetObject("masukkanAlamat2.BackgroundImage");
            masukkanAlamat2.BackgroundImageLayout = ImageLayout.Stretch;
            masukkanAlamat2.Location = new Point(0, 156);
            masukkanAlamat2.Margin = new Padding(2);
            masukkanAlamat2.Name = "masukkanAlamat2";
            masukkanAlamat2.Size = new Size(1538, 832);
            masukkanAlamat2.TabIndex = 13;
            masukkanAlamat2.Load += masukkanAlamat2_Load_1;
            // 
            // pembayaranForm1
            // 
            pembayaranForm1.BackgroundImage = (Image)resources.GetObject("pembayaranForm1.BackgroundImage");
            pembayaranForm1.BackgroundImageLayout = ImageLayout.Stretch;
            pembayaranForm1.Location = new Point(0, 156);
            pembayaranForm1.Margin = new Padding(2);
            pembayaranForm1.Name = "pembayaranForm1";
            pembayaranForm1.Size = new Size(1538, 832);
            pembayaranForm1.TabIndex = 14;
            pembayaranForm1.Load += pembayaranForm1_Load;
            // 
            // DashboardUserForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1538, 988);
            Controls.Add(pembayaranForm1);
            Controls.Add(masukkanAlamat2);
            Controls.Add(riwayatTransaksiuser1);
            Controls.Add(listHewanQurban1);
            Controls.Add(listHewanTernak1);
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
        private void DashboardUserForm_Load(object sender, EventArgs e)
        {
            //lblJudul.Text = "Dashboard User";
        }

        private RiwayatTransaksiUSER riwayatTransaksiUSER;
        private PesananSaya pesananSaya1;
        private Label lblNamaRole;
        private ListHewanTernak listHewanTernak1;
        private ListHewanQurban listHewanQurban1;
        //private MasukkanAlamat masukkanAlamat1;
        private RiwayatTransaksiUSER riwayatTransaksiuser1;
        private MasukkanAlamat masukkanAlamat2;
        private PembayaranForm pembayaranForm1;

        private Button btnHewanTernak;
        private Button btnHewanQurban;
        private Button btnHalamanUtama;
        private Button btnRiwayatTransaksi;
        private Button btnPesananSaya;
        private Button btnLogOut;
        private Label lblNamaUser;
        //private PembayaranForm pembayaranForm1;
    }
}