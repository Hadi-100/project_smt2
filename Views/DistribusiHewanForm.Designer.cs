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
            dgvDistribusiHewan.Location = new Point(65, 255);
            dgvDistribusiHewan.Name = "dgvDistribusiHewan";
            dgvDistribusiHewan.RowHeadersWidth = 51;
            dgvDistribusiHewan.Size = new Size(1416, 525);
            dgvDistribusiHewan.TabIndex = 0;
            // 
            // lblTerkirim
            // 
            lblTerkirim.AutoSize = true;
            lblTerkirim.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTerkirim.Location = new Point(134, 869);
            lblTerkirim.Name = "lblTerkirim";
            lblTerkirim.Size = new Size(100, 35);
            lblTerkirim.TabIndex = 1;
            lblTerkirim.Text = "label1";
            lblTerkirim.Click += label1_Click;
            // 
            // lblProses
            // 
            lblProses.AutoSize = true;
            lblProses.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProses.Location = new Point(445, 869);
            lblProses.Name = "lblProses";
            lblProses.Size = new Size(100, 35);
            lblProses.TabIndex = 2;
            lblProses.Text = "label2";
            // 
            // lblDistribusi
            // 
            lblDistribusi.AutoSize = true;
            lblDistribusi.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistribusi.Location = new Point(749, 869);
            lblDistribusi.Name = "lblDistribusi";
            lblDistribusi.Size = new Size(100, 35);
            lblDistribusi.TabIndex = 3;
            lblDistribusi.Text = "label3";
            lblDistribusi.Click += lblDistribusi_Click;
            // 
            // DistribusiHewanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblDistribusi);
            Controls.Add(lblProses);
            Controls.Add(lblTerkirim);
            Controls.Add(dgvDistribusiHewan);
            DoubleBuffered = true;
            Margin = new Padding(2);
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
