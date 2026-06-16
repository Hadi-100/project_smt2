namespace project_smt2.Views
{
    partial class RiwayatTransaksiUSER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatTransaksiUSER));
            dgvRiwayatTransaksiUser = new DataGridView();
            lblTotalTransaksiUser = new Label();
            lblSudahLunas = new Label();
            lblBelumLunas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksiUser).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayatTransaksiUser
            // 
            dgvRiwayatTransaksiUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatTransaksiUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRiwayatTransaksiUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksiUser.Location = new Point(71, 338);
            dgvRiwayatTransaksiUser.Name = "dgvRiwayatTransaksiUser";
            dgvRiwayatTransaksiUser.RowHeadersWidth = 82;
            dgvRiwayatTransaksiUser.Size = new Size(1395, 472);
            dgvRiwayatTransaksiUser.TabIndex = 0;
            // 
            // lblTotalTransaksiUser
            // 
            lblTotalTransaksiUser.AutoSize = true;
            lblTotalTransaksiUser.BackColor = Color.Transparent;
            lblTotalTransaksiUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransaksiUser.Location = new Point(353, 226);
            lblTotalTransaksiUser.Name = "lblTotalTransaksiUser";
            lblTotalTransaksiUser.Size = new Size(110, 37);
            lblTotalTransaksiUser.TabIndex = 1;
            lblTotalTransaksiUser.Text = "label1";
            lblTotalTransaksiUser.Click += lblTotalTransaksiUser_Click_1;
            // 
            // lblSudahLunas
            // 
            lblSudahLunas.AutoSize = true;
            lblSudahLunas.BackColor = Color.Transparent;
            lblSudahLunas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSudahLunas.Location = new Point(837, 225);
            lblSudahLunas.Name = "lblSudahLunas";
            lblSudahLunas.Size = new Size(110, 37);
            lblSudahLunas.TabIndex = 2;
            lblSudahLunas.Text = "label1";
            lblSudahLunas.Click += lblSudahLunas_Click;
            // 
            // lblBelumLunas
            // 
            lblBelumLunas.AutoSize = true;
            lblBelumLunas.BackColor = Color.Transparent;
            lblBelumLunas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBelumLunas.Location = new Point(1322, 226);
            lblBelumLunas.Name = "lblBelumLunas";
            lblBelumLunas.Size = new Size(110, 37);
            lblBelumLunas.TabIndex = 3;
            lblBelumLunas.Text = "label1";
            lblBelumLunas.Click += lblBelumLunas_Click;
            // 
            // RiwayatTransaksiUSER
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblBelumLunas);
            Controls.Add(lblSudahLunas);
            Controls.Add(lblTotalTransaksiUser);
            Controls.Add(dgvRiwayatTransaksiUser);
            DoubleBuffered = true;
            Name = "RiwayatTransaksiUSER";
            Size = new Size(1538, 832);
            Load += Riwayat_transaksi_USER_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksiUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRiwayatTransaksiUser;
        private Label lblTotalTransaksiUser;
        private Label lblSudahLunas;
        private Label lblBelumLunas;
    }
}
