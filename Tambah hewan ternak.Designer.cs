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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // cbxJenisHewan
            // 
            cbxJenisHewan.Font = new Font("Arial", 22.5F);
            cbxJenisHewan.FormattingEnabled = true;
            cbxJenisHewan.Items.AddRange(new object[] { "Sapi", "Kambing", "Sapi Limousin", "Kambing Khas Ngawi", "Sapi Mas Hambali" });
            cbxJenisHewan.Location = new Point(160, 307);
            cbxJenisHewan.Name = "cbxJenisHewan";
            cbxJenisHewan.Size = new Size(521, 50);
            cbxJenisHewan.TabIndex = 0;
            cbxJenisHewan.Text = "Jenis Hewan";
            cbxJenisHewan.SelectedIndexChanged += cbxJenisHewan_SelectedIndexChanged;
            // 
            // cbxJenisKelamin
            // 
            cbxJenisKelamin.Font = new Font("Arial", 22.5F);
            cbxJenisKelamin.FormattingEnabled = true;
            cbxJenisKelamin.Items.AddRange(new object[] { "Jantan", "Betina" });
            cbxJenisKelamin.Location = new Point(160, 407);
            cbxJenisKelamin.Name = "cbxJenisKelamin";
            cbxJenisKelamin.Size = new Size(521, 50);
            cbxJenisKelamin.TabIndex = 1;
            cbxJenisKelamin.Text = "Jenis Kelamin";
            // 
            // tbUmur
            // 
            tbUmur.Font = new Font("Arial", 22.5F);
            tbUmur.Location = new Point(160, 689);
            tbUmur.Name = "tbUmur";
            tbUmur.Size = new Size(521, 51);
            tbUmur.TabIndex = 2;
            tbUmur.Text = "Umur";
            // 
            // tbHarga
            // 
            tbHarga.Font = new Font("Arial", 22.5F);
            tbHarga.Location = new Point(160, 598);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(521, 51);
            tbHarga.TabIndex = 3;
            tbHarga.Text = "Harga";
            // 
            // tbBerat
            // 
            tbBerat.Font = new Font("Arial", 22.2F);
            tbBerat.Location = new Point(160, 497);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(521, 50);
            tbBerat.TabIndex = 4;
            tbBerat.Text = "Berat (KG)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 22.5F);
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 22.2F);
            dateTimePicker1.Location = new Point(759, 308);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(518, 49);
            dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 22.5F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sehat", "Sakit" });
            comboBox1.Location = new Point(759, 408);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(518, 50);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Kondisi Fisik";
            // 
            // Tambah_hewan_ternak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}
