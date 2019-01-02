namespace WindowsFormsApp2
{
    partial class form_Registracija
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
            System.Windows.Forms.TextBox txbx_LozinkaReg;
            System.Windows.Forms.TextBox txbx_KorisničkoImeReg;
            System.Windows.Forms.TextBox txbx_Email;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Registracija));
            this.btn_Registriraj2 = new System.Windows.Forms.Button();
            this.lbl_LozinkaReg = new System.Windows.Forms.Label();
            this.lbl_KorisničkoImeReg = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            txbx_LozinkaReg = new System.Windows.Forms.TextBox();
            txbx_KorisničkoImeReg = new System.Windows.Forms.TextBox();
            txbx_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Registriraj2
            // 
            this.btn_Registriraj2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Registriraj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registriraj2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Registriraj2.Location = new System.Drawing.Point(54, 388);
            this.btn_Registriraj2.Name = "btn_Registriraj2";
            this.btn_Registriraj2.Size = new System.Drawing.Size(148, 50);
            this.btn_Registriraj2.TabIndex = 11;
            this.btn_Registriraj2.Text = "Registriraj se";
            this.btn_Registriraj2.UseVisualStyleBackColor = false;
            this.btn_Registriraj2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_LozinkaReg
            // 
            this.lbl_LozinkaReg.AutoSize = true;
            this.lbl_LozinkaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LozinkaReg.Location = new System.Drawing.Point(90, 302);
            this.lbl_LozinkaReg.Name = "lbl_LozinkaReg";
            this.lbl_LozinkaReg.Size = new System.Drawing.Size(80, 25);
            this.lbl_LozinkaReg.TabIndex = 10;
            this.lbl_LozinkaReg.Text = "Lozinka";
            this.lbl_LozinkaReg.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbx_LozinkaReg
            // 
            txbx_LozinkaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbx_LozinkaReg.Location = new System.Drawing.Point(26, 330);
            txbx_LozinkaReg.Name = "txbx_LozinkaReg";
            txbx_LozinkaReg.PasswordChar = '*';
            txbx_LozinkaReg.Size = new System.Drawing.Size(215, 30);
            txbx_LozinkaReg.TabIndex = 9;
            txbx_LozinkaReg.UseSystemPasswordChar = true;
            txbx_LozinkaReg.TextChanged += new System.EventHandler(this.Šifr_TextChanged);
            // 
            // lbl_KorisničkoImeReg
            // 
            this.lbl_KorisničkoImeReg.AutoSize = true;
            this.lbl_KorisničkoImeReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KorisničkoImeReg.Location = new System.Drawing.Point(72, 196);
            this.lbl_KorisničkoImeReg.Name = "lbl_KorisničkoImeReg";
            this.lbl_KorisničkoImeReg.Size = new System.Drawing.Size(139, 25);
            this.lbl_KorisničkoImeReg.TabIndex = 8;
            this.lbl_KorisničkoImeReg.Text = "Korisničko ime";
            this.lbl_KorisničkoImeReg.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbx_KorisničkoImeReg
            // 
            txbx_KorisničkoImeReg.AcceptsReturn = true;
            txbx_KorisničkoImeReg.AcceptsTab = true;
            txbx_KorisničkoImeReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            txbx_KorisničkoImeReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbx_KorisničkoImeReg.Location = new System.Drawing.Point(26, 224);
            txbx_KorisničkoImeReg.Name = "txbx_KorisničkoImeReg";
            txbx_KorisničkoImeReg.Size = new System.Drawing.Size(215, 30);
            txbx_KorisničkoImeReg.TabIndex = 7;
            txbx_KorisničkoImeReg.TextChanged += new System.EventHandler(this.Korisničko_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(110, 89);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(60, 25);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Email";
            // 
            // txbx_Email
            // 
            txbx_Email.AcceptsReturn = true;
            txbx_Email.AcceptsTab = true;
            txbx_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            txbx_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbx_Email.Location = new System.Drawing.Point(26, 117);
            txbx_Email.Name = "txbx_Email";
            txbx_Email.Size = new System.Drawing.Size(215, 30);
            txbx_Email.TabIndex = 12;
            // 
            // form_Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(txbx_Email);
            this.Controls.Add(this.btn_Registriraj2);
            this.Controls.Add(this.lbl_LozinkaReg);
            this.Controls.Add(txbx_LozinkaReg);
            this.Controls.Add(this.lbl_KorisničkoImeReg);
            this.Controls.Add(txbx_KorisničkoImeReg);
            this.Name = "form_Registracija";
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.Registracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Registriraj2;
        private System.Windows.Forms.Label lbl_LozinkaReg;
        private System.Windows.Forms.Label lbl_KorisničkoImeReg;
        private System.Windows.Forms.Label lbl_Email;
    }
}