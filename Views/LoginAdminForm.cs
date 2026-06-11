using project_smt2.Controllers;
using project_smt2.Views;
using System;
using System.Collections.Generic;
using System.Text;


//public void btnLogin_Click(object sender, EventArgs e)
//{
//    LoginController controller =
//        new LoginController();

//    string role =
//        controller.Login(
//            //tbMasukEmail.Text,
//            //tbMasukPass.Text
//        );

//    if (role == "admin")
//    {
//        DashboardAdminForm frm =
//            new DashboardAdminForm();

        frm.Show();
        this.Hide();
    }

    else if (role == "user")
    {
        DashboardUserForm frm =
            new DashboardUserForm();

        frm.show();
        this.Hide();
    }

    else
    {
        MessageBox.Show("Login Admin Gagal");
    }
}