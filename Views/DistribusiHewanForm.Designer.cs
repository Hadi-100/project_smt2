namespace project_smt2.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistribusiHewanForm));
            dgvDistribusiHewan = new DataGridView();
            lblTerkirim = new Label();
            lblProses = new Label();
            lblDistribusi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDistribusiHewan).BeginInit();
            SuspendLayout();
            // 
            // dgvDistribusiHewan
            // 
            dgvDistribusiHewan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistribusiHewan.Location = new Point(55, 253);
            dgvDistribusiHewan.Margin = new Padding(5, 5, 5, 5);
            dgvDistribusiHewan.Name = "dgvDistribusiHewan";
            dgvDistribusiHewan.RowHeadersWidth = 51;
            dgvDistribusiHewan.Size = new Size(1432, 526);
            dgvDistribusiHewan.TabIndex = 0;
            // 
            // lblTerkirim
            // 
            lblTerkirim.AutoSize = true;
            lblTerkirim.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTerkirim.Location = new Point(218, 1390);
            lblTerkirim.Margin = new Padding(5, 0, 5, 0);
            lblTerkirim.Name = "lblTerkirim";
            lblTerkirim.Size = new Size(160, 56);
            lblTerkirim.TabIndex = 1;
            lblTerkirim.Text = "label1";
            lblTerkirim.Click += label1_Click;
            // 
            // lblProses
            // 
            lblProses.AutoSize = true;
            lblProses.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProses.Location = new Point(723, 1390);
            lblProses.Margin = new Padding(5, 0, 5, 0);
            lblProses.Name = "lblProses";
            lblProses.Size = new Size(160, 56);
            lblProses.TabIndex = 2;
            lblProses.Text = "label2";
            // 
            // lblDistribusi
            // 
            lblDistribusi.AutoSize = true;
            lblDistribusi.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistribusi.Location = new Point(1217, 1390);
            lblDistribusi.Margin = new Padding(5, 0, 5, 0);
            lblDistribusi.Name = "lblDistribusi";
            lblDistribusi.Size = new Size(160, 56);
            lblDistribusi.TabIndex = 3;
            lblDistribusi.Text = "label3";
            lblDistribusi.Click += lblDistribusi_Click;
            // 
            // DistribusiHewanForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblDistribusi);
            Controls.Add(lblProses);
            Controls.Add(lblTerkirim);
            Controls.Add(dgvDistribusiHewan);
            DoubleBuffered = true;
            Name = "DistribusiHewanForm";
            Size = new Size(1600, 1020);
            Load += DistribusiHewanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDistribusiHewan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDistribusiHewan;
        private Label lblTerkirim;
        private Label lblProses;
        private Label lblDistribusi;
    }
}
