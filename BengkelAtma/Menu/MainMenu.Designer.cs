using BengkelAtma.Menu;

namespace BengkelAtma
{
    partial class MainMenu
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.akun1 = new BengkelAtma.Menu.Akun();
            this.TabMenu = new MetroFramework.Controls.MetroTabControl();
            this.AkunCabangTab = new MetroFramework.Controls.MetroTabPage();
            this.Pembayaran = new MetroFramework.Controls.MetroTabPage();
            this.Surat = new MetroFramework.Controls.MetroTabPage();
            this.CabangSales = new MetroFramework.Controls.MetroTabPage();
            this.Jasa = new MetroFramework.Controls.MetroTabPage();
            this.Laporan = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.Pegawai = new BengkelAtma.Menu.Pegawai();
            this.akunPegawai1 = new BengkelAtma.Menu.Akun();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.leftPanel.Controls.Add(this.btnKeluar);
            this.leftPanel.Controls.Add(this.btnProfil);
            this.leftPanel.Controls.Add(this.btnHome);
            this.leftPanel.Controls.Add(this.lbUser);
            this.leftPanel.Controls.Add(this.pbProfil);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 541);
            this.leftPanel.TabIndex = 0;
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKeluar.Image = global::BengkelAtma.Properties.Resources.checkered_flag;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.Location = new System.Drawing.Point(0, 289);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(172, 39);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfil.Image = global::BengkelAtma.Properties.Resources.client_user;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(3, 178);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(172, 39);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Image = global::BengkelAtma.Properties.Resources.positioning;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 133);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(172, 39);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Beranda";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(81, 83);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(33, 15);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "User";
            // 
            // pbProfil
            // 
            this.pbProfil.BackgroundImage = global::BengkelAtma.Properties.Resources.user;
            this.pbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProfil.Location = new System.Drawing.Point(39, 12);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(114, 63);
            this.pbProfil.TabIndex = 0;
            this.pbProfil.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 538);
            this.panel1.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.akun1);
            this.metroPanel1.Controls.Add(this.TabMenu);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 42);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(808, 496);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // akun1
            // 
            this.akun1.Dock = System.Windows.Forms.DockStyle.Left;
            this.akun1.Location = new System.Drawing.Point(0, 46);
            this.akun1.Name = "akun1";
            this.akun1.Size = new System.Drawing.Size(600, 450);
            this.akun1.TabIndex = 3;
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.AkunCabangTab);
            this.TabMenu.Controls.Add(this.Pembayaran);
            this.TabMenu.Controls.Add(this.Surat);
            this.TabMenu.Controls.Add(this.CabangSales);
            this.TabMenu.Controls.Add(this.Jasa);
            this.TabMenu.Controls.Add(this.Laporan);
            this.TabMenu.CustomBackground = true;
            this.TabMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(808, 46);
            this.TabMenu.TabIndex = 0;
            this.TabMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTabControl1_MouseClick);
            // 
            // AkunCabangTab
            // 
            this.AkunCabangTab.HorizontalScrollbarBarColor = true;
            this.AkunCabangTab.Location = new System.Drawing.Point(4, 35);
            this.AkunCabangTab.Name = "AkunCabangTab";
            this.AkunCabangTab.Size = new System.Drawing.Size(800, 7);
            this.AkunCabangTab.TabIndex = 0;
            this.AkunCabangTab.Text = "Akun && Pegawai";
            this.AkunCabangTab.VerticalScrollbarBarColor = true;
            // 
            // Pembayaran
            // 
            this.Pembayaran.HorizontalScrollbarBarColor = true;
            this.Pembayaran.Location = new System.Drawing.Point(4, 35);
            this.Pembayaran.Name = "Pembayaran";
            this.Pembayaran.Size = new System.Drawing.Size(192, 61);
            this.Pembayaran.TabIndex = 1;
            this.Pembayaran.Text = "Pembayaran";
            this.Pembayaran.VerticalScrollbarBarColor = true;
            // 
            // Surat
            // 
            this.Surat.HorizontalScrollbarBarColor = true;
            this.Surat.Location = new System.Drawing.Point(4, 35);
            this.Surat.Name = "Surat";
            this.Surat.Size = new System.Drawing.Size(192, 61);
            this.Surat.TabIndex = 5;
            this.Surat.Text = "Surat";
            this.Surat.VerticalScrollbarBarColor = true;
            // 
            // CabangSales
            // 
            this.CabangSales.HorizontalScrollbarBarColor = true;
            this.CabangSales.Location = new System.Drawing.Point(4, 35);
            this.CabangSales.Name = "CabangSales";
            this.CabangSales.Size = new System.Drawing.Size(192, 61);
            this.CabangSales.TabIndex = 2;
            this.CabangSales.Text = "Cabang && Sales";
            this.CabangSales.VerticalScrollbarBarColor = true;
            // 
            // Jasa
            // 
            this.Jasa.HorizontalScrollbarBarColor = true;
            this.Jasa.Location = new System.Drawing.Point(4, 35);
            this.Jasa.Name = "Jasa";
            this.Jasa.Size = new System.Drawing.Size(192, 61);
            this.Jasa.TabIndex = 3;
            this.Jasa.Text = "Jasa";
            this.Jasa.VerticalScrollbarBarColor = true;
            // 
            // Laporan
            // 
            this.Laporan.HorizontalScrollbarBarColor = true;
            this.Laporan.Location = new System.Drawing.Point(4, 35);
            this.Laporan.Name = "Laporan";
            this.Laporan.Size = new System.Drawing.Size(192, 61);
            this.Laporan.TabIndex = 4;
            this.Laporan.Text = "Laporan";
            this.Laporan.VerticalScrollbarBarColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 42);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.panel5.Controls.Add(this.label);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(581, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 30);
            this.panel5.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(54, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(147, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Ayo Pilih Menu";
            // 
            // Pegawai
            // 
            this.Pegawai.Location = new System.Drawing.Point(0, 46);
            this.Pegawai.Name = "Pegawai";
            this.Pegawai.Size = new System.Drawing.Size(600, 450);
            this.Pegawai.TabIndex = 4;
            // 
            // akunPegawai1
            // 
            this.akunPegawai1.Location = new System.Drawing.Point(0, 0);
            this.akunPegawai1.Name = "akunPegawai1";
            this.akunPegawai1.Size = new System.Drawing.Size(600, 400);
            this.akunPegawai1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1008, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.MinimumSize = new System.Drawing.Size(1024, 580);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pbProfil;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl TabMenu;
        private MetroFramework.Controls.MetroTabPage AkunCabangTab;
        private MetroFramework.Controls.MetroTabPage Pembayaran;
        private MetroFramework.Controls.MetroTabPage CabangSales;
        private MetroFramework.Controls.MetroTabPage Jasa;
        private MetroFramework.Controls.MetroTabPage Laporan;
        private MetroFramework.Controls.MetroTabPage Surat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label;
        private Akun akunPegawai1;
        private Menu.Pegawai Pegawai;
        private Akun akun1;
    }
}