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
    public partial class FrmMahasiswa : Form
    {
        // deklarasi objek controller
        private MahasiswaController _controller;

        // deklarasi private variabel/field _addData
        private bool _addData;

        // constructor
        public FrmMahasiswa()
        {
            InitializeComponent();
            InisialisasiListView();

            // membuat objek controller
            _controller = new MahasiswaController();

            // tampilkan data mahasiwa
            LoadDataMahasiswa();

            // atur ulang posisi tombol Simpan dan Batal
            // disamakan dg posisi tombol Tambah dan Perbaiki
            btnSimpan.Location = btnTambah.Location;
            btnBatal.Location = btnPerbaiki.Location;
        }

        private void LoadDataMahasiswa()
        {
            // kosongkan data listview mahasiswa
            lvwMahasiswa.Items.Clear();

            // panggil method GetAll untuk mendapatkan semua data mahasiswa
            var list = _controller.GetAll();

            // lakukan perulangan untuk menampilkan data mahasiswa ke listview
            foreach (var mhs in list)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.npm);
                item.SubItems.Add(mhs.nama);
                item.SubItems.Add(mhs.alamat);

                lvwMahasiswa.Items.Add(item);
            }
        }

        // format kolom listview
        private void InisialisasiListView()
        {
            lvwMahasiswa.View = System.Windows.Forms.View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("NPM", 91, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama", 220, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Alamat", 280, HorizontalAlignment.Left);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // status untuk operasi tambah atau perbaiki
            _addData = true; // operasi tambah data baru

            // kosongkan isian npm, nama dan alamat
            mskNPM.Clear();
            txtNama.Clear();
            txtAlamat.Clear();

            // fokus ke textbox npm
            mskNPM.Focus();

            // sembunyikan btnTambah, btnPerbaiki dan btnHapus
            btnTambah.Visible = false;
            btnPerbaiki.Visible = false;
            btnHapus.Visible = false;

            // tampilkan btnSimpan dan btnBatal
            btnSimpan.Visible = true;
            btnBatal.Visible = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            // tampilkan btnTambah, btnPerbaiki dan btnHapus
            btnTambah.Visible = true;
            btnPerbaiki.Visible = true;
            btnHapus.Visible = true;

            // sembunyikan btnSimpan dan btnBatal
            btnSimpan.Visible = false;
            btnBatal.Visible = false;

            // reset inputan data
            mskNPM.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            // cek apakah data mahasiswa sudah dipilih
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                _addData = false;

                // ambil index listview yang di pilih
                var index = lvwMahasiswa.SelectedIndices[0];

                var item = lvwMahasiswa.Items[index];
                mskNPM.Text = item.SubItems[1].Text;
                txtNama.Text = item.SubItems[2].Text;
                txtAlamat.Text = item.SubItems[3].Text;

                mskNPM.Focus();

                // sembunyikan tombol tambah, perbaiki dan hapus
                btnTambah.Visible = false;
                btnPerbaiki.Visible = false;
                btnHapus.Visible = false;

                // tampilkan tombol simpan dan batal
                btnSimpan.Visible = true;
                btnBatal.Visible = true;
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // membuat objek dari class Mahasiswa
            var mhs = new Mahasiswa();

            // set nilai property objek mahasiswa
            mhs.npm = mskNPM.Text;
            mhs.nama = txtNama.Text;
            mhs.alamat = txtAlamat.Text;

            var result = 0;

            if (_addData == true) // tambah data baru, panggil method Save
                result = _controller.Save(mhs);
            else // edit data, panggil method Update
                result = _controller.Update(mhs);

            if (result > 0) // tambah/edit data berhasil
            {
                // reset inputan dta
                mskNPM.Clear();
                txtNama.Clear();
                txtAlamat.Clear();

                mskNPM.Focus();

                // tampilkan kembali tombol tambah, perbaiki dan hapus
                btnTambah.Visible = true;
                btnPerbaiki.Visible = true;
                btnHapus.Visible = true;

                // sembunyikan tombol simpan dan batal
                btnSimpan.Visible = false;
                btnBatal.Visible = false;

                // refresh data yang ditampilkan
                LoadDataMahasiswa();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // cek apakah data mahasiswa sudah dipilih
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                // tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil index listview yang di pilih
                    var index = lvwMahasiswa.SelectedIndices[0];
                    var item = lvwMahasiswa.Items[index];

                    // membuat objek dari class Mahasiswa
                    var mhs = new Mahasiswa();
                    mhs.npm = item.SubItems[1].Text;

                    var result = _controller.Delete(mhs);
                    if (result > 0) LoadDataMahasiswa(); // jika hapus berhasil, referesh data mahasiswa
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // kosongkan data listview mahasiswa
            lvwMahasiswa.Items.Clear();

            // panggil method GetByNama untuk mendapatkan semua data mahasiswa
            var list = _controller.GetByNama(txtCari.Text);

            // lakukan perulangan untuk menampilkan data mahasiswa ke listview
            foreach (var mhs in list)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.npm);
                item.SubItems.Add(mhs.nama);
                item.SubItems.Add(mhs.alamat);

                lvwMahasiswa.Items.Add(item);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
