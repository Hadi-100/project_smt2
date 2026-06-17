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
            ((System.ComponentModel.ISupportInitialize)dgvDistribusiHewan).BeginInit();
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
            dgvDistribusiHewan.Location = new Point(53, 233);
            dgvDistribusiHewan.Name = "dgvDistribusiHewan";
            dgvDistribusiHewan.RowHeadersWidth = 51;
            dgvDistribusiHewan.Size = new Size(1436, 536);
            dgvDistribusiHewan.TabIndex = 3;
            // 
            // DistribusiHewanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Halaman_Distribusi_Hewan_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(dgvDistribusiHewan);
            Controls.Add(lbDistribusi);
            Controls.Add(lbProses);
            Controls.Add(lbTerkirim);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "DistribusiHewanForm";
            Size = new Size(1600, 1020);
            ((System.ComponentModel.ISupportInitialize)dgvDistribusiHewan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTerkirim;
        private Label lbProses;
        private Label lbDistribusi;
        private DataGridView dgvDistribusiHewan;
    }
}
