using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using LatihanCRUDMVC.Model.Entity;
using LatihanCRUDMVC.Model.Repository;
using LatihanCRUDMVC.Model.Context;

namespace LatihanCRUDMVC.Controller
{
    public class LoginAplikasiController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private LoginAplikasiRepository _repository;

        /// <summary>
        /// Method untuk mengecek user yang login valid atau tidak
        /// </summary>
        /// <param name="userName">Diisi dengan username</param>
        /// <param name="password">Diisi dengan password</param>
        /// <returns>Mengembalikan nilai true jika user dan password benar, selain itu false</returns>
        public bool IsValidUser(string userName, string password)
        {
            var result = false;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // cek nilai nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new LoginAplikasiRepository(context);

                // panggil method IsValidUser yang ada di dalam class repository
                result = _repository.IsValidUser(userName, password);
            }

            if (result == false) // username atau password salah
            {
                MessageBox.Show("User name atau password salah !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
    }
}
