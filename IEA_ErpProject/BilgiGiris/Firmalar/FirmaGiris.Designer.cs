namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    partial class FirmaGiris
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
            this.BtnDetayGoster = new System.Windows.Forms.Button();
            this.BtnDetayEkle = new System.Windows.Forms.Button();
            this.TxtFirmaBul = new System.Windows.Forms.TextBox();
            this.TxtVergiDairesi = new System.Windows.Forms.TextBox();
            this.TxtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtSehir = new System.Windows.Forms.ComboBox();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.TxtFTipi = new System.Windows.Forms.ComboBox();
            this.TxtFadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScHastane = new System.Windows.Forms.SplitContainer();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScHastane)).BeginInit();
            this.ScHastane.Panel1.SuspendLayout();
            this.ScHastane.Panel2.SuspendLayout();
            this.ScHastane.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDetayGoster
            // 
            this.BtnDetayGoster.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDetayGoster.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnDetayGoster.Location = new System.Drawing.Point(564, 125);
            this.BtnDetayGoster.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDetayGoster.Name = "BtnDetayGoster";
            this.BtnDetayGoster.Size = new System.Drawing.Size(99, 32);
            this.BtnDetayGoster.TabIndex = 10;
            this.BtnDetayGoster.Text = "Detay Göster";
            this.BtnDetayGoster.UseVisualStyleBackColor = false;
            this.BtnDetayGoster.Visible = false;
            this.BtnDetayGoster.Click += new System.EventHandler(this.BtnDetayGoster_Click);
            // 
            // BtnDetayEkle
            // 
            this.BtnDetayEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDetayEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnDetayEkle.Location = new System.Drawing.Point(456, 125);
            this.BtnDetayEkle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDetayEkle.Name = "BtnDetayEkle";
            this.BtnDetayEkle.Size = new System.Drawing.Size(99, 32);
            this.BtnDetayEkle.TabIndex = 10;
            this.BtnDetayEkle.Text = "Detay Ekle";
            this.BtnDetayEkle.UseVisualStyleBackColor = false;
            this.BtnDetayEkle.Visible = false;
            this.BtnDetayEkle.Click += new System.EventHandler(this.BtnDetayEkle_Click);
            // 
            // TxtFirmaBul
            // 
            this.TxtFirmaBul.Location = new System.Drawing.Point(115, 16);
            this.TxtFirmaBul.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFirmaBul.Name = "TxtFirmaBul";
            this.TxtFirmaBul.Size = new System.Drawing.Size(63, 20);
            this.TxtFirmaBul.TabIndex = 9;
            this.TxtFirmaBul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(560, 69);
            this.TxtVergiDairesi.Margin = new System.Windows.Forms.Padding(2);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(101, 20);
            this.TxtVergiDairesi.TabIndex = 8;
            // 
            // TxtVergiNo
            // 
            this.TxtVergiNo.Location = new System.Drawing.Point(558, 94);
            this.TxtVergiNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtVergiNo.Mask = "00000000000";
            this.TxtVergiNo.Name = "TxtVergiNo";
            this.TxtVergiNo.Size = new System.Drawing.Size(103, 20);
            this.TxtVergiNo.TabIndex = 7;
            // 
            // TxtSehir
            // 
            this.TxtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSehir.FormattingEnabled = true;
            this.TxtSehir.Location = new System.Drawing.Point(560, 15);
            this.TxtSehir.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(103, 21);
            this.TxtSehir.TabIndex = 5;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(115, 93);
            this.TxtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(202, 64);
            this.TxtAdres.TabIndex = 4;
            this.TxtAdres.Text = "";
            // 
            // TxtFTipi
            // 
            this.TxtFTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtFTipi.FormattingEnabled = true;
            this.TxtFTipi.Location = new System.Drawing.Point(115, 40);
            this.TxtFTipi.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFTipi.Name = "TxtFTipi";
            this.TxtFTipi.Size = new System.Drawing.Size(134, 21);
            this.TxtFTipi.TabIndex = 3;
            // 
            // TxtFadi
            // 
            this.TxtFadi.Location = new System.Drawing.Point(177, 16);
            this.TxtFadi.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFadi.Name = "TxtFadi";
            this.TxtFadi.Size = new System.Drawing.Size(217, 20);
            this.TxtFadi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(453, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vergi No :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(9, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(454, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vergi Dairesi :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(454, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şehir :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.TipAdi,
            this.Email,
            this.Tel,
            this.Sehir});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Margin = new System.Windows.Forms.Padding(2);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(678, 210);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 8;
            this.Sira.Name = "Sira";
            this.Sira.ReadOnly = true;
            this.Sira.Width = 50;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Firma Adi";
            this.Adi.MinimumWidth = 8;
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            // 
            // TipAdi
            // 
            this.TipAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipAdi.HeaderText = "Firma Tipi";
            this.TipAdi.MinimumWidth = 8;
            this.TipAdi.Name = "TipAdi";
            this.TipAdi.ReadOnly = true;
            this.TipAdi.Width = 77;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.MinimumWidth = 8;
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 68;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.MinimumWidth = 8;
            this.Sehir.Name = "Sehir";
            this.Sehir.ReadOnly = true;
            this.Sehir.Width = 56;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Firma Tipi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firma Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScHastane
            // 
            this.ScHastane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScHastane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScHastane.Location = new System.Drawing.Point(0, 49);
            this.ScHastane.Margin = new System.Windows.Forms.Padding(2);
            this.ScHastane.Name = "ScHastane";
            this.ScHastane.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScHastane.Panel1
            // 
            this.ScHastane.Panel1.Controls.Add(this.BtnDetayGoster);
            this.ScHastane.Panel1.Controls.Add(this.BtnDetayEkle);
            this.ScHastane.Panel1.Controls.Add(this.TxtFirmaBul);
            this.ScHastane.Panel1.Controls.Add(this.TxtVergiDairesi);
            this.ScHastane.Panel1.Controls.Add(this.TxtVergiNo);
            this.ScHastane.Panel1.Controls.Add(this.TxtTelefon);
            this.ScHastane.Panel1.Controls.Add(this.TxtSehir);
            this.ScHastane.Panel1.Controls.Add(this.TxtAdres);
            this.ScHastane.Panel1.Controls.Add(this.TxtFTipi);
            this.ScHastane.Panel1.Controls.Add(this.TxtEmail);
            this.ScHastane.Panel1.Controls.Add(this.TxtFadi);
            this.ScHastane.Panel1.Controls.Add(this.label9);
            this.ScHastane.Panel1.Controls.Add(this.label5);
            this.ScHastane.Panel1.Controls.Add(this.label8);
            this.ScHastane.Panel1.Controls.Add(this.label4);
            this.ScHastane.Panel1.Controls.Add(this.label7);
            this.ScHastane.Panel1.Controls.Add(this.label3);
            this.ScHastane.Panel1.Controls.Add(this.label6);
            this.ScHastane.Panel1.Controls.Add(this.label2);
            // 
            // ScHastane.Panel2
            // 
            this.ScHastane.Panel2.Controls.Add(this.Liste);
            this.ScHastane.Size = new System.Drawing.Size(682, 401);
            this.ScHastane.SplitterDistance = 184;
            this.ScHastane.SplitterWidth = 3;
            this.ScHastane.TabIndex = 12;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(560, 43);
            this.TxtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(101, 20);
            this.TxtTelefon.TabIndex = 6;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(115, 68);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(279, 20);
            this.TxtEmail.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(453, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(9, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firma Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit_64;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(638, 11);
            this.BtnKapat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(33, 31);
            this.BtnKapat.TabIndex = 11;
            this.BtnKapat.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.clean;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(144, 8);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(33, 31);
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.trash;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.Location = new System.Drawing.Point(99, 8);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(33, 31);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources._3099916;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(8, 8);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(33, 31);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.box_document_outline_share_top_upload_icon_1320195323221671611;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(53, 8);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(33, 31);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FirmaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.ScHastane);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label1);
            this.Name = "FirmaGiris";
            this.Text = "FirmaGiris";
            this.Load += new System.EventHandler(this.FirmaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ScHastane.Panel1.ResumeLayout(false);
            this.ScHastane.Panel1.PerformLayout();
            this.ScHastane.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScHastane)).EndInit();
            this.ScHastane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnDetayGoster;
        private System.Windows.Forms.Button BtnDetayEkle;
        private System.Windows.Forms.TextBox TxtFirmaBul;
        private System.Windows.Forms.TextBox TxtVergiDairesi;
        private System.Windows.Forms.MaskedTextBox TxtVergiNo;
        private System.Windows.Forms.ComboBox TxtSehir;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.ComboBox TxtFTipi;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.TextBox TxtFadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer ScHastane;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
    }
}