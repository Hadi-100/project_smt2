using project_smt2.Controllers;
using project_smt2.Views;
using System;
using System.Collections.Generic;
using System.Text;


private void btnLogin_Click(object sender, EventArgs e)
{
    LoginController controller =
        new LoginController();

    string role =
        controller.Login(
            txtEmail.Text,
            txtPassword.Text
        );

    if (role == "admin")
    {
        DashboardAdminForm frm =
            new DashboardAdminForm();

        frm.Show();
        this.Hide();
    }
    else
    {
        MessageBox.Show("Login Admin Gagal");
    }
}