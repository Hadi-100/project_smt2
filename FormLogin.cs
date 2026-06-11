using Microsoft.VisualBasic.ApplicationServices;
using project_smt2.Controllers;
using project_smt2.Models;
using project_smt2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace project_smt2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            PanellHelper.MakeButtonRounded(btnLogin, 10);
            PanellHelper.MakeButtonRounded(btnRegist, 10);
            PanellHelper.MakeButtonRounded(btnRegConfirm, 10);
            PanellHelper.MakeButtonRounded(btnRegBack, 10);
            new AutoScaleHelper(this);
            pnlRegist.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
       
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMasukEmail.Text))
            {
                MessageBox.Show("Email harus diisi!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbMasukPass.Text))
            {
                MessageBox.Show("Password harus diisi!");
                return;
            }

            LoginController controller = new LoginController();

            string role = controller.Login(
                tbMasukEmail.Text,
                tbMasukPass.Text
            );

            if (role == "admin")
            {
                DashboardAdminForm frmAdmin =
                    new DashboardAdminForm();

                frmAdmin.Show();
                this.Hide();
            }
            else if (role == "user")
            {
                DashboardUserForm frmUser =
                    new DashboardUserForm();

                frmUser.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Email atau Password salah!",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnRegist_Click_1(object sender, EventArgs e)
        {
            ResetFromLogin();
            pnlRegist.Show();
        }

        private void ResetFromLogin()
        {
            tbMasukEmail.Text = "Masukkan Email";
            tbMasukPass.Text = "Masukkan Password";

        }

        private void ResetFormRegister()
        {
            tbRegUsn.Text = "Masukkan Username";
            tbRegTelp.Text = "Masukkan No. Hp";
            tbRegEmail.Text = "Masukkan Email";
            tbRegPass.Text = "Masukkan Password";
        }

        private void btnRegBack_Click(object sender, EventArgs e)
        {
            ResetFormRegister();
            pnlRegist.Hide();
        }

        private void btnRegConfirm_Click(object sender, EventArgs e)
        {
            string pesan = "";

            string noTelp = tbRegTelp.Text;
            string email = tbRegEmail.Text;

            //bool telp_kosong = noTelp == "" || noTelp == "masukkan no. telp";
            bool email_kosong = email == "" || email == "masukkan email";

            //if (telp_kosong)
            //{
            //    pesan += "• Nomor telepon harus diisi\n";
            //}
            //else if (noTelp.Length < 11)
            //{
            //    pesan += "• Nomor telepon terlalu pendek\n";
            //}
            //else if (noTelp.Length > 15)
            //{
            //    pesan += "• Nomor telepon terlalu panjang\n";
            //}

            if (email_kosong)
            {
                pesan += "• Email harus diisi\n";
            }
            else if (!email.Contains("@"))
            {
                pesan += "• Masukkan alamat email yang sesuai\n";
            }

            if (tbRegUsn.Text.Trim() == "" || tbRegUsn.Text.Trim() == "masukkan username")
                pesan += "• Username harus diisi\n";

            if (tbRegPass.Text.Trim() == "" || tbRegPass.Text.Trim() == "masukkan password")
                pesan += "• Password harus diisi\n";

            if (pesan != "")
            {
                MessageBox.Show(
                    "Registrasi Gagal!\n\n" + pesan,
                    "Gagal Registrasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Models.User user = new Models.User(
                0,
                tbRegUsn.Text,
                tbRegEmail.Text,
                tbRegTelp.Text,
                tbRegPass.Text,
                "user'"
                );

            UserController controller = new UserController();
            controller.Register(user);

            MessageBox.Show("Registrasi berhasil!");

            ResetFormRegister();
            pnlRegist.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void tbRegTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRegEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
