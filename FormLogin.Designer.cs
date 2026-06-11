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
            Panel pnlLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnRegist = new Button();
            btnLogin = new Button();
            tbMasukPass = new TextBox();
            tbMasukEmail = new TextBox();
            pnlRegist = new Panel();
            tbRegPass = new TextBox();
            tbRegTelp = new TextBox();
            btnRegBack = new Button();
            tbRegUsn = new TextBox();
            tbRegEmail = new TextBox();
            btnRegConfirm = new Button();
            pnlLogin = new Panel();
            pnlLogin.SuspendLayout();
            pnlRegist.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackgroundImage = (Image)resources.GetObject("pnlLogin.BackgroundImage");
            pnlLogin.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLogin.Controls.Add(btnRegist);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(tbMasukPass);
            pnlLogin.Controls.Add(tbMasukEmail);
            pnlLogin.Location = new Point(1176, 0);
            pnlLogin.Margin = new Padding(5);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(723, 1030);
            pnlLogin.TabIndex = 0;
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.White;
            btnRegist.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.ForeColor = SystemColors.AppWorkspace;
            btnRegist.Location = new Point(229, 840);
            btnRegist.Margin = new Padding(5);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(247, 61);
            btnRegist.TabIndex = 2;
            btnRegist.Text = "Register";
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(229, 739);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(247, 61);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // tbMasukPass
            // 
            tbMasukPass.BorderStyle = BorderStyle.None;
            tbMasukPass.Location = new Point(86, 627);
            tbMasukPass.Margin = new Padding(5);
            tbMasukPass.Name = "tbMasukPass";
            tbMasukPass.Size = new Size(566, 32);
            tbMasukPass.TabIndex = 1;
            tbMasukPass.Text = "Masukkan Password";
            // 
            // tbMasukEmail
            // 
            tbMasukEmail.BorderStyle = BorderStyle.None;
            tbMasukEmail.Location = new Point(86, 448);
            tbMasukEmail.Margin = new Padding(5);
            tbMasukEmail.Name = "tbMasukEmail";
            tbMasukEmail.Size = new Size(566, 32);
            tbMasukEmail.TabIndex = 0;
            tbMasukEmail.Text = "Masukkan Email";
            // 
            // pnlRegist
            // 
            pnlRegist.BackgroundImage = (Image)resources.GetObject("pnlRegist.BackgroundImage");
            pnlRegist.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRegist.Controls.Add(tbRegPass);
            pnlRegist.Controls.Add(tbRegTelp);
            pnlRegist.Controls.Add(btnRegBack);
            pnlRegist.Controls.Add(tbRegUsn);
            pnlRegist.Controls.Add(tbRegEmail);
            pnlRegist.Controls.Add(btnRegConfirm);
            pnlRegist.ForeColor = SystemColors.ButtonHighlight;
            pnlRegist.Location = new Point(1176, 0);
            pnlRegist.Margin = new Padding(5);
            pnlRegist.Name = "pnlRegist";
            pnlRegist.Size = new Size(723, 1030);
            pnlRegist.TabIndex = 3;
            // 
            // tbRegPass
            // 
            tbRegPass.BorderStyle = BorderStyle.None;
            tbRegPass.Location = new Point(86, 621);
            tbRegPass.Margin = new Padding(5);
            tbRegPass.Name = "tbRegPass";
            tbRegPass.Size = new Size(566, 32);
            tbRegPass.TabIndex = 5;
            tbRegPass.Text = "Masukkan Password";
            // 
            // tbRegTelp
            // 
            tbRegTelp.BorderStyle = BorderStyle.None;
            tbRegTelp.Location = new Point(86, 373);
            tbRegTelp.Margin = new Padding(5);
            tbRegTelp.Name = "tbRegTelp";
            tbRegTelp.Size = new Size(566, 32);
            tbRegTelp.TabIndex = 3;
            tbRegTelp.Text = "Masukkan No Hp";
            tbRegTelp.TextChanged += tbRegTelp_TextChanged;
            // 
            // btnRegBack
            // 
            btnRegBack.BackColor = Color.White;
            btnRegBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegBack.FlatStyle = FlatStyle.Flat;
            btnRegBack.ForeColor = Color.DimGray;
            btnRegBack.Location = new Point(229, 840);
            btnRegBack.Margin = new Padding(5);
            btnRegBack.Name = "btnRegBack";
            btnRegBack.Size = new Size(247, 61);
            btnRegBack.TabIndex = 2;
            btnRegBack.Text = "Back";
            btnRegBack.UseVisualStyleBackColor = false;
            btnRegBack.Click += btnRegBack_Click;
            // 
            // tbRegUsn
            // 
            tbRegUsn.BorderStyle = BorderStyle.None;
            tbRegUsn.Location = new Point(86, 246);
            tbRegUsn.Margin = new Padding(5);
            tbRegUsn.Name = "tbRegUsn";
            tbRegUsn.Size = new Size(566, 32);
            tbRegUsn.TabIndex = 0;
            tbRegUsn.Text = "Masukkan Username";
            // 
            // tbRegEmail
            // 
            tbRegEmail.BorderStyle = BorderStyle.None;
            tbRegEmail.Location = new Point(86, 500);
            tbRegEmail.Margin = new Padding(5);
            tbRegEmail.Name = "tbRegEmail";
            tbRegEmail.Size = new Size(566, 32);
            tbRegEmail.TabIndex = 4;
            tbRegEmail.Text = "Masukkan Email";
            tbRegEmail.TextChanged += tbRegEmail_TextChanged;
            // 
            // btnRegConfirm
            // 
            btnRegConfirm.BackColor = Color.Green;
            btnRegConfirm.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegConfirm.FlatStyle = FlatStyle.Popup;
            btnRegConfirm.Font = new Font("Microsoft Sans Serif", 9F);
            btnRegConfirm.ForeColor = Color.WhiteSmoke;
            btnRegConfirm.Location = new Point(229, 739);
            btnRegConfirm.Margin = new Padding(5);
            btnRegConfirm.Name = "btnRegConfirm";
            btnRegConfirm.Size = new Size(247, 61);
            btnRegConfirm.TabIndex = 1;
            btnRegConfirm.Text = "Confirm";
            btnRegConfirm.UseVisualStyleBackColor = false;
            btnRegConfirm.Click += btnRegConfirm_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1898, 1029);
            Controls.Add(pnlRegist);
            Controls.Add(pnlLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FormLogin";
            Text = "FormLogin";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load_1;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRegist.ResumeLayout(false);
            pnlRegist.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private TextBox tbMasukEmail;
        private TextBox tbMasukPass;
        private Button btnLogin;
        private Button btnRegist;
        private Panel pnlRegist;
        private Button btnRegBack;
        private Button btnRegConfirm;
        private TextBox tbRegUsn;
        private TextBox tbRegEmail;
        private TextBox tbRegTelp;
        private TextBox tbRegPass;
    }
}