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
using IEA_ErpProject.Properties;
using IEA_ErpProject.Fonksiyonlar;

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastaneGiris : Form

    {
        //global Area
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public int secimId = -1;
        private tblHastaneler kayitBul;
        Formlar f = new Formlar();
        public HastaneGiris()
        {
            InitializeComponent();
        }

        private void HastaneGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();

        }

        private void ComboDoldur()
        {
            TxtHTipi.DataSource = _db.tblHastaneTipleri.ToList();  //select * from tblHastaneTipleri
            TxtHTipi.ValueMember = "Id";
            TxtHTipi.DisplayMember = "TipAdi";
            TxtHTipi.SelectedIndex = -1;

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayıt();
        }

        private void YeniKayıt()
        {
            if (TxtHadi.Text == "")
            {
                return;
            }
            try
            {
                tblHastaneler hst = new tblHastaneler();
                hst.Adi = TxtHadi.Text;
                hst.Adres = TxtAdres.Text;
                hst.CariAdi = TxtCariHadi.Text;
                if (TxtSehir.SelectedValue != null)
                {
                    hst.SehirId = (int)TxtSehir.SelectedValue;
                }
                if (TxtHTipi.SelectedValue != null)
                {
                    hst.TipId = (int)TxtHTipi.SelectedValue;
                }

                hst.VergiDairesi = TxtVergiDairesi.Text;
                hst.VergiNo = TxtVergiNo.Text;
                hst.Tel = TxtTelefon.Text;

                _db.tblHastaneler.Add(hst);
                _db.SaveChanges();
                MessageBox.Show("Kayıt işlemi gerçekleştirilmiştir");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata Kodu : HGK100");
            }


        }

        private void Temizle()
        {
            //TxtVergiNo.Text = "";
            //TxtVergiNo.Clear();
            foreach (Control k in ScHastane.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }
            }
            TxtHTipi.SelectedIndex = -1;
            TxtSehir.SelectedIndex = -1;
            secimId = -1;
            kayitBul = null;
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;

        }
        List<tblHastaneler> hstList;
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            hstList = (from s in _db.tblHastaneler select s).ToList();
            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = sira;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.tblHastaneTipleri.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.name;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {

            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }
            Ac(secimId);
        }

        public void Ac(int secimId)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Kayır ID Bulunamamıştır.");
                return;

            }
            //tblHastaneler kayitBul = _db.tblHastaneler.Find(secimId);
            BtnDetayEkle.Visible = true;
            BtnDetayGoster.Visible = true;
            kayitBul = hstList.FirstOrDefault(x => x.Id == secimId);

            if (kayitBul != null)
            {
                TxtVergiNo.Text = kayitBul.VergiNo;
                TxtHTipi.Text = kayitBul.tblHastaneTipleri.TipAdi;
                TxtSehir.Text = kayitBul.Sehirler.name;
                TxtAdres.Text = kayitBul.Adres;
                TxtHadi.Text = kayitBul.Adi;
                TxtTelefon.Text = kayitBul.Tel;
                TxtVergiDairesi.Text = kayitBul.VergiDairesi;
                TxtCariHadi.Text = kayitBul.CariAdi;
                TxtHastaneBul.Text = kayitBul.Id.ToString().PadLeft(5,'0');   
            }
           



        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            secimId = -1;
            kayitBul = null;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (secimId < 0)
            {
                MessageBox.Show("Güncelleme yapılacak alan bulunamadı");
                return;
            }

            try
            {
                if (kayitBul != null)
                {
                    kayitBul.Adi = TxtHadi.Text;
                    kayitBul.Adres = TxtAdres.Text;
                    kayitBul.CariAdi = TxtCariHadi.Text;
                    kayitBul.Tel = TxtTelefon.Text;
                    kayitBul.VergiDairesi = TxtVergiDairesi.Text;
                    kayitBul.SehirId = (int?)TxtSehir.SelectedValue;
                    kayitBul.TipId = (int)TxtHTipi.SelectedValue;
                    kayitBul.VergiNo = TxtVergiNo.Text;

                }
                _db.SaveChanges();
                MessageBox.Show("Güncelleme Yapıldı");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Silinecek Kaydı Seç!");
                return;
            }
            DialogResult dr=MessageBox.Show("Bak kardeşim bu ciddi bir işlem! Sildikten sonra sistem adminine vay efendim ben kayıt sildim deme!!","Silme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Sil();
            }
            
        }

        private void Sil()
        {
            
             if (secimId>0)
            {
                _db.tblHastaneler.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydınız Silinmiştir Geçmiş Olsun");
                Temizle();
                Listele();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn=new Button();
            btn.Size = new Size(25, TxtHastaneBul.ClientSize.Height + 1);
            btn.Location = new Point(TxtHastaneBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TxtHastaneBul.Controls.Add(btn);
            btn.Dock = DockStyle.Left;
            
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            int Id=f.HastanelerListesiAc(true);
            if (Id > 0)
            {
                Ac(Id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {
            string adi = "";
            int id = -1 ;
            if (secimId > 0)
            {
                adi = TxtHadi.Text;
                id = int.Parse(TxtHastaneBul.Text);
                f.HastaneDetayAc(adi,id);
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yaparmısındır");
            }
        }

        private void BtnDetayGoster_Click(object sender, EventArgs e)
        {
            HastaneDetayGoster goster=new HastaneDetayGoster();
            goster.Hadi = TxtHadi.Text;
            goster.ShowDialog();
        }

        private void TxtHastaneBul_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






