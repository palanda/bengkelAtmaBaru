namespace BengkelAtma
{
    partial class ucLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMasuk = new AltoControls.AltoButton();
            this.tbUser = new AltoControls.AltoTextBox();
            this.tbPass = new AltoControls.AltoTextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tbMasuk
            // 
            this.tbMasuk.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.tbMasuk.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.tbMasuk.BackColor = System.Drawing.Color.Transparent;
            this.tbMasuk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tbMasuk.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMasuk.ForeColor = System.Drawing.Color.White;
            this.tbMasuk.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.tbMasuk.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.tbMasuk.Location = new System.Drawing.Point(74, 130);
            this.tbMasuk.Name = "tbMasuk";
            this.tbMasuk.Radius = 10;
            this.tbMasuk.Size = new System.Drawing.Size(94, 30);
            this.tbMasuk.Stroke = false;
            this.tbMasuk.StrokeColor = System.Drawing.Color.Gray;
            this.tbMasuk.TabIndex = 4;
            this.tbMasuk.Text = "Masuk";
            this.tbMasuk.Transparency = false;
            this.tbMasuk.Click += new System.EventHandler(this.tbMasuk_Click);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.Transparent;
            this.tbUser.Br = System.Drawing.Color.White;
            this.tbUser.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Location = new System.Drawing.Point(69, 35);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(135, 26);
            this.tbUser.TabIndex = 5;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.Transparent;
            this.tbPass.Br = System.Drawing.Color.White;
            this.tbPass.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Location = new System.Drawing.Point(70, 70);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(135, 26);
            this.tbPass.TabIndex = 6;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.tbPass);
            this.gbLogin.Controls.Add(this.tbUser);
            this.gbLogin.Controls.Add(this.tbMasuk);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLogin.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(15, 18);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(211, 185);
            this.gbLogin.TabIndex = 5;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Silahkan Login";
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLogin);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(248, 226);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton tbMasuk;
        private AltoControls.AltoTextBox tbUser;
        private AltoControls.AltoTextBox tbPass;
        private System.Windows.Forms.GroupBox gbLogin;
    }
}
