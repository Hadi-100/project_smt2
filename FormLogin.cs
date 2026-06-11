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

        //private void FormLogin_Load(object sender, EventArgs e)
        //{

        //}

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
                //LoginUserForm frm = new LoginUserForm();
                //this.Hide();
            }

            else
            {
                MessageBox.Show("Login Gagal");
            }
        }

        private void btnRegist_Click_1(object sender, EventArgs e)
        {
            pnlRegist.Show();
        }

        private void btnRegBack_Click(object sender, EventArgs e)
        {
            pnlRegist.Hide();
        }

        private void btnRegConfirm_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
