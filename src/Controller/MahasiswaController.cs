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
    public class MahasiswaController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private MahasiswaRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data mahasiswa berdasarkan npm
        /// </summary>
        /// <param name="npm">Diisi dengan npm mahaisswa</param>
        /// <returns>Mengembalikan objek mahasiswa</returns>
        public Mahasiswa GetByNpm(string npm)
        {
            // deklarasi objek mahasiswa
            Mahasiswa mhs = null;

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                _repository = new MahasiswaRepository(context);
                mhs = _repository.GetByNpm(npm);
            }

            return mhs;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan pencarian nama
        /// </summary>
        /// <param name="nama">Diisi dengan nama mahasiswa yang mau di cari</param>
        /// <returns>Mengembalikan objek collection mahasiswa</returns>
        public List<Mahasiswa> GetByNama(string nama)
        {
            // membuat objek collection
            var list = new List<Mahasiswa>();

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MahasiswaRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.GetByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data mahasiwa
        /// </summary>
        /// <returns>Mengembalikan objek collection mahasiswa</returns>
        public List<Mahasiswa> GetAll()
        {
            // membuat objek collection
            var list = new List<Mahasiswa>();

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MahasiswaRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.GetAll();
            }

            return list;
        }

        /// <summary>
        /// Method untuk menambahkan data mahasiswa ke database
        /// </summary>
        /// <param name="obj">Objek dari class Mahasiswa</param>
        /// <returns>Mengembalikan nilai 1 jika berhasil, selain itu 0</returns>
        public int Save(Mahasiswa obj)
        {
            var result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.npm))
            {
                MessageBox.Show("NPM harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MahasiswaRepository(context);

                // panggil method Save yang ada di dalam class repository
                result = _repository.Save(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Peringatan", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        /// <summary>
        /// Method untuk menyimpan perubahan data mahasiswa ke database
        /// </summary>
        /// <param name="obj">Objek dari class Mahasiswa</param>
        /// <returns>Mengembalikan nilai 1 jika berhasil, selain itu 0</returns>
        public int Update(Mahasiswa obj)
        {
            var result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.npm))
            {
                MessageBox.Show("NPM harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MahasiswaRepository(context);

                // panggil method Update yang ada di dalam class repository
                result = _repository.Update(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        /// <summary>
        /// Method untuk menghapus data mahasiswa dari database
        /// </summary>
        /// <param name="obj">Objek dari class Mahasiswa</param>
        /// <returns>Mengembalikan nilai 1 jika berhasil, selain itu 0</returns>
        public int Delete(Mahasiswa obj)
        {
            var result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.npm))
            {
                MessageBox.Show("NPM harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MahasiswaRepository(context);

                // panggil method Delete yang ada di dalam class repository
                result = _repository.Delete(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
