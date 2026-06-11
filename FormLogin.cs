using project_smt2.Controllers;
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
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

            LoginController controller =
        new LoginController();

            string role =
                controller.Login(
                    tbMasukEmail.Text,
                    tbMasukPass.Text
                );

            if (role == "admin")
            {
                DashboardAdminForm frm =
                    new DashboardAdminForm();

                frm.Show();
                this.Hide();
            }

            else if (role == "user")
            {
                DashboardUserForm frm = 
                    new DashboardUserForm();
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Login Gagal");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
