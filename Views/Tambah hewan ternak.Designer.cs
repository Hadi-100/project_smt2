namespace project_smt2
{
    partial class Tambah_hewan_ternak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tambah_hewan_ternak));
            cbxJenisHewan = new ComboBox();
            cbxJenisKelamin = new ComboBox();
            tbUmur = new TextBox();
            tbHarga = new TextBox();
            tbBerat = new TextBox();
            btnTambah = new Button();
            btnBatal = new Button();
            cbxNamaPeternak = new ComboBox();
            SuspendLayout();
            // 
            // cbxJenisHewan
            // 
            cbxJenisHewan.Font = new Font("Arial", 23F);
            cbxJenisHewan.ForeColor = Color.Gray;
            cbxJenisHewan.FormattingEnabled = true;
            cbxJenisHewan.Items.AddRange(new object[] { "1 Sapi ", "2 Kambing", "3 Sapi Limousin", "4 Sapi Brahmana", "5 Kambing Kacang", "6 Kambing Etawa", "7 Kambing JawaRandu" });
            cbxJenisHewan.Location = new Point(160, 307);
            cbxJenisHewan.Name = "cbxJenisHewan";
            cbxJenisHewan.Size = new Size(521, 51);
            cbxJenisHewan.TabIndex = 0;
            cbxJenisHewan.Text = "Jenis Hewan";
            cbxJenisHewan.SelectedIndexChanged += cbxJenisHewan_SelectedIndexChanged;
            // 
            // cbxJenisKelamin
            // 
            cbxJenisKelamin.Font = new Font("Arial", 23F);
            cbxJenisKelamin.ForeColor = Color.Gray;
            cbxJenisKelamin.FormattingEnabled = true;
            cbxJenisKelamin.Items.AddRange(new object[] { "Jantan", "Betina" });
            cbxJenisKelamin.Location = new Point(160, 407);
            cbxJenisKelamin.Name = "cbxJenisKelamin";
            cbxJenisKelamin.Size = new Size(521, 51);
            cbxJenisKelamin.TabIndex = 1;
            cbxJenisKelamin.Text = "Jenis Kelamin";
            // 
            // tbUmur
            // 
            tbUmur.Font = new Font("Arial", 23F);
            tbUmur.ForeColor = Color.Black;
            tbUmur.Location = new Point(160, 687);
            tbUmur.Name = "tbUmur";
            tbUmur.Size = new Size(521, 52);
            tbUmur.TabIndex = 2;
            tbUmur.Text = "Umur";
            // 
            // tbHarga
            // 
            tbHarga.Font = new Font("Arial", 23F);
            tbHarga.ForeColor = Color.Black;
            tbHarga.Location = new Point(160, 600);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(521, 52);
            tbHarga.TabIndex = 3;
            tbHarga.Text = "Harga";
            // 
            // tbBerat
            // 
            tbBerat.Font = new Font("Arial", 23F);
            tbBerat.ForeColor = Color.Gray;
            tbBerat.Location = new Point(160, 496);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(521, 52);
            tbBerat.TabIndex = 4;
            tbBerat.Text = "Berat (KG)";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Green;
            btnTambah.BackgroundImageLayout = ImageLayout.Stretch;
            btnTambah.FlatStyle = FlatStyle.Popup;
            btnTambah.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.WhiteSmoke;
            btnTambah.Location = new Point(1203, 828);
            btnTambah.Name = "btnTambah";
            btnTambah.RightToLeft = RightToLeft.No;
            btnTambah.Size = new Size(146, 73);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Next";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Silver;
            btnBatal.BackgroundImageLayout = ImageLayout.Stretch;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.WhiteSmoke;
            btnBatal.Location = new Point(997, 833);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(146, 73);
            btnBatal.TabIndex = 8;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += button1_Click;
            // 
            // cbxNamaPeternak
            // 
            cbxNamaPeternak.Font = new Font("Arial", 23F);
            cbxNamaPeternak.ForeColor = Color.Gray;
            cbxNamaPeternak.FormattingEnabled = true;
            cbxNamaPeternak.Items.AddRange(new object[] { "1 (Pak Ali)", "2 (Bu Rina) ", "3 (Pak Budi)", "3 (Bu Sari)", "4 (Pak Joko)", "5 (Bu Maya) ", "6 (Pak Tono)" });
            cbxNamaPeternak.Location = new Point(765, 307);
            cbxNamaPeternak.Name = "cbxNamaPeternak";
            cbxNamaPeternak.Size = new Size(518, 51);
            cbxNamaPeternak.TabIndex = 9;
            cbxNamaPeternak.Text = "Peternak";
            // 
            // Tambah_hewan_ternak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(cbxNamaPeternak);
            Controls.Add(btnBatal);
            Controls.Add(btnTambah);
            Controls.Add(tbBerat);
            Controls.Add(tbHarga);
            Controls.Add(tbUmur);
            Controls.Add(cbxJenisKelamin);
            Controls.Add(cbxJenisHewan);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Tambah_hewan_ternak";
            Size = new Size(1600, 1020);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxJenisHewan;
        private ComboBox cbxJenisKelamin;
        private TextBox tbUmur;
        private TextBox tbHarga;
        private TextBox tbBerat;
        private Button btnTambah;
        private Button btnBatal;
        private ComboBox cbxNamaPeternak;
    }
}
