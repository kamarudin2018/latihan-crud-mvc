using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using LatihanCRUDMVC.Model.Context;
using LatihanCRUDMVC.Model.Entity;

namespace LatihanCRUDMVC.Model.Repository
{
    public class ProfilRepository
    {
        // deklarsi objek DbContext
        private DbContext _context;

        // constructor
        public ProfilRepository(DbContext context)
        {
            _context = context;
        }

        public Profil GetProfil()
        {
            // deklarasi objek profil
            Profil profil = null;

            var sql = @"select profil, alamat, kota
                        from profil";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                using (var dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari hasil query
                    if (dtr.Read()) // jika data profil ditemukan
                    {
                        // membuat objek dari class Profil
                        profil = new Profil();

                        // set nilai property objek profil
                        profil.profil = dtr["profil"].ToString();
                        profil.alamat = dtr["alamat"].ToString();
                        profil.kota = dtr["kota"].ToString();
                    }
                }
            }

            return profil;
        }

        public int Save(Profil obj)
        {
            var result = 0;

            var sql = @"insert into profil (profil, alamat, kota)
                        values (@profil, @alamat, @kota)";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @profil, @alamat dan @kota
                cmd.Parameters.AddWithValue("@profil", obj.profil);
                cmd.Parameters.AddWithValue("@alamat", obj.alamat);
                cmd.Parameters.AddWithValue("@kota", obj.kota);

                // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }

        public int Update(Profil obj)
        {
            var result = 0;

            var sql = @"update profil set profil = @profil, alamat = @alamat, kota = @kota";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @profil, @alamat dan @kota
                cmd.Parameters.AddWithValue("@profil", obj.profil);
                cmd.Parameters.AddWithValue("@alamat", obj.alamat);
                cmd.Parameters.AddWithValue("@kota", obj.kota);

                // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }
    }
}
