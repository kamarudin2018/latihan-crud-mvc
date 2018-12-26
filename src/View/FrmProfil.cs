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
    public partial class FrmProfil : Form
    {
        // deklarasi objek controller
        private ProfilController _controller;
        private bool _addData = true;

        public FrmProfil()
        {
            InitializeComponent();

            _controller = new ProfilController();

            // cek data profil
            var profil = _controller.GetProfil();

            if (profil != null) // data profil sudah ada
            {
                _addData = false;

                txtProfil.Text = profil.profil;
                txtAlamat.Text = profil.alamat;
                txtKota.Text = profil.kota;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var profil = new Profil();
            profil.profil = txtProfil.Text;
            profil.alamat = txtAlamat.Text;
            profil.kota = txtKota.Text;

            var result = 0;

            if (_addData == true) // tambah data baru, panggil method Save
                result = _controller.Save(profil);
            else // edit data, panggil method Update
                result = _controller.Update(profil);

            if (result > 0)
                this.Close();
            
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
