namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    partial class HastaneDetay
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
            this.LblHastaneAdi = new System.Windows.Forms.Label();
            this.LblHastaneId = new System.Windows.Forms.Label();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.TxtDepartman = new System.Windows.Forms.ComboBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHastaneAdi
            // 
            this.LblHastaneAdi.BackColor = System.Drawing.SystemColors.Highlight;
            this.LblHastaneAdi.Location = new System.Drawing.Point(109, 33);
            this.LblHastaneAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHastaneAdi.Name = "LblHastaneAdi";
            this.LblHastaneAdi.Size = new System.Drawing.Size(682, 25);
            this.LblHastaneAdi.TabIndex = 1;
            this.LblHastaneAdi.Text = "***";
            this.LblHastaneAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHastaneId
            // 
            this.LblHastaneId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblHastaneId.Location = new System.Drawing.Point(39, 33);
            this.LblHastaneId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHastaneId.Name = "LblHastaneId";
            this.LblHastaneId.Size = new System.Drawing.Size(73, 25);
            this.LblHastaneId.TabIndex = 2;
            this.LblHastaneId.Text = "***";
            this.LblHastaneId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(42, 96);
            this.TxtYetkili.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(123, 20);
            this.TxtYetkili.TabIndex = 3;
            // 
            // TxtDepartman
            // 
            this.TxtDepartman.FormattingEnabled = true;
            this.TxtDepartman.Location = new System.Drawing.Point(209, 94);
            this.TxtDepartman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDepartman.Name = "TxtDepartman";
            this.TxtDepartman.Size = new System.Drawing.Size(137, 21);
            this.TxtDepartman.TabIndex = 4;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(373, 94);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(87, 20);
            this.TxtTel.TabIndex = 5;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(474, 94);
            this.TxtGsm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(87, 20);
            this.TxtGsm.TabIndex = 5;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(714, 90);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(50, 25);
            this.BtnEkle.TabIndex = 6;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(576, 94);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(123, 20);
            this.TxtEmail.TabIndex = 3;
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
            this.Liste.Location = new System.Drawing.Point(42, 174);
            this.Liste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(749, 173);
            this.Liste.TabIndex = 7;
            // 
            // BtnKayit
            // 
            this.BtnKayit.Location = new System.Drawing.Point(741, 350);
            this.BtnKayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(50, 25);
            this.BtnKayit.TabIndex = 8;
            this.BtnKayit.Text = "Kaydet";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
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
            // HastaneDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 378);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtGsm);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtDepartman);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtYetkili);
            this.Controls.Add(this.LblHastaneId);
            this.Controls.Add(this.LblHastaneAdi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HastaneDetay";
            this.Text = "HastaneDetay";
            this.Load += new System.EventHandler(this.HastaneDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblHastaneAdi;
        public System.Windows.Forms.Label LblHastaneId;
        private System.Windows.Forms.TextBox TxtYetkili;
        private System.Windows.Forms.ComboBox TxtDepartman;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}