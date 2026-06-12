using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_smt2
{
    public partial class Tambah_hewan_ternak : UserControl
    {
        public Tambah_hewan_ternak()
        {
            InitializeComponent();
            cbxJenisHewan.Size = new Size(521, 60);
        }

        private void cbxJenisHewan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

