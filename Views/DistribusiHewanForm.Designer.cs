namespace project_smt2
{
    partial class DistribusiHewanForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTerkirim = new Label();
            lbProses = new Label();
            lbDistribusi = new Label();
            dgvDistribusiHewan = new DataGridView();
            Edit = new DataGridViewLinkColumn();
            pnlEditStatus = new Panel();
            btnBatal = new Button();
            btnKonfirmasi = new Button();
            cbxStatus = new ComboBox();
            dtpTanggalPengiriman = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDistribusiHewan).BeginInit();
            pnlEditStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lbTerkirim
            // 
            lbTerkirim.AutoSize = true;
            lbTerkirim.BackColor = Color.Transparent;
            lbTerkirim.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTerkirim.Location = new Point(169, 842);
            lbTerkirim.Name = "lbTerkirim";
            lbTerkirim.Size = new Size(27, 30);
            lbTerkirim.TabIndex = 0;
            lbTerkirim.Text = "2";
            // 
            // lbProses
            // 
            lbProses.AutoSize = true;
            lbProses.BackColor = Color.Transparent;
            lbProses.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProses.Location = new Point(463, 842);
            lbProses.Name = "lbProses";
            lbProses.Size = new Size(27, 30);
            lbProses.TabIndex = 1;
            lbProses.Text = "2";
            // 
            // lbDistribusi
            // 
            lbDistribusi.AutoSize = true;
            lbDistribusi.BackColor = Color.Transparent;
            lbDistribusi.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDistribusi.Location = new Point(759, 842);
            lbDistribusi.Name = "lbDistribusi";
            lbDistribusi.Size = new Size(27, 30);
            lbDistribusi.TabIndex = 2;
            lbDistribusi.Text = "2";
            // 
            // dgvDistribusiHewan
            // 
            dgvDistribusiHewan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistribusiHewan.Columns.AddRange(new DataGridViewColumn[] { Edit });
            dgvDistribusiHewan.Location = new Point(53, 233);
            dgvDistribusiHewan.Name = "dgvDistribusiHewan";
            dgvDistribusiHewan.RowHeadersWidth = 51;
            dgvDistribusiHewan.Size = new Size(1436, 536);
            dgvDistribusiHewan.TabIndex = 3;
            dgvDistribusiHewan.CellContentClick += dgvDistribusiHewan_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 125;
            // 
            // pnlEditStatus
            // 
            pnlEditStatus.BackColor = Color.Green;
            pnlEditStatus.Controls.Add(btnBatal);
            pnlEditStatus.Controls.Add(btnKonfirmasi);
            pnlEditStatus.Controls.Add(cbxStatus);
            pnlEditStatus.Controls.Add(dtpTanggalPengiriman);
            pnlEditStatus.Controls.Add(label3);
            pnlEditStatus.Controls.Add(label2);
            pnlEditStatus.Controls.Add(label1);
            pnlEditStatus.Location = new Point(566, 233);
            pnlEditStatus.Name = "pnlEditStatus";
            pnlEditStatus.Size = new Size(526, 536);
            pnlEditStatus.TabIndex = 4;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Silver;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Arial", 12F);
            btnBatal.Location = new Point(234, 474);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(132, 47);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click_1;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.LawnGreen;
            btnKonfirmasi.FlatStyle = FlatStyle.Popup;
            btnKonfirmasi.Font = new Font("Arial", 12F);
            btnKonfirmasi.Location = new Point(381, 474);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(132, 47);
            btnKonfirmasi.TabIndex = 5;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.Click += btnKonfirmasi_Click_1;
            // 
            // cbxStatus
            // 
            cbxStatus.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Terkirim", "Proses" });
            cbxStatus.Location = new Point(32, 288);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(419, 38);
            cbxStatus.TabIndex = 4;
            // 
            // dtpTanggalPengiriman
            // 
            dtpTanggalPengiriman.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTanggalPengiriman.Location = new Point(32, 169);
            dtpTanggalPengiriman.Name = "dtpTanggalPengiriman";
            dtpTanggalPengiriman.Size = new Size(419, 42);
            dtpTanggalPengiriman.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 241);
            label3.Name = "label3";
            label3.Size = new Size(277, 35);
            label3.TabIndex = 2;
            label3.Text = "Status Pengiriman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 122);
            label2.Name = "label2";
            label2.Size = new Size(305, 35);
            label2.TabIndex = 1;
            label2.Text = "Tamggal Pengiriman";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(324, 35);
            label1.TabIndex = 0;
            label1.Text = "Edit Distribusi Hewan";
            // 
            // DistribusiHewanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Halaman_Distribusi_Hewan_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pnlEditStatus);
            Controls.Add(dgvDistribusiHewan);
            Controls.Add(lbDistribusi);
            Controls.Add(lbProses);
            Controls.Add(lbTerkirim);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "DistribusiHewanForm";
            Size = new Size(1600, 1020);
            Load += DistribusiHewanForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvDistribusiHewan).EndInit();
            pnlEditStatus.ResumeLayout(false);
            pnlEditStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTerkirim;
        private Label lbProses;
        private Label lbDistribusi;
        private DataGridView dgvDistribusiHewan;
        private Panel pnlEditStatus;
        private DateTimePicker dtpTanggalPengiriman;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBatal;
        private Button btnKonfirmasi;
        private ComboBox cbxStatus;
        private DataGridViewLinkColumn Edit;
    }
}
