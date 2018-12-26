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
    public class LoginAplikasiRepository
    {
        // deklarsi objek DbContext
        private DbContext _context;

        // constructor
        public LoginAplikasiRepository(DbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Method untuk mengecek user yang login valid atau tidak
        /// </summary>
        /// <param name="userName">Diisi dengan username</param>
        /// <param name="password">Diisi dengan password</param>
        /// <returns>Mengembalikan nilai true jika user dan password benar, selain itu false</returns>
        public bool IsValidUser(string userName, string password)
        {
            var result = 0;

            var sql = @"select count(*)
                        from login_aplikasi 
                        where user_name = @userName and password = @password";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @userName dan @password
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);

                result = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return result > 0;
        }
    }
}
