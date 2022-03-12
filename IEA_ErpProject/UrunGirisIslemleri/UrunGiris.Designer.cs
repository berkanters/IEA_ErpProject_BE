namespace IEA_ErpProject.UrunGirisIslemleri
{
    partial class UrunGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlUrunGiris = new System.Windows.Forms.Panel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.SpcUrunGiris = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRowsDel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnAddListeRow = new System.Windows.Forms.Button();
            this.EtiketId = new System.Windows.Forms.Label();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFaturaNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtGirisTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCariAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCariTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGirisId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlUrunGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcUrunGiris)).BeginInit();
            this.SpcUrunGiris.Panel1.SuspendLayout();
            this.SpcUrunGiris.Panel2.SuspendLayout();
            this.SpcUrunGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUrunGiris
            // 
            this.PnlUrunGiris.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlUrunGiris.Controls.Add(this.BtnPrint);
            this.PnlUrunGiris.Controls.Add(this.label1);
            this.PnlUrunGiris.Controls.Add(this.BtnKapat);
            this.PnlUrunGiris.Controls.Add(this.BtnTemizle);
            this.PnlUrunGiris.Controls.Add(this.BtnSil);
            this.PnlUrunGiris.Controls.Add(this.BtnKaydet);
            this.PnlUrunGiris.Controls.Add(this.BtnGuncelle);
            this.PnlUrunGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUrunGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlUrunGiris.Location = new System.Drawing.Point(0, 0);
            this.PnlUrunGiris.Name = "PnlUrunGiris";
            this.PnlUrunGiris.Padding = new System.Windows.Forms.Padding(3);
            this.PnlUrunGiris.Size = new System.Drawing.Size(1418, 69);
            this.PnlUrunGiris.TabIndex = 0;
            this.PnlUrunGiris.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlUrunGiris_MouseClick);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackgroundImage = global::IEA_ErpProject.Properties.Resources.print_outline;
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrint.Location = new System.Drawing.Point(227, 11);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Padding = new System.Windows.Forms.Padding(20);
            this.BtnPrint.Size = new System.Drawing.Size(45, 41);
            this.BtnPrint.TabIndex = 18;
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(642, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ürün Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit_64;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(1330, 14);
            this.BtnKapat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(45, 41);
            this.BtnKapat.TabIndex = 16;
            this.BtnKapat.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.clean;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(178, 11);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(45, 41);
            this.BtnTemizle.TabIndex = 15;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Trash2;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSil.Location = new System.Drawing.Point(129, 11);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(45, 41);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources._3099916;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(31, 11);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(45, 41);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.box_document_outline_share_top_upload_icon_1320195323221671611;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(80, 11);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(45, 41);
            this.BtnGuncelle.TabIndex = 13;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // SpcUrunGiris
            // 
            this.SpcUrunGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcUrunGiris.Location = new System.Drawing.Point(0, 69);
            this.SpcUrunGiris.Name = "SpcUrunGiris";
            // 
            // SpcUrunGiris.Panel1
            // 
            this.SpcUrunGiris.Panel1.Controls.Add(this.Liste);
            this.SpcUrunGiris.Panel1.Controls.Add(this.panel1);
            // 
            // SpcUrunGiris.Panel2
            // 
            this.SpcUrunGiris.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.SpcUrunGiris.Panel2.Controls.Add(this.TxtAciklama);
            this.SpcUrunGiris.Panel2.Controls.Add(this.label8);
            this.SpcUrunGiris.Panel2.Controls.Add(this.TxtTarih);
            this.SpcUrunGiris.Panel2.Controls.Add(this.label7);
            this.SpcUrunGiris.Panel2.Controls.Add(this.TxtFaturaNo);
            this.SpcUrunGiris.Panel2.Controls.Add(this.label6);
            this.SpcUrunGiris.Panel2.Controls.Add(this.TxtGirisTuru);
            this.SpcUrunGiris.Panel2.Controls.Add(this.label5);
            this.SpcUrunGiris.Panel2.Controls.Add(this.TxtCariAdi);
            this.SpcUrunGiris.Panel2.Controls.Add(this.label4);
            this.SpcUrunGiris.Panel2.Controls.Add(this.TxtCariTur);
            this.SpcUrunGiris.Panel2.Controls.Add(this.label3);
            this.SpcUrunGiris.Panel2.Controls.Add(this.TxtGirisId);
            this.SpcUrunGiris.Panel2.Controls.Add(this.label2);
            this.SpcUrunGiris.Panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SpcUrunGiris.Size = new System.Drawing.Size(1418, 632);
            this.SpcUrunGiris.SplitterDistance = 1027;
            this.SpcUrunGiris.TabIndex = 1;
            // 
            // Liste
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.Barkod,
            this.UrunKodu,
            this.LotSeriNo,
            this.GirisAdet,
            this.Not,
            this.UrunId,
            this.Uts,
            this.UTarih,
            this.SKTarih,
            this.Durum});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle3;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 38);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Liste.RowHeadersVisible = false;
            this.Liste.Size = new System.Drawing.Size(1027, 594);
            this.Liste.TabIndex = 0;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Visible = false;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sıra";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // Barkod
            // 
            this.Barkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.Width = 66;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Ürün Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // LotSeriNo
            // 
            this.LotSeriNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LotSeriNo.HeaderText = "Lot Seri No";
            this.LotSeriNo.Name = "LotSeriNo";
            this.LotSeriNo.Width = 79;
            // 
            // GirisAdet
            // 
            this.GirisAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisAdet.HeaderText = "Giriş Adet";
            this.GirisAdet.Name = "GirisAdet";
            this.GirisAdet.Width = 71;
            // 
            // Not
            // 
            this.Not.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.NullValue = " ";
            this.Not.DefaultCellStyle = dataGridViewCellStyle2;
            this.Not.HeaderText = "Not";
            this.Not.Name = "Not";
            this.Not.Width = 49;
            // 
            // UrunId
            // 
            this.UrunId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunId.HeaderText = "UrunID";
            this.UrunId.Name = "UrunId";
            this.UrunId.Visible = false;
            // 
            // Uts
            // 
            this.Uts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Uts.FalseValue = "False";
            this.Uts.HeaderText = "UTS";
            this.Uts.Name = "Uts";
            this.Uts.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Uts.TrueValue = "True";
            this.Uts.Width = 54;
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UTarih.HeaderText = "Üretim Tarihi";
            this.UTarih.Name = "UTarih";
            this.UTarih.Width = 84;
            // 
            // SKTarih
            // 
            this.SKTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SKTarih.HeaderText = "Son Kullanma Tarihi";
            this.SKTarih.Name = "SKTarih";
            this.SKTarih.Width = 115;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Durum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRowsDel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.BtnAddListeRow);
            this.panel1.Controls.Add(this.EtiketId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 38);
            this.panel1.TabIndex = 32;
            // 
            // BtnRowsDel
            // 
            this.BtnRowsDel.BackgroundImage = global::IEA_ErpProject.Properties.Resources.clean;
            this.BtnRowsDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRowsDel.Location = new System.Drawing.Point(974, 2);
            this.BtnRowsDel.Name = "BtnRowsDel";
            this.BtnRowsDel.Size = new System.Drawing.Size(41, 35);
            this.BtnRowsDel.TabIndex = 2;
            this.BtnRowsDel.UseVisualStyleBackColor = true;
            this.BtnRowsDel.Click += new System.EventHandler(this.BtnRowsDel_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(748, 2);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ekle :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnAddListeRow
            // 
            this.BtnAddListeRow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddListeRow.BackgroundImage = global::IEA_ErpProject.Properties.Resources.free_plus_icon_321_thumb;
            this.BtnAddListeRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddListeRow.Location = new System.Drawing.Point(829, 2);
            this.BtnAddListeRow.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddListeRow.Name = "BtnAddListeRow";
            this.BtnAddListeRow.Size = new System.Drawing.Size(42, 36);
            this.BtnAddListeRow.TabIndex = 0;
            this.BtnAddListeRow.UseVisualStyleBackColor = false;
            this.BtnAddListeRow.Click += new System.EventHandler(this.BtnAddListeRow_Click);
            // 
            // EtiketId
            // 
            this.EtiketId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EtiketId.Location = new System.Drawing.Point(27, 10);
            this.EtiketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiketId.Name = "EtiketId";
            this.EtiketId.Size = new System.Drawing.Size(102, 20);
            this.EtiketId.TabIndex = 15;
            this.EtiketId.Text = "---";
            this.EtiketId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtAciklama.Location = new System.Drawing.Point(0, 372);
            this.TxtAciklama.Multiline = true;
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(387, 134);
            this.TxtAciklama.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(0, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 31);
            this.label8.TabIndex = 29;
            this.label8.Text = "Açıklama";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTarih
            // 
            this.TxtTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtTarih.Location = new System.Drawing.Point(0, 317);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(387, 24);
            this.TxtTarih.TabIndex = 28;
            this.TxtTarih.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Giriş Tarihi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtFaturaNo
            // 
            this.TxtFaturaNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtFaturaNo.Location = new System.Drawing.Point(0, 266);
            this.TxtFaturaNo.Name = "TxtFaturaNo";
            this.TxtFaturaNo.Size = new System.Drawing.Size(387, 20);
            this.TxtFaturaNo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(0, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 33);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fatura No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtGirisTuru
            // 
            this.TxtGirisTuru.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtGirisTuru.FormattingEnabled = true;
            this.TxtGirisTuru.Items.AddRange(new object[] {
            "Normal Giris",
            "Muhtelif Giris"});
            this.TxtGirisTuru.Location = new System.Drawing.Point(0, 212);
            this.TxtGirisTuru.Name = "TxtGirisTuru";
            this.TxtGirisTuru.Size = new System.Drawing.Size(387, 21);
            this.TxtGirisTuru.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(0, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giriş Türü";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCariAdi
            // 
            this.TxtCariAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCariAdi.Location = new System.Drawing.Point(0, 136);
            this.TxtCariAdi.Multiline = true;
            this.TxtCariAdi.Name = "TxtCariAdi";
            this.TxtCariAdi.Size = new System.Drawing.Size(387, 45);
            this.TxtCariAdi.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(0, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cari Adı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCariTur
            // 
            this.TxtCariTur.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCariTur.FormattingEnabled = true;
            this.TxtCariTur.Items.AddRange(new object[] {
            "Doktor",
            "Firma",
            "Hastane",
            "Personel",
            "Diger"});
            this.TxtCariTur.Location = new System.Drawing.Point(0, 84);
            this.TxtCariTur.Name = "TxtCariTur";
            this.TxtCariTur.Size = new System.Drawing.Size(387, 21);
            this.TxtCariTur.TabIndex = 20;
            this.TxtCariTur.SelectedIndexChanged += new System.EventHandler(this.TxtCariTur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(0, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cari Türü";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtGirisId
            // 
            this.TxtGirisId.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtGirisId.Location = new System.Drawing.Point(0, 33);
            this.TxtGirisId.Name = "TxtGirisId";
            this.TxtGirisId.Size = new System.Drawing.Size(387, 20);
            this.TxtGirisId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giriş No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1418, 701);
            this.Controls.Add(this.SpcUrunGiris);
            this.Controls.Add(this.PnlUrunGiris);
            this.Name = "UrunGiris";
            this.Text = "UrunGiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UrunGiris_Load);
            this.PnlUrunGiris.ResumeLayout(false);
            this.SpcUrunGiris.Panel1.ResumeLayout(false);
            this.SpcUrunGiris.Panel2.ResumeLayout(false);
            this.SpcUrunGiris.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcUrunGiris)).EndInit();
            this.SpcUrunGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlUrunGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.SplitContainer SpcUrunGiris;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker TxtTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtFaturaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TxtGirisTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCariAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TxtCariTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGirisId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRowsDel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnAddListeRow;
        private System.Windows.Forms.Label EtiketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKTarih;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Durum;
    }
}