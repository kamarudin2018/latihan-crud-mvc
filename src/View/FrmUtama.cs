using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanCRUDMVC.View
{
    public partial class FrmUtama : Form
    {
        private FrmMahasiswa _frmMahasiswa;

        public FrmUtama()
        {
            InitializeComponent();

            sbLogin.Text = string.Format("Operator: {0}", Program.userName);
        }

        private bool IsFormExists(string namaForm)
        {
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name.ToLower() == namaForm.ToLower()) return true;
            }

            return false;
        }

        private void ShowForm(Form frm, string namaForm)
        {
            frm.Name = namaForm;
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnuMahasiswa_Click(object sender, EventArgs e)
        {
            if (!IsFormExists("FrmMahasiswa"))
            {
                _frmMahasiswa = new FrmMahasiswa();
                ShowForm(_frmMahasiswa, "FrmMahasiswa");
            }
            else
                _frmMahasiswa.Activate();
        }

        private void mnuBuku_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Untuk menu buku silahkan dilengkapi !!!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuProfil_Click(object sender, EventArgs e)
        {
            var frmProfil = new FrmProfil();
            frmProfil.ShowDialog();
        }
    }
}
