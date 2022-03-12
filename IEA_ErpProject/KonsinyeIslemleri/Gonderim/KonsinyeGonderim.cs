using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Entity.Code;
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.KonsinyeIslemleri.Gonderim
{
    public partial class KonsinyeGonderim : Form
    {
        private readonly ErpProContext _code = new ErpProContext();
        private readonly ErpPro102SEntities _db=new ErpPro102SEntities();
        private Numaralar _n=new Numaralar();
        private readonly Formlar f = new Formlar();
        public bool Secim=false;
        private int gonderimId = -1;
        public string[] MyArray { get; set; }
        public KonsinyeGonderim()
        {
            InitializeComponent();
        }
        //public KonsinyeGonderim(ErpProContext code, ErpPro102SEntities db)
        //{
        //    _code=code;
        //    _db = db;
        //}

        private void KonsinyeGonderim_Load(object sender, EventArgs e)
        {
            TxtKonGonderimId.Text = _n.KonsinyeGonderimNo();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;
            tblKonsinyeGonderim[] Kon = new tblKonsinyeGonderim[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                Kon[i] = new tblKonsinyeGonderim();
                Kon[i].CariAdi = TxtCariAdi.Text;
                Kon[i].Aciklama = TxtKonGonAciklama.Text;
                Kon[i].Adet = Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                Kon[i].CariTur = TxtCariTur.Text;
                Kon[i].GonderimTarih = TxtKonGonTarih.Value;
                var brk = Liste.Rows[i].Cells[2].Value;
                Kon[i].UrunId = _db.tblStokDurum.FirstOrDefault(s => s.Barkod == brk).Id;
                //Kon[i].CreatedDate = DateTime.Now;
                //Kon[i].UpdateDate = DateTime.Now;
                //Kon[i].CreatedUser = 1;
                //Kon[i].UpdateUser = 1;
                //Kon[i].isDeleted = false;
                Kon[i].CariId = 1.ToString();
                Kon[i].GonderimId = int.Parse(_n.KonsinyeGonderimNo());
                    
                var srgStok = _db.tblStokDurum.Find(Kon[i].UrunId);
                srgStok.RafAdet -= Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                srgStok.KonsinyeAdet += Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                _db.SaveChanges();
            }

            _code.TblKonsinyeGonderimler.AddRange(Kon);
            _code.SaveChanges();
            MessageBox.Show("Kayıt İşlemi başarılı");
        }

        private void Liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Liste.CurrentCell.ColumnIndex == 4)
            {

                LotBul bul = new LotBul();
                if (Liste.CurrentRow.Cells[3]!=null)
                {
                    bul.ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                    bul.ShowDialog();
                }
            }
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            try
            {

                MyArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray();
                TextBox txt = e.Control as TextBox;
                if (Liste.CurrentCell.ColumnIndex == 3 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(MyArray);
                }
                else if (Liste.CurrentCell.ColumnIndex != 3 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.None;
                }

            }
            catch (Exception ex)
            {
                
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(22, TxtCariAdi.ClientSize.Height);
            btn.Location = new Point(TxtCariAdi.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtCariAdi.Controls.Add(btn);


            var btnGonderim = new Button();
            btnGonderim.Size = new Size(22, TxtKonGonderimId.ClientSize.Height);
            btnGonderim.Location = new Point(TxtKonGonderimId.ClientSize.Width - btnGonderim.Width - 1);
            btnGonderim.Cursor = Cursors.Default;
            btnGonderim.BackgroundImage = Resources.Ara32x32;
            btnGonderim.BackgroundImageLayout = ImageLayout.Stretch;
            btnGonderim.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtKonGonderimId.Controls.Add(btnGonderim);
            base.OnLoad(e);
            btn.Click += btn_Click;
            btnGonderim.Click += btnGonderim_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int cariId;
            switch (TxtCariTur.Text)
            {
                case "Hastane":
                    cariId = f.HastanelerListesiAc(true);
                    if (cariId > 0)
                    {
                        HastaneAc(cariId);
                    }
                    break;
                case "Doktor":
                    cariId = f.DoktorlarListesiAc(true);
                    if (cariId > 0)
                    {
                        DoktorAc(cariId);
                    }
                    break;
                case "Personel":
                    //CariId = f.PersonellerListesiAc(true);
                    //if (CariId > 0)
                    //{
                    //    DoktorAc(CariId);
                    //}
                    TxtCariAdi.Text = @"Yapim Asamasinda";
                    break;
                case "Firma":
                    cariId = f.FirmalarListesiAc(true);
                    if (cariId > 0)
                    {
                        FirmaAc(cariId);
                    }
                    break;
                case "Diger":
                    TxtCariAdi.Text = @"Bilinmiyor";
                    break;
            }
            AnaSayfa.Aktarma = -1;
        }
        private void FirmaAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblFirmalar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void DoktorAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblDoktorlar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void HastaneAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblHastaneler.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        

        private void btnGonderim_Click(object sender, EventArgs e)
        {
            int id = f.KonsinyeGonderimListesiAc(true);
            if (id > 0)
            {
                KonGonderimAc(id);
            }
            AnaSayfa.Aktarma = -1;
        }

       

        public void KonGonderimAc(int id)
        {
            Liste.Rows.Clear();
            var srg = _code.TblKonsinyeGonderimler.Where(s => s.GonderimId == id).ToList();
            var srgStok = _db.tblStokDurum.ToList();
            if (srg.Count > 0)
            {
                for (int i = 0; i < srg.Count; i++)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = srg[i].Id;
                    Liste.Rows[i].Cells[1].Value = i+1;
                    Liste.Rows[i].Cells[2].Value =srgStok.FirstOrDefault(s=>s.Id == srg[i].UrunId)?.Barkod;
                    Liste.Rows[i].Cells[3].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.UrunKodu;
                    Liste.Rows[i].Cells[4].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId) ?.LotSeriNo;
                    Liste.Rows[i].Cells[5].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.RafAdet;
                    Liste.Rows[i].Cells[6].Value = srg[i].Adet;
                    Liste.Rows[i].Cells[7].Value = srg[i].Aciklama;
                    Liste.Rows[i].Cells[8].Value = srg[i].UrunId;
                    Liste.Rows[i].Cells[9].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.Uts;
                    Liste.Rows[i].Cells[10].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.UTarih;
                    Liste.Rows[i].Cells[11].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.SKTarih;
                    Liste.Rows[i].Cells[12].Value = false;
                    TxtKonGonderimId.Text = srg[i].GonderimId.ToString();
                    TxtCariTur.Text = srg[i].CariTur;
                    TxtCariAdi.Text = srg[i].CariAdi;
                    TxtKonGonTarih.Text = srg[i].GonderimTarih.ToShortDateString();
                    TxtKonGonAciklama.Text = "";
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            if (gonderimId>0)
            {
                int i = 0;
                var srg = _code.TblKonsinyeGonderimler.Where(x => x.GonderimId == int.Parse(TxtKonGonderimId.Text))
                        .ToList();
                foreach (var item in srg)
                {
                    item.isDeleted = true;

                    var srgStok = _db.tblStokDurum.FirstOrDefault(x => x.Id == item.UrunId);
                    _code.SaveChanges();

                    srgStok.KonsinyeAdet -= Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                    srgStok.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                    _db.SaveChanges();
                }
            }
        }
    }

   
}
