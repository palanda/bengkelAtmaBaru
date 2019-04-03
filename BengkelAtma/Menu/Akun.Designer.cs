namespace BengkelAtma.Menu
{
    partial class Akun
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgAkun = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.submenuAkun = new MetroFramework.Controls.MetroComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.Label();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.oldPass = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkun)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgAkun);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCari);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(303, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 400);
            this.panel1.TabIndex = 0;
            // 
            // dgAkun
            // 
            this.dgAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAkun.Location = new System.Drawing.Point(21, 137);
            this.dgAkun.Name = "dgAkun";
            this.dgAkun.Size = new System.Drawing.Size(256, 173);
            this.dgAkun.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username Akun yang dicari :";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(228, 79);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(49, 23);
            this.btnCari.TabIndex = 11;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(202, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(121, 325);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.submenuAkun);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.newPass);
            this.panel2.Controls.Add(this.tbOldPass);
            this.panel2.Controls.Add(this.oldPass);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 400);
            this.panel2.TabIndex = 1;
            // 
            // submenuAkun
            // 
            this.submenuAkun.FontSize = MetroFramework.MetroLinkSize.Small;
            this.submenuAkun.FormattingEnabled = true;
            this.submenuAkun.ItemHeight = 19;
            this.submenuAkun.Items.AddRange(new object[] {
            "Akun",
            "Pegawai"});
            this.submenuAkun.Location = new System.Drawing.Point(33, 39);
            this.submenuAkun.Name = "submenuAkun";
            this.submenuAkun.Size = new System.Drawing.Size(121, 25);
            this.submenuAkun.TabIndex = 10;
            this.submenuAkun.SelectedValueChanged += new System.EventHandler(this.submenuAkun_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 9;
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.Location = new System.Drawing.Point(30, 152);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(78, 13);
            this.newPass.TabIndex = 8;
            this.newPass.Text = "Password Baru";
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(33, 125);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(236, 20);
            this.tbOldPass.TabIndex = 7;
            // 
            // oldPass
            // 
            this.oldPass.AutoSize = true;
            this.oldPass.Location = new System.Drawing.Point(30, 109);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(82, 13);
            this.oldPass.TabIndex = 4;
            this.oldPass.Text = "Password Lama";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(116, 231);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(33, 231);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Akun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Akun";
            this.Size = new System.Drawing.Size(600, 400);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkun)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label oldPass;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label newPass;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.DataGridView dgAkun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroComboBox submenuAkun;
    }
}
