namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    partial class FirmaDetay
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
            this.BtnKayit = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtDepartman = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.LblFirmaId = new System.Windows.Forms.Label();
            this.LblFirmaAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKayit
            // 
            this.BtnKayit.Location = new System.Drawing.Point(726, 371);
            this.BtnKayit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(50, 25);
            this.BtnKayit.TabIndex = 18;
            this.BtnKayit.Text = "Kaydet";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.GirisId,
            this.Yetkili,
            this.Departman,
            this.Tel,
            this.Gsm,
            this.Email});
            this.Liste.Location = new System.Drawing.Point(27, 195);
            this.Liste.Margin = new System.Windows.Forms.Padding(2);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(749, 173);
            this.Liste.TabIndex = 17;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sıra";
            this.Sira.MinimumWidth = 8;
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // GirisId
            // 
            this.GirisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisId.HeaderText = "Giriş ID";
            this.GirisId.MinimumWidth = 8;
            this.GirisId.Name = "GirisId";
            this.GirisId.Width = 66;
            // 
            // Yetkili
            // 
            this.Yetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yetkili.HeaderText = "Yetkili";
            this.Yetkili.MinimumWidth = 8;
            this.Yetkili.Name = "Yetkili";
            // 
            // Departman
            // 
            this.Departman.HeaderText = "Departman";
            this.Departman.MinimumWidth = 8;
            this.Departman.Name = "Departman";
            this.Departman.Width = 150;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.MinimumWidth = 8;
            this.Tel.Name = "Tel";
            this.Tel.Width = 68;
            // 
            // Gsm
            // 
            this.Gsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gsm.HeaderText = "Gsm";
            this.Gsm.MinimumWidth = 8;
            this.Gsm.Name = "Gsm";
            this.Gsm.Width = 53;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(699, 111);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(50, 25);
            this.BtnEkle.TabIndex = 16;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(459, 115);
            this.TxtGsm.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(87, 20);
            this.TxtGsm.TabIndex = 14;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(358, 115);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(87, 20);
            this.TxtTel.TabIndex = 15;
            // 
            // TxtDepartman
            // 
            this.TxtDepartman.FormattingEnabled = true;
            this.TxtDepartman.Location = new System.Drawing.Point(194, 115);
            this.TxtDepartman.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDepartman.Name = "TxtDepartman";
            this.TxtDepartman.Size = new System.Drawing.Size(137, 21);
            this.TxtDepartman.TabIndex = 13;
            this.TxtDepartman.SelectedIndexChanged += new System.EventHandler(this.TxtDepartman_SelectedIndexChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(561, 115);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(123, 20);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(27, 117);
            this.TxtYetkili.Margin = new System.Windows.Forms.Padding(2);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(123, 20);
            this.TxtYetkili.TabIndex = 12;
            // 
            // LblFirmaId
            // 
            this.LblFirmaId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblFirmaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFirmaId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFirmaId.Location = new System.Drawing.Point(24, 54);
            this.LblFirmaId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFirmaId.Name = "LblFirmaId";
            this.LblFirmaId.Size = new System.Drawing.Size(73, 25);
            this.LblFirmaId.TabIndex = 10;
            this.LblFirmaId.Text = "***";
            this.LblFirmaId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFirmaAdi
            // 
            this.LblFirmaAdi.BackColor = System.Drawing.SystemColors.Highlight;
            this.LblFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFirmaAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFirmaAdi.Location = new System.Drawing.Point(94, 54);
            this.LblFirmaAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFirmaAdi.Name = "LblFirmaAdi";
            this.LblFirmaAdi.Size = new System.Drawing.Size(237, 25);
            this.LblFirmaAdi.TabIndex = 9;
            this.LblFirmaAdi.Text = "***";
            this.LblFirmaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirmaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 439);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtGsm);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtDepartman);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtYetkili);
            this.Controls.Add(this.LblFirmaId);
            this.Controls.Add(this.LblFirmaAdi);
            this.Name = "FirmaDetay";
            this.Text = "FirmaDetay";
            this.Load += new System.EventHandler(this.FirmaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.ComboBox TxtDepartman;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtYetkili;
        public System.Windows.Forms.Label LblFirmaId;
        public System.Windows.Forms.Label LblFirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}