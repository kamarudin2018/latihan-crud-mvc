using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using LatihanCRUDMVC.View;

namespace LatihanCRUDMVC
{
    static class Program
    {
        public static string userName;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK) // jika login berhasil
            {
                // tampilkan form utama
                Application.Run(new FrmUtama());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
