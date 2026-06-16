namespace project_smt2.Views
{
    partial class Riwayat_transaksi_USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat_transaksi_USER));
            dgvRiwayatTransaksiUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksiUser).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayatTransaksiUser
            // 
            dgvRiwayatTransaksiUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksiUser.Location = new Point(71, 338);
            dgvRiwayatTransaksiUser.Name = "dgvRiwayatTransaksiUser";
            dgvRiwayatTransaksiUser.RowHeadersWidth = 82;
            dgvRiwayatTransaksiUser.Size = new Size(1395, 472);
            dgvRiwayatTransaksiUser.TabIndex = 0;
            // 
            // Riwayat_transaksi_USER
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(dgvRiwayatTransaksiUser);
            DoubleBuffered = true;
            Name = "Riwayat_transaksi_USER";
            Size = new Size(1538, 832);
            Load += Riwayat_transaksi_USER_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksiUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRiwayatTransaksiUser;
    }
}
