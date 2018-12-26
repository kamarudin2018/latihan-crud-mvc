using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LatihanCRUDMVC.Controller;
using LatihanCRUDMVC.Model.Entity;

namespace LatihanCRUDMVC.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // buat objek controller
            var controller = new LoginAplikasiController();

            // cek user valid atau tidak
            var IsValidUser = controller.IsValidUser(txtUserName.Text, txtPassword.Text);

            if (IsValidUser) // user valid, tutup form login
            {
                Program.userName = txtUserName.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
