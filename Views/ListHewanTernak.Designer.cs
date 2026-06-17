namespace project_smt2.Views
{
    partial class ListHewanTernak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListHewanTernak));
            dgvListHewanTernak = new DataGridView();
            btnKembali = new Button();
            btnBeli = new Button();
            lblFilter = new Label();
            lblJenisHewan = new Label();
            lblJenisKelamin = new Label();
            cbJenisHewan = new ComboBox();
            cbJenisKelamin = new ComboBox();
            lblUmur = new Label();
            cbUmur = new ComboBox();
            lblBerat = new Label();
            cbBerat = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListHewanTernak).BeginInit();
            SuspendLayout();
            // 
            // dgvListHewanTernak
            // 
            dgvListHewanTernak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListHewanTernak.Location = new Point(485, 158);
            dgvListHewanTernak.Name = "dgvListHewanTernak";
            dgvListHewanTernak.RowHeadersWidth = 51;
            dgvListHewanTernak.Size = new Size(870, 497);
            dgvListHewanTernak.TabIndex = 0;
            dgvListHewanTernak.CellContentClick += dgvListHewanTernak_CellContentClick;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Silver;
            btnKembali.FlatStyle = FlatStyle.Popup;
            btnKembali.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.WhiteSmoke;
            btnKembali.Location = new Point(1083, 697);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(117, 80);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.Green;
            btnBeli.BackgroundImageLayout = ImageLayout.Stretch;
            btnBeli.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeli.ForeColor = Color.White;
            btnBeli.Location = new Point(1238, 697);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(117, 80);
            btnBeli.TabIndex = 2;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = false;
            btnBeli.Click += btnBeli_Click;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(221, 182);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(92, 20);
            lblFilter.TabIndex = 3;
            lblFilter.Text = "Filter Hewan";
            // 
            // lblJenisHewan
            // 
            lblJenisHewan.AutoSize = true;
            lblJenisHewan.Location = new Point(223, 257);
            lblJenisHewan.Name = "lblJenisHewan";
            lblJenisHewan.Size = new Size(90, 20);
            lblJenisHewan.TabIndex = 4;
            lblJenisHewan.Text = "Jenis Hewan";
            // 
            // lblJenisKelamin
            // 
            lblJenisKelamin.AutoSize = true;
            lblJenisKelamin.Location = new Point(221, 357);
            lblJenisKelamin.Name = "lblJenisKelamin";
            lblJenisKelamin.Size = new Size(98, 20);
            lblJenisKelamin.TabIndex = 5;
            lblJenisKelamin.Text = "Jenis Kelamin";
            // 
            // cbJenisHewan
            // 
            cbJenisHewan.FormattingEnabled = true;
            cbJenisHewan.Location = new Point(230, 295);
            cbJenisHewan.Name = "cbJenisHewan";
            cbJenisHewan.Size = new Size(186, 28);
            cbJenisHewan.TabIndex = 8;
            cbJenisHewan.SelectedIndexChanged += cbJenisHewan_SelectedIndexChanged;
            // 
            // cbJenisKelamin
            // 
            cbJenisKelamin.FormattingEnabled = true;
            cbJenisKelamin.Location = new Point(230, 394);
            cbJenisKelamin.Name = "cbJenisKelamin";
            cbJenisKelamin.Size = new Size(186, 28);
            cbJenisKelamin.TabIndex = 9;
            cbJenisKelamin.SelectedIndexChanged += cbJenisKelamin_SelectedIndexChanged;
            // 
            // lblUmur
            // 
            lblUmur.AutoSize = true;
            lblUmur.Location = new Point(223, 464);
            lblUmur.Name = "lblUmur";
            lblUmur.Size = new Size(45, 20);
            lblUmur.TabIndex = 10;
            lblUmur.Text = "Umur";
            // 
            // cbUmur
            // 
            cbUmur.FormattingEnabled = true;
            cbUmur.Location = new Point(230, 498);
            cbUmur.Name = "cbUmur";
            cbUmur.Size = new Size(186, 28);
            cbUmur.TabIndex = 11;
            cbUmur.SelectedIndexChanged += cbUmur_SelectedIndexChanged;
            // 
            // lblBerat
            // 
            lblBerat.AutoSize = true;
            lblBerat.Location = new Point(223, 565);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(44, 20);
            lblBerat.TabIndex = 12;
            lblBerat.Text = "Berat";
            // 
            // cbBerat
            // 
            cbBerat.FormattingEnabled = true;
            cbBerat.Location = new Point(230, 602);
            cbBerat.Name = "cbBerat";
            cbBerat.Size = new Size(186, 28);
            cbBerat.TabIndex = 13;
            cbBerat.SelectedIndexChanged += cbBerat_SelectedIndexChanged;
            // 
            // ListHewanTernak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(cbBerat);
            Controls.Add(lblBerat);
            Controls.Add(cbUmur);
            Controls.Add(lblUmur);
            Controls.Add(cbJenisKelamin);
            Controls.Add(cbJenisHewan);
            Controls.Add(lblJenisKelamin);
            Controls.Add(lblJenisHewan);
            Controls.Add(lblFilter);
            Controls.Add(btnBeli);
            Controls.Add(btnKembali);
            Controls.Add(dgvListHewanTernak);
            DoubleBuffered = true;
            Name = "ListHewanTernak";
            Size = new Size(1538, 988);
            ((System.ComponentModel.ISupportInitialize)dgvListHewanTernak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListHewanTernak;
        private Button btnKembali;
        private Button btnBeli;
        private Label lblFilter;
        private Label lblJenisHewan;
        private Label lblJenisKelamin;
        private Label label5;
        private ComboBox cbJenisHewan;
        private ComboBox cbJenisKelamin;
        private Label lblUmur;
        private ComboBox cbUmur;
        private Label lblBerat;
        private ComboBox cbBerat;
    }
}
