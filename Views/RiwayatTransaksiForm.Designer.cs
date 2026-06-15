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
            dataGridViewRiwayat.Location = new Point(100, 403);
            dataGridViewRiwayat.Margin = new Padding(2);
            dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            dataGridViewRiwayat.RowHeadersWidth = 82;
            dataGridViewRiwayat.Size = new Size(1389, 530);
            dataGridViewRiwayat.TabIndex = 0;
            dataGridViewRiwayat.CellContentClick += dataGridViewRiwayat_CellContentClick;
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.BackColor = Color.Transparent;
            lblTotalTransaksi.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransaksi.Location = new Point(128, 276);
            lblTotalTransaksi.Margin = new Padding(2, 0, 2, 0);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(120, 40);
            lblTotalTransaksi.TabIndex = 1;
            lblTotalTransaksi.Text = "label1";
            lblTotalTransaksi.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalTransaksi.Click += lblTotalTransaksi_Click;
            // 
            // lblbelumbayar
            // 
            lblbelumbayar.BackColor = Color.Transparent;
            lblbelumbayar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbelumbayar.Location = new Point(425, 279);
            lblbelumbayar.Margin = new Padding(2, 0, 2, 0);
            lblbelumbayar.Name = "lblbelumbayar";
            lblbelumbayar.Size = new Size(120, 40);
            lblbelumbayar.TabIndex = 2;
            lblbelumbayar.Text = "label1";
            lblbelumbayar.TextAlign = ContentAlignment.MiddleCenter;
            lblbelumbayar.Click += lblbelumbayar_Click;
            // 
            // lblbelumlunas
            // 
            lblbelumlunas.BackColor = Color.Transparent;
            lblbelumlunas.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbelumlunas.Location = new Point(710, 279);
            lblbelumlunas.Margin = new Padding(2, 0, 2, 0);
            lblbelumlunas.Name = "lblbelumlunas";
            lblbelumlunas.Size = new Size(120, 40);
            lblbelumlunas.TabIndex = 3;
            lblbelumlunas.Text = "label1";
            lblbelumlunas.TextAlign = ContentAlignment.MiddleCenter;
            lblbelumlunas.Click += lblbelumlunas_Click;
            // 
            // lblnilaitotal
            // 
            lblnilaitotal.BackColor = Color.Transparent;
            lblnilaitotal.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnilaitotal.Location = new Point(1059, 279);
            lblnilaitotal.Margin = new Padding(2, 0, 2, 0);
            lblnilaitotal.Name = "lblnilaitotal";
            lblnilaitotal.Size = new Size(250, 40);
            lblnilaitotal.TabIndex = 4;
            lblnilaitotal.Text = "label1";
            lblnilaitotal.Click += lblnilaitotal_Click;
            // 
            // RiwayatTransaksiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblnilaitotal);
            Controls.Add(lblbelumlunas);
            Controls.Add(lblbelumbayar);
            Controls.Add(lblTotalTransaksi);
            Controls.Add(dataGridViewRiwayat);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "RiwayatTransaksiForm";
            Size = new Size(985, 638);
            Load += RiwayatTransaksiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dataGridViewRiwayat;
        private Label lblTotalTransaksi;
        private Label lblbelumbayar;
        private Label lblbelumlunas;
        private Label lblnilaitotal;
    }
}
