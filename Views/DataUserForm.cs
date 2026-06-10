using project_smt2.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Views
{
    public partial class DataUserForm : Form
    {
        private void DataUserForm_Load(
            object sender,
            EventArgs e)
        {
            UserController controller =
                new UserController();

            dgvUser.DataSource =
                controller.GetUsers();
        }
    }
}
