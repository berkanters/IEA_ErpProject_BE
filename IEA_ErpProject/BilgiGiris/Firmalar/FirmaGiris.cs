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

namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    
    public partial class FirmaGiris : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public int secimId = -1;
        private tblFirmalar kayitBul;
        Formlar f = new Formlar();
        public FirmaGiris()
        {
            InitializeComponent();
        }

        private void FirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            TxtFTipi.DataSource = Enum.GetValues(typeof(FirmaTip));
            TxtFTipi.SelectedIndex = -1;

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (TxtFadi.Text == "")
            {
                return;
            }
            try
            {
                tblFirmalar frm = new tblFirmalar();
                frm.Adi = TxtFadi.Text;
                frm.Adres = TxtAdres.Text;
                frm.Email = TxtEmail.Text;
                if (TxtSehir.SelectedValue != null)
                {
                    frm.SehirId = (int)TxtSehir.SelectedValue;
                }
                //if (TxtFTipi.SelectedValue != null)
                //{
                //    frm.TipId = (int)TxtFTipi.SelectedValue;
                //}
                frm.VergiDairesi = TxtVergiDairesi.Text;
                frm.VergiNo = TxtVergiNo.Text;
                frm.Tel = TxtTelefon.Text;
                frm.FirmaTip = TxtFTipi.Text;

                _db.tblFirmalar.Add(frm);
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
        List<tblFirmalar> frmList;
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            frmList = (from s in _db.tblFirmalar select s).ToList();
            foreach (var item in frmList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = sira;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.FirmaTip;
                Liste.Rows[i].Cells[4].Value = item.Email;
                Liste.Rows[i].Cells[5].Value = item.Tel;
                Liste.Rows[i].Cells[6].Value = item.Sehirler.name;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Temizle()
        {
            foreach (Control k in ScHastane.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }
            }
            TxtFTipi.SelectedIndex = -1;
            TxtSehir.SelectedIndex = -1;
            secimId = -1;
            kayitBul = null;
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;
            BtnKaydet.Enabled = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }
            BtnKaydet.Enabled = false;
            Ac(secimId);

        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtFirmaBul.ClientSize.Height + 1);
            btn.Location = new Point(TxtFirmaBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TxtFirmaBul.Controls.Add(btn);
            btn.Dock = DockStyle.Left;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;

            base.OnLoad(e);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {

            int Id = f.FirmalarListesiAc(true);
            if (Id > 0)
            {
                Ac(Id);
            }
            AnaSayfa.Aktarma = -1;
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
            kayitBul = frmList.FirstOrDefault(x => x.Id == secimId);

            if (kayitBul != null)
            {
                TxtVergiNo.Text = kayitBul.VergiNo;
                TxtFTipi.Text = kayitBul.FirmaTip;
                TxtSehir.Text = kayitBul.Sehirler.name;
                TxtAdres.Text = kayitBul.Adres;
                TxtFadi.Text = kayitBul.Adi;
                TxtTelefon.Text = kayitBul.Tel;
                TxtVergiDairesi.Text = kayitBul.VergiDairesi;
                TxtEmail.Text = kayitBul.Email;
                TxtFirmaBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
            }




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
                    kayitBul.Adi = TxtFadi.Text;
                    kayitBul.Adres = TxtAdres.Text;
                    kayitBul.Email = TxtEmail.Text;
                    kayitBul.Tel = TxtTelefon.Text;
                    kayitBul.VergiDairesi = TxtVergiDairesi.Text;
                    kayitBul.SehirId = (int?)TxtSehir.SelectedValue;
                    kayitBul.FirmaTip = TxtFTipi.Text;
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
            DialogResult dr = MessageBox.Show("Bak kardeşim bu ciddi bir işlem! Sildikten sonra sistem adminine vay efendim ben kayıt sildim deme!!", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Sil()
        {
            if (secimId > 0)
            {
                _db.tblFirmalar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydınız Silinmiştir Geçmiş Olsun");
                Temizle();
                Listele();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnDetayGoster_Click(object sender, EventArgs e)
        {
            FirmaDetayGoster goster = new FirmaDetayGoster();
            goster.Fadi = TxtFadi.Text;
            goster.ShowDialog();
        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {
            Close();
            FirmaDetay frmDetay=new FirmaDetay();
            frmDetay.LblFirmaAdi.Text = kayitBul.Adi;
            frmDetay.LblFirmaId.Text = kayitBul.Id.ToString();
            frmDetay.Show();
            
        }
    }
}
