namespace project_smt2.Views
{
    partial class RiwayatTransaksiForm
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatTransaksiForm));
            dataGridViewRiwayat = new DataGridView();
            lblTotalTransaksi = new Label();
            lblbelumbayar = new Label();
            lblbelumlunas = new Label();
            lblnilaitotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRiwayat
            // 
            dataGridViewRiwayat.Anchor = AnchorStyles.None;
            dataGridViewRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRiwayat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRiwayat.Location = new Point(75, 403);
            dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            dataGridViewRiwayat.RowHeadersWidth = 82;
            dataGridViewRiwayat.Size = new Size(1436, 537);
            dataGridViewRiwayat.TabIndex = 0;
            dataGridViewRiwayat.CellContentClick += dataGridViewRiwayat_CellContentClick;
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.AutoSize = true;
            lblTotalTransaksi.Location = new Point(180, 296);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(78, 32);
            lblTotalTransaksi.TabIndex = 1;
            lblTotalTransaksi.Text = "label1";
            lblTotalTransaksi.Click += lblTotalTransaksi_Click;
            // 
            // lblbelumbayar
            // 
            lblbelumbayar.AutoSize = true;
            lblbelumbayar.Location = new Point(453, 296);
            lblbelumbayar.Name = "lblbelumbayar";
            lblbelumbayar.Size = new Size(78, 32);
            lblbelumbayar.TabIndex = 2;
            lblbelumbayar.Text = "label1";
            lblbelumbayar.Click += lblbelumbayar_Click;
            // 
            // lblbelumlunas
            // 
            lblbelumlunas.AutoSize = true;
            lblbelumlunas.Location = new Point(756, 296);
            lblbelumlunas.Name = "lblbelumlunas";
            lblbelumlunas.Size = new Size(78, 32);
            lblbelumlunas.TabIndex = 3;
            lblbelumlunas.Text = "label1";
            lblbelumlunas.Click += lblbelumlunas_Click;
            // 
            // lblnilaitotal
            // 
            lblnilaitotal.AutoSize = true;
            lblnilaitotal.Location = new Point(1314, 296);
            lblnilaitotal.Name = "lblnilaitotal";
            lblnilaitotal.Size = new Size(78, 32);
            lblnilaitotal.TabIndex = 4;
            lblnilaitotal.Text = "label1";
            lblnilaitotal.Click += lblnilaitotal_Click;
            // 
            // RiwayatTransaksiForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblnilaitotal);
            Controls.Add(lblbelumlunas);
            Controls.Add(lblbelumbayar);
            Controls.Add(lblTotalTransaksi);
            Controls.Add(dataGridViewRiwayat);
            DoubleBuffered = true;
            Name = "RiwayatTransaksiForm";
            Size = new Size(1600, 1020);
            Load += RiwayatTransaksiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridViewRiwayat;
        private Label lblTotalTransaksi;
        private Label lblbelumbayar;
        private Label lblbelumlunas;
        private Label lblnilaitotal;
    }
}
