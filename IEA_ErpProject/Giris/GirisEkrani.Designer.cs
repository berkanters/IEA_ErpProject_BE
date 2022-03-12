namespace IEA_ErpProject.Giris
{
    partial class GirisEkrani
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
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtKullanici = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(155, 95);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(225, 30);
            this.TxtPassword.TabIndex = 22;
            this.TxtPassword.Text = "12345";
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.Location = new System.Drawing.Point(155, 48);
            this.TxtKullanici.Margin = new System.Windows.Forms.Padding(2);
            this.TxtKullanici.Multiline = true;
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(225, 30);
            this.TxtKullanici.TabIndex = 23;
            this.TxtKullanici.Text = "BerkantE";
            this.TxtKullanici.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(49, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Şifre :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(49, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 30);
            this.label11.TabIndex = 21;
            this.label11.Text = "Kullanıcı Adı :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackgroundImage = global::IEA_ErpProject.Properties.Resources.logn_with_png_and_vector_format_for_free_unlimited_download_935686;
            this.BtnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGiris.Location = new System.Drawing.Point(396, 57);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(93, 51);
            this.BtnGiris.TabIndex = 24;
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackgroundImage = global::IEA_ErpProject.Properties.Resources._out;
            this.BtnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCikis.Location = new System.Drawing.Point(11, 193);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(33, 31);
            this.BtnCikis.TabIndex = 25;
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // GirisEkrani
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCikis;
            this.ClientSize = new System.Drawing.Size(510, 235);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtKullanici);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtKullanici;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnCikis;
    }
}