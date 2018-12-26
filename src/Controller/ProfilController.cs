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
    public class ProfilController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private ProfilRepository _repository;

        public Profil GetProfil()
        {
            // deklarasi objek profil
            Profil profil = null;

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                _repository = new ProfilRepository(context);
                profil = _repository.GetProfil();
            }

            return profil;
        }

        public int Save(Profil obj)
        {
            var result = 0;

            // cek nilai profil yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.profil))
            {
                MessageBox.Show("Profil harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai alamat yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ProfilRepository(context);

                // panggil method Save yang ada di dalam class repository
                result = _repository.Save(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data profil berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data profil gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        /// <summary>
        /// Method untuk menyimpan perubahan data profil ke database
        /// </summary>
        /// <param name="obj">Objek dari class Profil</param>
        /// <returns>Mengembalikan nilai 1 jika berhasil, selain itu 0</returns>
        public int Update(Profil obj)
        {
            var result = 0;

            // cek nilai profil yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.profil))
            {
                MessageBox.Show("Profil harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai alamat yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ProfilRepository(context);

                // panggil method Update yang ada di dalam class repository
                result = _repository.Update(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data profil berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data profil gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
