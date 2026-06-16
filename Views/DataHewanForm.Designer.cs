namespace project_smt2.Views
{
    partial class DataHewanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataHewanForm));
            lblhewantersedia = new Label();
            lbltotalsapi = new Label();
            lbltotalkambing = new Label();
            lblhewanterjual = new Label();
            btnTambah = new Button();
            dgvDataHewan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDataHewan).BeginInit();
            SuspendLayout();
            // 
            // lblhewantersedia
            // 
            lblhewantersedia.AutoSize = true;
            lblhewantersedia.BackColor = Color.Transparent;
            lblhewantersedia.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhewantersedia.Location = new Point(288, 464);
            lblhewantersedia.Name = "lblhewantersedia";
            lblhewantersedia.Size = new Size(64, 46);
            lblhewantersedia.TabIndex = 1;
            lblhewantersedia.Text = "10";
            lblhewantersedia.Click += label1_Click;
            // 
            // lbltotalsapi
            // 
            lbltotalsapi.AutoSize = true;
            lbltotalsapi.BackColor = Color.Transparent;
            lbltotalsapi.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalsapi.Location = new Point(754, 462);
            lbltotalsapi.Name = "lbltotalsapi";
            lbltotalsapi.Size = new Size(64, 46);
            lbltotalsapi.TabIndex = 2;
            lbltotalsapi.Text = "10";
            lbltotalsapi.Click += lbltotalsapi_Click;
            // 
            // lbltotalkambing
            // 
            lbltotalkambing.AutoSize = true;
            lbltotalkambing.BackColor = Color.Transparent;
            lbltotalkambing.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalkambing.Location = new Point(1232, 462);
            lbltotalkambing.Name = "lbltotalkambing";
            lbltotalkambing.Size = new Size(64, 46);
            lbltotalkambing.TabIndex = 3;
            lbltotalkambing.Text = "10";
            lbltotalkambing.Click += label1_Click_1;
            // 
            // lblhewanterjual
            // 
            lblhewanterjual.AutoSize = true;
            lblhewanterjual.BackColor = Color.Transparent;
            lblhewanterjual.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhewanterjual.Location = new Point(1698, 462);
            lblhewanterjual.Name = "lblhewanterjual";
            lblhewanterjual.Size = new Size(64, 46);
            lblhewanterjual.TabIndex = 4;
            lblhewanterjual.Text = "10";
            lblhewanterjual.Click += lblhewanterjual_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Green;
            btnTambah.BackgroundImageLayout = ImageLayout.Stretch;
            btnTambah.FlatStyle = FlatStyle.Popup;
            btnTambah.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.WhiteSmoke;
            btnTambah.Location = new Point(2082, 459);
            btnTambah.Margin = new Padding(5, 5, 5, 5);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(239, 118);
            btnTambah.TabIndex = 5;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // dgvDataHewan
            // 
            dgvDataHewan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataHewan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataHewan.Location = new Point(124, 627);
            dgvDataHewan.Margin = new Padding(5, 5, 5, 11);
            dgvDataHewan.Name = "dgvDataHewan";
            dgvDataHewan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDataHewan.Size = new Size(2192, 866);
            dgvDataHewan.TabIndex = 6;
            dgvDataHewan.CellContentClick += dgvDataHewan_CellContentClick;
            // 
            // DataHewanForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(dgvDataHewan);
            Controls.Add(btnTambah);
            Controls.Add(lblhewanterjual);
            Controls.Add(lbltotalkambing);
            Controls.Add(lbltotalsapi);
            Controls.Add(lblhewantersedia);
            DoubleBuffered = true;
            Name = "DataHewanForm";
            Size = new Size(2600, 1632);
            Load += DataHewanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataHewan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblhewantersedia;
        private Label lbltotalsapi;
        private Label lbltotalkambing;
        private Label lblhewanterjual;
        private Button btnTambah;
        private DataGridView dgvDataHewan;
    }
}
