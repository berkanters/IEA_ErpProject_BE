using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.BilgiGiris.Urunler
{
    public partial class UrunKayit : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private Numaralar n = new Numaralar();
        private Resimler r = new Resimler();
        private bool _resim = false;
        OpenFileDialog _dosya = new OpenFileDialog();
        private Formlar f = new Formlar();


        public UrunKayit()
        {
            InitializeComponent();
        }


        private void UrunKayit_Load(object sender, EventArgs e)
        {
            TxtUrunId.Text = n.UidNo();
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void ResimSec()
        {
            _dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (_dosya.ShowDialog() == DialogResult.OK)
            {
                pbResim.ImageLocation = _dosya.FileName;
                _resim = true;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtUrunId.ClientSize.Height + 1);
            btn.Location = new Point(TxtUrunId.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TxtUrunId.Controls.Add(btn);
            btn.Dock = DockStyle.Left;

            base.OnLoad(e);
            btn.Click += BtnUrun_Click;

            var btnFirma = new Button();
            btnFirma.Size = new Size(25, TxtFirmaKodu.ClientSize.Height + 1);
            btnFirma.Location = new Point(TxtFirmaKodu.ClientSize.Width - btnFirma.Width - 1);
            btnFirma.Cursor = Cursors.Default;
            btnFirma.BackgroundImage = Resources.Ara32x32;
            btnFirma.BackgroundImageLayout = ImageLayout.Stretch;
            btnFirma.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TxtFirmaKodu.Controls.Add(btnFirma);
            btnFirma.Dock = DockStyle.Left;

            base.OnLoad(e);
            btnFirma.Click += BtnFirma_Click;
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            int Id = f.UrunKayitListesiAc(true);
            if (Id > 0)
            {
                UrunAc(Id);
            }
            AnaSayfa.Aktarma = -1;
        }
        private int secimId = -1;
        public void UrunAc(int uid)
        {
            Temizle();
            secimId = uid;
            Liste.Rows.Clear();
            Liste.AllowUserToAddRows = false;
           
            tblUrunKayitUst lst = _db.tblUrunKayitUst.FirstOrDefault(s=>s.Uid == uid);
               TxtAciklamaEng.Text = lst.AciklamaEng;
               TxtAciklamaTr.Text = lst.AciklamaTr;
               TxtGirisTarih.Text = lst.GirisTarih.ToString();
            if (lst.FirmaId != null)
            {
                TxtFirmaKodu.Text = lst.FirmaId.ToString();
                TxtFirmaAdi.Text = lst.tblFirmalar.Adi;
            }
               TxtUrunId.Text = lst.Uid.ToString().PadLeft(7,'0');
               TxtUrunKodu.Text = lst.UrunKodu;
               if(lst.Resim != null)  pbResim.Image = r.ResimGetirme(lst.Resim);
            TxtKullanimSuresi.Text = lst.KullanimSuresi.ToString();
            EtiketId.Text=lst.Id.ToString().PadLeft(7,'0');

            var UrunAlt = _db.tblUrunKayitAlt.Where(x => x.Uid == uid).ToList();
            int i = 0;
            foreach (var alt in UrunAlt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = alt.GMDMKodu;
                Liste.Rows[i].Cells[1].Value = alt.UNSPCKodu;
                Liste.Rows[i].Cells[2].Value = alt.SB;
                Liste.Rows[i].Cells[3].Value = alt.KullanimDisi;
                Liste.Rows[i].Cells[4].Value = alt.Ubb;
                Liste.Rows[i].Cells[5].Value = alt.Sut;
                Liste.Rows[i].Cells[6].Value = alt.SutFiyat;
                Liste.Rows[i].Cells[7].Value = alt.SutAciklama;
                Liste.Rows[i].Cells[8].Value = alt.UTS;
                Liste.Rows[i].Cells[9].Value = false;
                Liste.Rows[i].Cells[10].Value = alt.Id;
                i++;
                TxtSinifi.Text = alt.Sinif;
                TxtParaBirim.Text = alt.ParaBirimi;
                TxtMinFiyat.Text = alt.MinFiyat.ToString();
                TxtBirimFiyat.Text= alt.BirimFiyat.ToString();


            }
            

            //Liste.AllowUserToAddRows = false;
            //Liste.AllowUserToDeleteRows = false;
            //Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            //Liste.ReadOnly=true;
        }

        private void BtnFirma_Click(object sender, EventArgs e)
        {
            int Id = f.FirmalarListesiAc(true);
            if (Id > 0)
            {
                FirmaAc(Id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void FirmaAc(int id)
        {
            int cariId = id;
            tblFirmalar frm = _db.tblFirmalar.First(s => s.Id == cariId);
            TxtFirmaKodu.Text = frm.Id.ToString().PadLeft(7, '0');
            TxtFirmaAdi.Text = frm.Adi;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            if (TxtUrunId.Text == "" || TxtUrunKodu.Text == "" || TxtFirmaKodu.Text =="")
            {
                MessageBox.Show("İlgili Alanları Doldur");
                Liste.AllowUserToAddRows = true;
                return;
            }
            tblUrunKayitUst ust = new tblUrunKayitUst();
            ust.AciklamaEng = TxtAciklamaEng.Text;
            ust.AciklamaTr = TxtAciklamaTr.Text;
            ust.GirisTarih = TxtGirisTarih.Value;
            ust.FirmaId = int.Parse(TxtFirmaKodu.Text);
            if (pbResim.Image != null) ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray();
            ust.Uid = int.Parse(TxtUrunId.Text);
            ust.UrunKodu = TxtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(TxtKullanimSuresi.Text);

            _db.tblUrunKayitUst.Add(ust);

            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                alt[i] = new tblUrunKayitAlt();
                alt[i].Aciklama = TxtAciklamaTr.Text;
                alt[i].BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                alt[i].BransAdi = "";
                alt[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                alt[i].UNSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                alt[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                alt[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                alt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                alt[i].ParaBirimi = TxtParaBirim.Text;
                alt[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                alt[i].Sinif = TxtSinifi.Text;
                alt[i].Uid = int.Parse(TxtUrunId.Text);
                alt[i].UIKodu = TxtUrunId.Text;

               


                _db.tblUrunKayitAlt.Add(alt[i]);

            }






            _db.SaveChanges();

            MessageBox.Show("Kayıt yabdın hll");
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in SpcUrunKayit.Panel1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    if (item.Name != TxtUrunId.Name)
                    {
                        item.Text = "";
                    }

                }
                pbResim.Image = null;
            }
            Liste.Rows.Clear();
           // Liste.Rows.Add();
            TxtUrunId.Text = n.UidNo();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            

            int a = Convert.ToInt32(TxtUrunId.Text);
            tblUrunKayitUst ust = _db.tblUrunKayitUst.FirstOrDefault(x => x.Uid == a );
            Liste.AllowUserToAddRows = false;

            ust.AciklamaEng = TxtAciklamaEng.Text;
            ust.AciklamaTr = TxtAciklamaTr.Text;
            ust.GirisTarih = TxtGirisTarih.Value;
            ust.FirmaId = int.Parse(TxtFirmaKodu.Text);
            //if (pbResim.Image != null) ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray();
            ust.Uid = int.Parse(TxtUrunId.Text);
            ust.UrunKodu = TxtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(TxtKullanimSuresi.Text);
            

            _db.SaveChanges();

            tblUrunKayitAlt[] UrunAlt = _db.tblUrunKayitAlt.Where(s => s.Uid == a).ToArray();

            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool)Liste.Rows[i].Cells[9].Value==false)
                {
                    int IndexId = UrunAlt[i].Id;
                    UrunAlt[i] = _db.tblUrunKayitAlt.FirstOrDefault(s => s.Id == IndexId);
                    UrunAlt[i].BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    UrunAlt[i].BransAdi = "";
                    UrunAlt[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                    UrunAlt[i].UNSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                    UrunAlt[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                    UrunAlt[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                    UrunAlt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    UrunAlt[i].ParaBirimi = TxtParaBirim.Text;
                    UrunAlt[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                    UrunAlt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    UrunAlt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    UrunAlt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                    UrunAlt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                    UrunAlt[i].Sinif = TxtSinifi.Text;
                    UrunAlt[i].Uid = int.Parse(TxtUrunId.Text);
                    UrunAlt[i].UIKodu = TxtUrunId.Text;
                }
                else
                {
                    tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];
                    alt[i] = new tblUrunKayitAlt();
                    
                    alt[i].BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    alt[i].BransAdi = "";
                    alt[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                    alt[i].UNSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                    alt[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                    alt[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                    alt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    alt[i].ParaBirimi = TxtParaBirim.Text;
                    alt[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                    alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                    alt[i].Sinif = TxtSinifi.Text;
                    alt[i].Uid = int.Parse(TxtUrunId.Text);
                    alt[i].UIKodu = TxtUrunId.Text;
                    _db.tblUrunKayitAlt.Add(alt[i]);
                }
               

                _db.SaveChanges();
            }
           
            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void BtnAddListeRow_Click(object sender, EventArgs e)
        {
            
            Liste.Rows.Add();
            var srg = Liste.RowCount;
            if (Liste.CurrentRow != null) Liste.Rows[srg - 1].Cells[9].Value = true;
           // Liste.AllowUserToAddRows = true;
            
            
        }

        private void BtnRowsDel_Click(object sender, EventArgs e)
        {
            
            if(secimId < 0)
            {
                MessageBox.Show("Önce bir kayıt seçin");
                return;
            }
            tblUrunKayitAlt[] alt=new tblUrunKayitAlt[Liste.Rows.Count];
            int say=0;
            for (int i = 0; i < Liste.RowCount; i++)

            {
                if ((bool)Liste.Rows[i].Cells[9].Value==true)
                {
                    var srg= _db.tblUrunKayitAlt.Find(Liste.Rows [i].Cells[10].Value);
                    _db.tblUrunKayitAlt.Remove(srg);
                    say++;
                }
               
            }
            if(_db.SaveChanges() > 0 )
            {
                MessageBox.Show("Satır Silme işlemi yapıldı");
                UrunAc(Int32.Parse(TxtUrunId.Text));
            }
            else
            {
                MessageBox.Show("Satır Silme işlemi bilinmeyen bir sebepten ötürü yapılamadı");
            }
           
            if (say== 0)
            {
                MessageBox.Show("Silinecek satır yok. Silmek sitediğiniz satırın Durum hücresini işaretleyiniz");
                return;
            }
            
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var srg= _db.tblUrunKayitUst.Find(int.Parse(EtiketId.Text));
            var uid = _db.tblUrunKayitAlt.Where(s => s.Uid == srg.Uid);
            _db.tblUrunKayitUst.Remove(srg);
            if (_db.SaveChanges()> 0)
            {
                MessageBox.Show("Satır Silme işlemi yapıldı");
            }
        }
    }
}
