namespace project_smt2.Views
{
    partial class ListHewanQurban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListHewanQurban));
            dgvListHewanQurban = new DataGridView();
            btnKembali = new Button();
            label1 = new Label();
            lblBerat = new Label();
            lblHarga = new Label();
            cbBerat = new ComboBox();
            cbHarga = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListHewanQurban).BeginInit();
            SuspendLayout();
            // 
            // dgvListHewanQurban
            // 
            dgvListHewanQurban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListHewanQurban.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListHewanQurban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListHewanQurban.Location = new Point(485, 161);
            dgvListHewanQurban.Name = "dgvListHewanQurban";
            dgvListHewanQurban.RowHeadersWidth = 51;
            dgvListHewanQurban.Size = new Size(870, 475);
            dgvListHewanQurban.TabIndex = 0;
            dgvListHewanQurban.CellContentClick += dgvListHewanQurban_CellContentClick;
            // 
            // btnKembali
            // 
            btnKembali.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKembali.BackColor = Color.Silver;
            btnKembali.BackgroundImageLayout = ImageLayout.Stretch;
            btnKembali.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.WhiteSmoke;
            btnKembali.Location = new Point(1080, 703);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(118, 80);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            cbBerat.SelectedIndexChanged += cbBerat_SelectedIndexChanged;
            cbHarga.SelectedIndexChanged += cbHarga_SelectedIndexChanged;
            btnKembali.Click += btnKembali_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 198);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Filter Qurban";
            // 
            // lblBerat
            // 
            lblBerat.AutoSize = true;
            lblBerat.Location = new Point(250, 291);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(44, 20);
            lblBerat.TabIndex = 3;
            lblBerat.Text = "Berat";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(250, 445);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(50, 20);
            lblHarga.TabIndex = 4;
            lblHarga.Text = "Harga";
            // 
            // cbBerat
            // 
            cbBerat.FormattingEnabled = true;
            cbBerat.Location = new Point(225, 327);
            cbBerat.Name = "cbBerat";
            cbBerat.Size = new Size(151, 28);
            cbBerat.TabIndex = 5;
            // 
            // cbHarga
            // 
            cbHarga.FormattingEnabled = true;
            cbHarga.Location = new Point(225, 483);
            cbHarga.Name = "cbHarga";
            cbHarga.Size = new Size(151, 28);
            cbHarga.TabIndex = 6;
            // 
            // ListHewanQurban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(cbHarga);
            Controls.Add(cbBerat);
            Controls.Add(lblHarga);
            Controls.Add(lblBerat);
            Controls.Add(label1);
            Controls.Add(btnKembali);
            Controls.Add(dgvListHewanQurban);
            DoubleBuffered = true;
            Name = "ListHewanQurban";
            Size = new Size(1538, 988);
            ((System.ComponentModel.ISupportInitialize)dgvListHewanQurban).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListHewanQurban;
        private Button btnKembali;
        private Label label1;
        private Label lblBerat;
        private Label lblHarga;
        private ComboBox cbBerat;
        private ComboBox cbHarga;
    }
}
