namespace project_smt2.Views
{
    partial class PesananSaya
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesananSaya));
            dgvPesananSaya = new DataGridView();
            lblTotalPesanan = new Label();
            lblProsesPengiriman = new Label();
            lblSudahSelesai = new Label();
            lblSudahTerkirim = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPesananSaya).BeginInit();
            SuspendLayout();
            // 
            // dgvPesananSaya
            // 
            dgvPesananSaya.AllowUserToAddRows = false;
            dgvPesananSaya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesananSaya.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPesananSaya.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvPesananSaya.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPesananSaya.ColumnHeadersHeight = 100;
            dgvPesananSaya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPesananSaya.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPesananSaya.Location = new Point(69, 338);
            dgvPesananSaya.Margin = new Padding(5);
            dgvPesananSaya.MultiSelect = false;
            dgvPesananSaya.Name = "dgvPesananSaya";
            dgvPesananSaya.ReadOnly = true;
            dgvPesananSaya.RowHeadersVisible = false;
            dgvPesananSaya.RowHeadersWidth = 51;
            dgvPesananSaya.Size = new Size(1394, 471);
            dgvPesananSaya.TabIndex = 0;
            dgvPesananSaya.CellContentClick += dgvPesananSaya_CellContentClick;
            // 
            // lblTotalPesanan
            // 
            lblTotalPesanan.AutoSize = true;
            lblTotalPesanan.BackColor = Color.Transparent;
            lblTotalPesanan.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPesanan.Location = new Point(360, 224);
            lblTotalPesanan.Margin = new Padding(5, 0, 5, 0);
            lblTotalPesanan.Name = "lblTotalPesanan";
            lblTotalPesanan.Size = new Size(110, 37);
            lblTotalPesanan.TabIndex = 1;
            lblTotalPesanan.Text = "label1";
            lblTotalPesanan.Click += lblTotalPesanan_Click;
            // 
            // lblProsesPengiriman
            // 
            lblProsesPengiriman.AutoSize = true;
            lblProsesPengiriman.BackColor = Color.Transparent;
            lblProsesPengiriman.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProsesPengiriman.Location = new Point(847, 224);
            lblProsesPengiriman.Margin = new Padding(5, 0, 5, 0);
            lblProsesPengiriman.Name = "lblProsesPengiriman";
            lblProsesPengiriman.Size = new Size(110, 37);
            lblProsesPengiriman.TabIndex = 2;
            lblProsesPengiriman.Text = "label2";
            lblProsesPengiriman.Click += lblProsesPengiriman_Click;
            // 
            // lblSudahSelesai
            // 
            lblSudahSelesai.AutoSize = true;
            lblSudahSelesai.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSudahSelesai.Location = new Point(1996, 357);
            lblSudahSelesai.Margin = new Padding(5, 0, 5, 0);
            lblSudahSelesai.Name = "lblSudahSelesai";
            lblSudahSelesai.Size = new Size(160, 56);
            lblSudahSelesai.TabIndex = 3;
            lblSudahSelesai.Text = "label3";
            // 
            // lblSudahTerkirim
            // 
            lblSudahTerkirim.AutoSize = true;
            lblSudahTerkirim.BackColor = Color.Transparent;
            lblSudahTerkirim.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSudahTerkirim.Location = new Point(1316, 224);
            lblSudahTerkirim.Name = "lblSudahTerkirim";
            lblSudahTerkirim.Size = new Size(110, 37);
            lblSudahTerkirim.TabIndex = 4;
            lblSudahTerkirim.Text = "label1";
            lblSudahTerkirim.Click += lblSudahTerkirim_Click;
            // 
            // PesananSaya
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblSudahTerkirim);
            Controls.Add(lblSudahSelesai);
            Controls.Add(lblProsesPengiriman);
            Controls.Add(lblTotalPesanan);
            Controls.Add(dgvPesananSaya);
            DoubleBuffered = true;
            Name = "PesananSaya";
            Size = new Size(1538, 832);
            ((System.ComponentModel.ISupportInitialize)dgvPesananSaya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPesananSaya;
        private Label lblTotalPesanan;
        private Label lblProsesPengiriman;
        private Label lblSudahSelesai;
        private Label lblSudahTerkirim;
    }
}
