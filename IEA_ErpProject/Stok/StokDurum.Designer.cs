namespace IEA_ErpProject.Stok
{
    partial class StokDurum
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListeStok = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListeSube = new System.Windows.Forms.DataGridView();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.ListeKonsinye = new System.Windows.Forms.DataGridView();
            this.ListeUrunHareket = new System.Windows.Forms.DataGridView();
            this.TcStokDurum = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListeStok1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRafAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKonsiyeAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSubeAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrunHareket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sUretimT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RafAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).BeginInit();
            this.TcStokDurum.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TcStokDurum);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer1.Panel2.Controls.Add(this.ListeSube);
            this.splitContainer1.Panel2.Controls.Add(this.splitter3);
            this.splitContainer1.Panel2.Controls.Add(this.splitter2);
            this.splitContainer1.Panel2.Controls.Add(this.ListeKonsinye);
            this.splitContainer1.Panel2.Controls.Add(this.ListeUrunHareket);
            this.splitContainer1.Size = new System.Drawing.Size(1142, 724);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 0;
            // 
            // ListeStok
            // 
            this.ListeStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sBarkod,
            this.sUrunKodu,
            this.sLotSeri,
            this.sStokAdet,
            this.sRafAdet,
            this.sKonsiyeAdet,
            this.sSubeAdet,
            this.sUrunHareket,
            this.sUts,
            this.sUretimT,
            this.sSKT});
            this.ListeStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok.Location = new System.Drawing.Point(3, 3);
            this.ListeStok.Name = "ListeStok";
            this.ListeStok.Size = new System.Drawing.Size(921, 344);
            this.ListeStok.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 376);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 376);
            this.panel1.TabIndex = 0;
            // 
            // ListeSube
            // 
            this.ListeSube.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ListeSube.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeSube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeSube.GridColor = System.Drawing.SystemColors.Control;
            this.ListeSube.Location = new System.Drawing.Point(243, 0);
            this.ListeSube.Name = "ListeSube";
            this.ListeSube.Size = new System.Drawing.Size(652, 336);
            this.ListeSube.TabIndex = 4;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(895, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 336);
            this.splitter3.TabIndex = 3;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(240, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 336);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // ListeKonsinye
            // 
            this.ListeKonsinye.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ListeKonsinye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeKonsinye.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListeKonsinye.Location = new System.Drawing.Point(898, 0);
            this.ListeKonsinye.Name = "ListeKonsinye";
            this.ListeKonsinye.Size = new System.Drawing.Size(240, 336);
            this.ListeKonsinye.TabIndex = 1;
            // 
            // ListeUrunHareket
            // 
            this.ListeUrunHareket.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ListeUrunHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeUrunHareket.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListeUrunHareket.Location = new System.Drawing.Point(0, 0);
            this.ListeUrunHareket.Name = "ListeUrunHareket";
            this.ListeUrunHareket.Size = new System.Drawing.Size(240, 336);
            this.ListeUrunHareket.TabIndex = 0;
            // 
            // TcStokDurum
            // 
            this.TcStokDurum.Controls.Add(this.tabPage1);
            this.TcStokDurum.Controls.Add(this.tabPage2);
            this.TcStokDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcStokDurum.Location = new System.Drawing.Point(203, 0);
            this.TcStokDurum.Name = "TcStokDurum";
            this.TcStokDurum.SelectedIndex = 0;
            this.TcStokDurum.Size = new System.Drawing.Size(935, 376);
            this.TcStokDurum.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListeStok);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stok Durum-1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListeStok1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stok Durum-2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListeStok1
            // 
            this.ListeStok1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.UrunKodu,
            this.LotSeri,
            this.StokAdet,
            this.RafAdet});
            this.ListeStok1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok1.Location = new System.Drawing.Point(3, 3);
            this.ListeStok1.Name = "ListeStok1";
            this.ListeStok1.Size = new System.Drawing.Size(921, 344);
            this.ListeStok1.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // sBarkod
            // 
            this.sBarkod.HeaderText = "Barkod";
            this.sBarkod.Name = "sBarkod";
            this.sBarkod.Visible = false;
            // 
            // sUrunKodu
            // 
            this.sUrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sUrunKodu.HeaderText = "Urun Kodu";
            this.sUrunKodu.Name = "sUrunKodu";
            // 
            // sLotSeri
            // 
            this.sLotSeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sLotSeri.HeaderText = "Lot Seri No";
            this.sLotSeri.Name = "sLotSeri";
            // 
            // sStokAdet
            // 
            this.sStokAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sStokAdet.HeaderText = "Stok Adet";
            this.sStokAdet.Name = "sStokAdet";
            this.sStokAdet.Width = 79;
            // 
            // sRafAdet
            // 
            this.sRafAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sRafAdet.HeaderText = "Raf Adet";
            this.sRafAdet.Name = "sRafAdet";
            this.sRafAdet.Width = 74;
            // 
            // sKonsiyeAdet
            // 
            this.sKonsiyeAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sKonsiyeAdet.HeaderText = "Konsinye Adet";
            this.sKonsiyeAdet.Name = "sKonsiyeAdet";
            // 
            // sSubeAdet
            // 
            this.sSubeAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sSubeAdet.HeaderText = "Şube Adet";
            this.sSubeAdet.Name = "sSubeAdet";
            this.sSubeAdet.Width = 82;
            // 
            // sUrunHareket
            // 
            this.sUrunHareket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sUrunHareket.HeaderText = "Ürün Hareket";
            this.sUrunHareket.Name = "sUrunHareket";
            this.sUrunHareket.Width = 96;
            // 
            // sUts
            // 
            this.sUts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sUts.HeaderText = "Uts";
            this.sUts.Name = "sUts";
            this.sUts.Width = 29;
            // 
            // sUretimT
            // 
            this.sUretimT.HeaderText = "Üretim Tarihi";
            this.sUretimT.Name = "sUretimT";
            this.sUretimT.Visible = false;
            // 
            // sSKT
            // 
            this.sSKT.HeaderText = "Son Kullanma Tarihi";
            this.sSKT.Name = "sSKT";
            this.sSKT.Visible = false;
            // 
            // Barkod
            // 
            this.Barkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Ürün Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // LotSeri
            // 
            this.LotSeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LotSeri.HeaderText = "Lot Seri No";
            this.LotSeri.Name = "LotSeri";
            this.LotSeri.Width = 85;
            // 
            // StokAdet
            // 
            this.StokAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StokAdet.HeaderText = "Stok Adet";
            this.StokAdet.Name = "StokAdet";
            this.StokAdet.Width = 79;
            // 
            // RafAdet
            // 
            this.RafAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RafAdet.HeaderText = "Raf Adet";
            this.RafAdet.Name = "RafAdet";
            this.RafAdet.Width = 74;
            // 
            // StokDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 724);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StokDurum";
            this.Text = "StokDurum";
            this.Load += new System.EventHandler(this.StokDurum_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).EndInit();
            this.TcStokDurum.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView ListeStok;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ListeSube;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView ListeKonsinye;
        private System.Windows.Forms.DataGridView ListeUrunHareket;
        private System.Windows.Forms.TabControl TcStokDurum;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ListeStok1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRafAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKonsiyeAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSubeAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUrunHareket;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sUts;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUretimT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn RafAdet;
    }
}