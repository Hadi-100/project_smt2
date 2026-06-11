namespace project_smt2
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbMasukEmail = new TextBox();
            tbMasukPass = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // tbMasukEmail
            // 
            tbMasukEmail.BackColor = SystemColors.Window;
            tbMasukEmail.BorderStyle = BorderStyle.None;
            tbMasukEmail.Font = new Font("Arial", 7.25F);
            tbMasukEmail.ForeColor = Color.Gray;
            tbMasukEmail.Location = new Point(715, 260);
            tbMasukEmail.Name = "tbMasukEmail";
            tbMasukEmail.Size = new Size(312, 14);
            tbMasukEmail.TabIndex = 0;
            tbMasukEmail.Text = "Masukkan Email";
            // 
            // tbMasukPass
            // 
            tbMasukPass.BackColor = SystemColors.Window;
            tbMasukPass.BorderStyle = BorderStyle.None;
            tbMasukPass.Font = new Font("Arial", 7.25F);
            tbMasukPass.ForeColor = Color.Gray;
            tbMasukPass.Location = new Point(715, 361);
            tbMasukPass.Name = "tbMasukPass";
            tbMasukPass.Size = new Size(312, 14);
            tbMasukPass.TabIndex = 1;
            tbMasukPass.Text = "Masukkan Password";
            tbMasukPass.TextChanged += textBox1_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = Properties.Resources.Tombol_Login;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(794, 425);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 29);
            btnLogin.TabIndex = 2;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BackgroundImage = Properties.Resources.Tombol_Register;
            btnRegister.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Location = new Point(794, 481);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(132, 33);
            btnRegister.TabIndex = 3;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Halaman_Login__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 590);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(tbMasukPass);
            Controls.Add(tbMasukEmail);
            DoubleBuffered = true;
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMasukEmail;
        private TextBox tbMasukPass;
        private Button btnLogin;
        private Button btnRegister;
    }
}