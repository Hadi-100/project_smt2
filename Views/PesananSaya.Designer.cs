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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesananSaya));
            dgvPesananSaya = new DataGridView();
            lblTotalPesanan = new Label();
            lblProsesPengiriman = new Label();
            lblSudahSelesai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPesananSaya).BeginInit();
            SuspendLayout();
            // 
            // dgvPesananSaya
            // 
            dgvPesananSaya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesananSaya.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPesananSaya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesananSaya.Location = new Point(72, 337);
            dgvPesananSaya.Name = "dgvPesananSaya";
            dgvPesananSaya.RowHeadersWidth = 51;
            dgvPesananSaya.Size = new Size(1391, 559);
            dgvPesananSaya.TabIndex = 0;
            // 
            // lblTotalPesanan
            // 
            lblTotalPesanan.AutoSize = true;
            lblTotalPesanan.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPesanan.Location = new Point(247, 223);
            lblTotalPesanan.Name = "lblTotalPesanan";
            lblTotalPesanan.Size = new Size(100, 35);
            lblTotalPesanan.TabIndex = 1;
            lblTotalPesanan.Text = "label1";
            // 
            // lblProsesPengiriman
            // 
            lblProsesPengiriman.AutoSize = true;
            lblProsesPengiriman.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProsesPengiriman.Location = new Point(739, 223);
            lblProsesPengiriman.Name = "lblProsesPengiriman";
            lblProsesPengiriman.Size = new Size(100, 35);
            lblProsesPengiriman.TabIndex = 2;
            lblProsesPengiriman.Text = "label2";
            // 
            // lblSudahSelesai
            // 
            lblSudahSelesai.AutoSize = true;
            lblSudahSelesai.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSudahSelesai.Location = new Point(1228, 223);
            lblSudahSelesai.Name = "lblSudahSelesai";
            lblSudahSelesai.Size = new Size(100, 35);
            lblSudahSelesai.TabIndex = 3;
            lblSudahSelesai.Text = "label3";
            // 
            // PesananSaya
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblSudahSelesai);
            Controls.Add(lblProsesPengiriman);
            Controls.Add(lblTotalPesanan);
            Controls.Add(dgvPesananSaya);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "PesananSaya";
            Size = new Size(1538, 988);
            Load += LoadPesananSaya;
            ((System.ComponentModel.ISupportInitialize)dgvPesananSaya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPesananSaya;
        private Label lblTotalPesanan;
        private Label lblProsesPengiriman;
        private Label lblSudahSelesai;
    }
}
