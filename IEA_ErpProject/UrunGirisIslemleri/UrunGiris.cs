using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.UrunGirisIslemleri
{
    public partial class UrunGiris : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private readonly Formlar f = new Formlar();
        private readonly Numaralar _n=new Numaralar();
        private int girisId = -1;
        private List<tblUrunGirisAlt> altList;
        public string[] MyArray { get; set; }
        public UrunGiris()
        {
            InitializeComponent();
        }
        private void UrunGiris_Load(object sender, EventArgs e)
        {
            TxtGirisId.Text = _n.UGirisNo();
            MyArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray();
            Liste.Rows.Clear();
            Liste.AllowUserToAddRows = false;
        }


        private void TxtCariTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    if (TxtCariTur.Text=="Hastane")
            //    {
            //        TxtCariAdi.Text = "Hastane";
            //    }
            //    if (TxtCariTur.Text == "Doktor")
            //    {
            //        TxtCariAdi.Text = "Berkant";
            //    }
            //    if (TxtCariTur.Text == "Personel")
            //    {
            //        TxtCariAdi.Text = "Omer";
            //    }
            //    if (TxtCariTur.Text == "Firma")
            //    {
            //        TxtCariAdi.Text = "Google";
            //    }
            //    if (TxtCariTur.Text == "Diger")
            //    {
            //        TxtCariAdi.Text = "Diger";
            //    }

            //switch (TxtCariTur.Text)
            //{
            //    case "Hastane":
            //        TxtCariAdi.Text = "Acibadem";
            //        break;
            //    case "Doktor":
            //        TxtCariAdi.Text = "Omer Taser";
            //        break;
            //    case "Personel":
            //        TxtCariAdi.Text = "Onur";
            //        break;
            //    case "Firma":
            //        TxtCariAdi.Text = "Google";
            //        break;
            //    case "Diger":
            //        TxtCariAdi.Text = "Bilinmiyor";
            //        break;
            //}


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
           
            
            var btnGiris = new Button();
            btnGiris.Size = new Size(22, TxtGirisId.ClientSize.Height);
            btnGiris.Location = new Point(TxtGirisId.ClientSize.Width - btn.Width - 1);
            btnGiris.Cursor = Cursors.Default;
            btnGiris.BackgroundImage = Resources.Ara32x32;
            btnGiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiris.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtGirisId.Controls.Add(btnGiris);
            base.OnLoad(e);
            btn.Click += btn_Click;
            btnGiris.Click += btnGiris_Click;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int Id = f.UrunlerGirisListesiAc(true);
            if (Id > 0)
            {
                UrunAc(Id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int CariId = -1;
            switch (TxtCariTur.Text)
            {
                case "Hastane":
                    CariId = f.HastanelerListesiAc(true);
                    if (CariId > 0)
                    {
                        HastaneAc(CariId);
                    }
                    break;
                case "Doktor":
                    CariId = f.DoktorlarListesiAc(true);
                    if (CariId > 0)
                    {
                        DoktorAc(CariId);
                    }
                    break;
                case "Personel":
                    CariId = f.PersonellerListesiAc(true);
                    if (CariId > 0)
                    {
                        PersonelAc(CariId);
                    }
                    break;
                case "Firma":
                    CariId = f.FirmalarListesiAc(true);
                    if (CariId > 0)
                    {
                        FirmaAc(CariId);
                    }
                    break;
                case "Diger":
                    TxtCariAdi.Text = "Bilinmiyor";
                    break;
            }
            AnaSayfa.Aktarma = -1;
        }

        private void PersonelAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblPersoneller.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void FirmaAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblFirmalar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void HastaneAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblHastaneler.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void DoktorAc(int id)
        {
            TxtCariAdi.Text = _db.tblDoktorlar.FirstOrDefault(s => s.Id == id)?.Adi;
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if ((bool)Liste.CurrentRow.Cells[11].Value == false)
            {
                Liste.CurrentRow.Cells[2].ReadOnly = true;
                Liste.CurrentRow.Cells[3].ReadOnly = true;
                Liste.CurrentRow.Cells[4].ReadOnly = true;
            }
            try
            {
                

                TextBox txt=e.Control as TextBox;
                if (Liste.CurrentCell.ColumnIndex==3 && txt != null)
                {
                    txt.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
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
                Console.WriteLine(ex);
                throw;
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            if ((bool)Liste.CurrentRow.Cells[11].Value == false)
            {
                Liste.CurrentRow.Cells[2].ReadOnly = true;
                Liste.CurrentRow.Cells[3].ReadOnly = true;
                Liste.CurrentRow.Cells[4].ReadOnly = true;
            }
            if (e.ColumnIndex == 4)
            {
                foreach (DataGridViewCell cell in Liste.SelectedCells)
                {
                    if (cell.Value != null)
                    {
                        if (Liste.CurrentRow != null)
                        {
                            string ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                            string lot = Liste.CurrentRow.Cells[4].Value.ToString();
                            string barkod = ukod + "/" + lot;
                            Liste.CurrentRow.Cells[2].Value= barkod;


                            var sonuc = _db.tblStokDurum.Where(x => x.UrunKodu == ukod && x.LotSeriNo == lot).Select(s => s.Id).ToList();
                            if (sonuc.Count > 0)
                            {
                                Liste.CurrentRow.Cells[7].Value = sonuc[0];
                            }
                            else
                            {
                                Liste.CurrentRow.Cells[7].Value = 0;
                            }
                        }
                    }

                    
                }
            }

            if (e.ColumnIndex == 9)
            {
                if (Liste.CurrentRow.Cells[9].Value!=null||Liste.CurrentRow.Cells[9].Value.ToString()!="")
                {
                    var ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                    var lst = (from s in _db.tblUrunKayitUst where s.UrunKodu==ukod
                               select s.KullanimSuresi).FirstOrDefault() ;
                    try
                    {
                        
                        if (lst!=null)
                        {
                            DateTime ay = Convert.ToDateTime(Liste.CurrentRow.Cells[9].Value.ToString());
                            Liste.CurrentRow.Cells[10].Value = ay.AddMonths(Convert.ToInt32(lst)).ToShortDateString();
                        }
                        else
                        {
                            Liste.CurrentRow.Cells[10].Value = "01.01.0001";
                        }
                        
                    }
                    catch (Exception exx)
                    {
                        Console.WriteLine(exx);
                        throw;
                    }
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void YeniKaydet()
        {
            tblUrunGirisUst ust = new tblUrunGirisUst();
            ust.CariAdi = TxtCariAdi.Text;
            if (TxtCariTur.Text=="Doktor")
            {
                ust.CariId = _db.tblDoktorlar.FirstOrDefault(x => x.Adi == TxtCariAdi.Text).Id;
            }

            if (TxtCariTur.Text=="Hastane")
            {
                ust.CariId = _db.tblHastaneler.FirstOrDefault(x => x.Adi == TxtCariAdi.Text).Id;
            }
            if (TxtCariTur.Text == "Firma")
            {
                ust.CariId = _db.tblFirmalar.FirstOrDefault(x => x.Adi == TxtCariAdi.Text).Id;
            }
            else
            {
                ust.CariId = -1;
            }

            ust.CariTip = TxtCariTur.Text;
            ust.CreatedDate=DateTime.Now;
            ust.CreatedUser = -1;
            ust.FaturaNo = TxtFaturaNo.Text;
            ust.GirisId = int.Parse(TxtGirisId.Text);
            ust.GirisTarih = TxtTarih.Value;
            ust.GirisTuru = TxtGirisTuru.Text;
            ust.UpdateDate=DateTime.Now;
            ust.UpdateUser = -1;
            ust.isDeleted = false;
            ust.Aciklama = TxtAciklama.Text;
            _db.tblUrunGirisUst.Add(ust);
            _db.SaveChanges();


            Liste.AllowUserToAddRows = false;
            tblUrunGirisAlt[] alts = new tblUrunGirisAlt[Liste.RowCount];
            //tblStokDurum[] durums = new tblStokDurum[Liste.RowCount]; İşlem Trgger'a yönlendirildiğinden kapatıldı
            for (int i = 0; i < Liste.RowCount; i++)
            {
                #region Trigger a atanan işlem
                //if (Convert.ToInt32(Liste.Rows[i].Cells[7].Value)== 0)
                //{
                //    durums[i] = new tblStokDurum();
                //    durums[i].UrunKodu=Liste.Rows[i].Cells[3].Value.ToString();
                //    durums[i].Barkod=Liste.Rows[i].Cells[2].Value.ToString();
                //    durums[i].LotSeriNo=Liste.Rows[i].Cells[4].Value.ToString();
                //    durums[i].BransNo = "";
                //    durums[i].KonsinyeAdet = 0;
                //    durums[i].RafAdet= Convert.ToInt32(Liste.Rows[i].Cells[5].Value); 
                //    durums[i].StokAdet= Convert.ToInt32(Liste.Rows[i].Cells[5].Value); 
                //    durums[i].SKTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);
                //    durums[i].SubeAdet = 0;
                //    durums[i].SutKodu = "";
                //    durums[i].UTarih= Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                //    durums[i].Uts = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                //    durums[i].UrunHareketAdet = 0;
                //    _db.tblStokDurum.Add(durums[i]);

                //}
                //else
                //{
                //    var urunId = Convert.ToInt32(Liste.Rows[i].Cells[7].Value);
                //    var srg = _db.tblStokDurum.FirstOrDefault(s => s.Id == urunId);
                //    srg.StokAdet += Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                //    srg.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[5].Value);

                //} 
                #endregion

                alts[i] = new tblUrunGirisAlt();
                
                alts[i].UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();
                alts[i].Aciklama = Liste.Rows[i].Cells[6].Value.ToString();
                alts[i].Barkod = Liste.Rows[i].Cells[2].Value.ToString();
                alts[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                alts[i].BransNo = "";
                alts[i].GirisAdet = Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                alts[i].UtsDurum = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                alts[i].SKTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);
                alts[i].Utarih = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                alts[i].GirisId = int.Parse(TxtGirisId.Text);
                alts[i].GirisTarih = TxtTarih.Value;




            }

            _db.tblUrunGirisAlt.AddRange(alts);
            _db.SaveChanges();
            MessageBox.Show("Bilgiler Kaydedildi");
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in SpcUrunGiris.Panel2.Controls)
            {
                if (item is TextBox ||item is ComboBox||item is DateTimePicker)
                {
                    item.Text = "";
                }
            }

            TxtGirisId.Text = _n.UGirisNo();
            Liste.Rows.Clear();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        public void UrunAc(int secimId)
        {
            girisId = secimId;
            var srg = _db.tblUrunGirisUst.FirstOrDefault(x => x.GirisId == secimId);
            if (srg != null)
            {
                TxtGirisId.Text = srg.GirisId.ToString().PadLeft(7,'0');
                TxtCariTur.Text = srg.CariTip;
                TxtCariAdi.Text = srg.CariAdi;
                TxtGirisTuru.Text = srg.GirisTuru;
                TxtFaturaNo.Text = srg.FaturaNo;
                TxtTarih.Text = srg.GirisTarih.ToString();
                TxtAciklama.Text = srg.Aciklama;
            }
            else
            {
                MessageBox.Show("İstek sırasında bir sorun oldu tekrar deneyin");
                return;
                
            }
            Liste.Rows.Clear();
            Liste.AllowUserToAddRows=false;
            altList = _db.tblUrunGirisAlt.Where(s => s.GirisId == secimId).ToList();
            for (int i = 0; i < altList.Count; i++)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[1].Value = i + 1;
                Liste.Rows[i].Cells[0].Value = altList[i].Id;
                Liste.Rows[i].Cells[2].Value = altList[i].Barkod;
                Liste.Rows[i].Cells[3].Value = altList[i].UrunKodu;
                Liste.Rows[i].Cells[4].Value = altList[i].LotSeriNo;
                Liste.Rows[i].Cells[5].Value = altList[i].GirisAdet;
                Liste.Rows[i].Cells[6].Value = altList[i].Aciklama;
                Liste.Rows[i].Cells[7].Value = altList[i].GirisId;
                Liste.Rows[i].Cells[8].Value = altList[i].UtsDurum;
                Liste.Rows[i].Cells[9].Value = altList[i].Utarih;
                Liste.Rows[i].Cells[10].Value =altList[i].SKTarih;
                Liste.Rows[i].Cells[11].Value = false;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (girisId==-1)
            {
                MessageBox.Show("Güncelleme için bir kayıt seçin");
            }

            var srg = _db.tblUrunGirisUst.FirstOrDefault(x => x.GirisId == girisId);

            srg.GirisId = int.Parse(TxtGirisId.Text);
            srg.CariTip = TxtCariTur.Text;
            srg.CariAdi = TxtCariAdi.Text;
            srg.GirisTuru = TxtGirisTuru.Text;
            srg.FaturaNo = TxtFaturaNo.Text;
            srg.GirisTarih = TxtTarih.Value;
            srg.Aciklama = TxtAciklama.Text;

            _db.SaveChanges();

            var lst = (from s in _db.tblUrunGirisAlt
                where s.GirisId == girisId
                select s).ToList();
            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool) Liste.Rows[i].Cells[11].Value == false)
                {
                    string newBarkod = Liste.Rows[i].Cells[3].Value.ToString() + "/" +
                                       Liste.Rows[i].Cells[4].Value.ToString();

                    string brk = Liste.Rows[i].Cells[2].Value.ToString();
                    var stk = _db.tblStokDurum.FirstOrDefault(s => s.Barkod == brk);

                    //stk.Barkod = newBarkod;
                    // stk.UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();  >Bunlar değişemez çünkü çok büyük sorunlara sebep oluyorlar 
                    //stk.LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                    var adet = altList[i].GirisAdet - Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                    stk.StokAdet -= adet;
                    stk.RafAdet -= adet;

                    //lst[i].Barkod = newBarkod;
                    //lst[i].UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();
                    //lst[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                    lst[i].GirisAdet = Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                    lst[i].Aciklama = Liste.Rows[i].Cells[6].Value.ToString();
                    lst[i].GirisTarih = TxtTarih.Value;
                    lst[i].BransNo = "";
                    lst[i].UtsDurum = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    lst[i].Utarih = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                    lst[i].SKTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);

                    
                }
                else
                {
                    
                    tblUrunGirisAlt[] alts = new tblUrunGirisAlt[Liste.RowCount];
                    //tblStokDurum[] durums = new tblStokDurum[Liste.RowCount]; İşlem Trgger'a yönlendirildiğinden kapatıldı
                   
                        #region Trigger a atanan işlem

                        //if (Convert.ToInt32(Liste.Rows[i].Cells[7].Value)== 0)
                        //{
                        //    durums[i] = new tblStokDurum();
                        //    durums[i].UrunKodu=Liste.Rows[i].Cells[3].Value.ToString();
                        //    durums[i].Barkod=Liste.Rows[i].Cells[2].Value.ToString();
                        //    durums[i].LotSeriNo=Liste.Rows[i].Cells[4].Value.ToString();
                        //    durums[i].BransNo = "";
                        //    durums[i].KonsinyeAdet = 0;
                        //    durums[i].RafAdet= Convert.ToInt32(Liste.Rows[i].Cells[5].Value); 
                        //    durums[i].StokAdet= Convert.ToInt32(Liste.Rows[i].Cells[5].Value); 
                        //    durums[i].SKTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);
                        //    durums[i].SubeAdet = 0;
                        //    durums[i].SutKodu = "";
                        //    durums[i].UTarih= Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                        //    durums[i].Uts = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                        //    durums[i].UrunHareketAdet = 0;
                        //    _db.tblStokDurum.Add(durums[i]);

                        //}
                        //else
                        //{
                        //    var urunId = Convert.ToInt32(Liste.Rows[i].Cells[7].Value);
                        //    var srg = _db.tblStokDurum.FirstOrDefault(s => s.Id == urunId);
                        //    srg.StokAdet += Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                        //    srg.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[5].Value);

                        //} 

                        #endregion

                        alts[i] = new tblUrunGirisAlt();

                        alts[i].UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();
                        alts[i].Aciklama = Liste.Rows[i].Cells[6].Value.ToString();
                        alts[i].Barkod = Liste.Rows[i].Cells[2].Value.ToString();
                        alts[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                        alts[i].BransNo = "";
                        alts[i].GirisAdet = Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                        alts[i].UtsDurum = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                        alts[i].SKTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);
                        alts[i].Utarih = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                        alts[i].GirisId = int.Parse(TxtGirisId.Text);
                        alts[i].GirisTarih = TxtTarih.Value;
                        _db.tblUrunGirisAlt.Add(alts[i]);
                        
                }
                
            }
            _db.SaveChanges();
            MessageBox.Show("Bilgiler Güncellendi");
            Temizle();
        }

        private void BtnAddListeRow_Click(object sender, EventArgs e)
        {
            Liste.Rows.Add();
            var srg = Liste.RowCount;
            if (Liste.CurrentRow != null) Liste.Rows[srg - 1].Cells[11].Value = true;
        }

        private void PnlUrunGiris_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)Liste.CurrentRow.Cells[11].Value == false)
            {
                Liste.CurrentRow.Cells[2].ReadOnly = true;
                Liste.CurrentRow.Cells[3].ReadOnly=true;
                Liste.CurrentRow.Cells[4].ReadOnly=true;

            }
        }

        private void BtnRowsDel_Click(object sender, EventArgs e)
        {

        }
    }
}
        

    

