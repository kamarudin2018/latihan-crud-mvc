namespace LatihanCRUDMVC.View
{
    partial class FrmUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.referensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMahasiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuku = new System.Windows.Forms.ToolStripMenuItem();
            this.sirkulasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referensiToolStripMenuItem,
            this.sirkulasiToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.pengaturanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referensiToolStripMenuItem
            // 
            this.referensiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMahasiswa,
            this.mnuBuku});
            this.referensiToolStripMenuItem.Name = "referensiToolStripMenuItem";
            this.referensiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.referensiToolStripMenuItem.Text = "Referensi";
            // 
            // mnuMahasiswa
            // 
            this.mnuMahasiswa.Name = "mnuMahasiswa";
            this.mnuMahasiswa.Size = new System.Drawing.Size(132, 22);
            this.mnuMahasiswa.Text = "Mahasiswa";
            this.mnuMahasiswa.Click += new System.EventHandler(this.mnuMahasiswa_Click);
            // 
            // mnuBuku
            // 
            this.mnuBuku.Name = "mnuBuku";
            this.mnuBuku.Size = new System.Drawing.Size(132, 22);
            this.mnuBuku.Text = "Buku";
            this.mnuBuku.Click += new System.EventHandler(this.mnuBuku_Click);
            // 
            // sirkulasiToolStripMenuItem
            // 
            this.sirkulasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peminjamanToolStripMenuItem,
            this.pengembalianToolStripMenuItem});
            this.sirkulasiToolStripMenuItem.Name = "sirkulasiToolStripMenuItem";
            this.sirkulasiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sirkulasiToolStripMenuItem.Text = "Sirkulasi";
            // 
            // peminjamanToolStripMenuItem
            // 
            this.peminjamanToolStripMenuItem.Name = "peminjamanToolStripMenuItem";
            this.peminjamanToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.peminjamanToolStripMenuItem.Text = "Peminjaman";
            // 
            // pengembalianToolStripMenuItem
            // 
            this.pengembalianToolStripMenuItem.Name = "pengembalianToolStripMenuItem";
            this.pengembalianToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pengembalianToolStripMenuItem.Text = "Pengembalian";
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLogin,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(627, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLogin
            // 
            this.sbLogin.Name = "sbLogin";
            this.sbLogin.Size = new System.Drawing.Size(57, 17);
            this.sbLogin.Text = "Operator:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(169, 17);
            this.toolStripStatusLabel2.Text = "Sistem Informasi Perpustakaan";
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfil});
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // mnuProfil
            // 
            this.mnuProfil.Name = "mnuProfil";
            this.mnuProfil.Size = new System.Drawing.Size(152, 22);
            this.mnuProfil.Text = "Profil";
            this.mnuProfil.Click += new System.EventHandler(this.mnuProfil_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Informasi Perpustakaan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMahasiswa;
        private System.Windows.Forms.ToolStripMenuItem mnuBuku;
        private System.Windows.Forms.ToolStripMenuItem sirkulasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbLogin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProfil;
    }
}