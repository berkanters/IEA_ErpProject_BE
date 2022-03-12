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

namespace IEA_ErpProject.BilgiGiris.Personeller
{
    public partial class PersonelGiris : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public int secimId = -1;
        private tblPersoneller kayitBul;
        Formlar f = new Formlar();
        List<tblPersoneller> prsList;
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
           
            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;

            TxtDepartman.DataSource = _db.tblDepartmanlar.Where(x => x.DepartmanKodu == "F").ToList();
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";
            TxtDepartman.SelectedIndex = -1;
        }

        

        private void YeniKayıt()
        {
            if (TxtPadi.Text == "")
            {
                return;
            }
            try
            {
                tblPersoneller prs = new tblPersoneller();
                prs.Adi = TxtPadi.Text;
                prs.Adres = TxtAdres.Text;
                prs.Email = TxtEmail.Text;
                if (TxtSehir.SelectedValue != null)
                {
                    prs.SehirId = (int)TxtSehir.SelectedValue;
                }
                //if (TxtFTipi.SelectedValue != null)
                //{
                //    frm.TipId = (int)TxtFTipi.SelectedValue;
                //}
                prs.Gsm = TxtGsm.Text;
                prs.DepartmanId = (int)TxtDepartman.SelectedValue;
                prs.Tel = TxtTelefon.Text;
                prs.Unvan = TxtUnvan.Text;
                prs.IsBaslangic = TxtIsBaslangic.Value;
                prs.IsBitis = TxtIsBitis.Value;
                

                _db.tblPersoneller.Add(prs);
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

       

        
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            prsList = (from s in _db.tblPersoneller select s).ToList();
            foreach (var item in prsList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = sira;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Unvan;
                Liste.Rows[i].Cells[4].Value = item.IsBaslangic;
                Liste.Rows[i].Cells[5].Value = item.IsBitis;
                Liste.Rows[i].Cells[6].Value = item.DepartmanId;
                Liste.Rows[i].Cells[7].Value = item.Tel;
                Liste.Rows[i].Cells[8].Value = item.Gsm;
                Liste.Rows[i].Cells[9].Value = item.Sehirler.name;
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
            
            TxtSehir.SelectedIndex = -1;
            secimId = -1;
            kayitBul = null;           
            BtnKaydet.Enabled = true;

            TxtUnvan.SelectedIndex = -1;
            TxtDepartman.SelectedIndex = -1;
            TxtIsBaslangic.Value = DateTime.Now;
            TxtIsBitis.Value = DateTime.Now;
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtPersonelBul.ClientSize.Height + 1);
            btn.Location = new Point(TxtPersonelBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TxtPersonelBul.Controls.Add(btn);
            btn.Dock = DockStyle.Left;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;

            base.OnLoad(e);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {

            int Id = f.PersonellerListesiAc(true);
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
            kayitBul = prsList.FirstOrDefault(x => x.Id == secimId);

            if (kayitBul != null)
            {
                TxtDepartman.Text = kayitBul.tblDepartmanlar.Adi;
                TxtUnvan.Text = kayitBul.Unvan;
                TxtSehir.Text = kayitBul.Sehirler.name;
                TxtAdres.Text = kayitBul.Adres;
                TxtGsm.Text = kayitBul.Gsm;
                TxtPadi.Text = kayitBul.Adi;
                TxtTelefon.Text = kayitBul.Tel;
                TxtIsBaslangic.Value = kayitBul.IsBaslangic.Value;
                TxtIsBitis.Value = kayitBul.IsBitis.Value;
                TxtEmail.Text = kayitBul.Email;
                TxtPersonelBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
            }
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
                    kayitBul.Adi = TxtPadi.Text;
                    kayitBul.Adres = TxtAdres.Text;
                    kayitBul.Email = TxtEmail.Text;
                    kayitBul.Tel = TxtTelefon.Text;
                    kayitBul.Gsm = TxtGsm.Text;
                    kayitBul.SehirId = (int?)TxtSehir.SelectedValue;
                    kayitBul.IsBaslangic = TxtIsBaslangic.Value;
                    kayitBul.IsBitis = TxtIsBitis.Value;
                    kayitBul.DepartmanId = (int?)TxtDepartman.SelectedValue;
                    kayitBul.Unvan = TxtUnvan.Text;

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
        private void Sil()
        {
            if (secimId > 0)
            {
                _db.tblPersoneller.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydınız Silinmiştir Geçmiş Olsun");
                Temizle();
                Listele();
            }
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

        #region Ust Button
        private void BtnKaydet1_Click(object sender, EventArgs e)
        {
            YeniKayıt();

        }

        private void BtnSil1_Click(object sender, EventArgs e)
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

        private void BtnGuncelle1_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnTemizle1_Click(object sender, EventArgs e)
        {
            Temizle();
        } 
        #endregion
    }
}
