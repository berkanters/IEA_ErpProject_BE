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

namespace IEA_ErpProject.BilgiGiris.Doktorlar
{

    public partial class DoktorGiris : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        Formlar f= new Formlar();
        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            TxtUnvan.DataSource = Enum.GetValues(typeof(Unvan));
            TxtUnvan.SelectedIndex = -1;
            
            var srg=_db.tblHastaneler;

            TxtHastane1.DataSource = srg.ToList();
            TxtHastane1.ValueMember = "Id";
            TxtHastane1.DisplayMember = "Adi";
            TxtHastane1.SelectedIndex = -1; 
            
            TxtHastane2.DataSource = srg.ToList();
            TxtHastane2.ValueMember = "Id";
            TxtHastane2.DisplayMember = "Adi";
            TxtHastane2.SelectedIndex = -1;
            
            TxtHastane3.DataSource = srg.ToList();
            TxtHastane3.ValueMember = "Id";
            TxtHastane3.DisplayMember = "Adi";
            TxtHastane3.SelectedIndex = -1;

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
            tblDoktorlar dkt = new tblDoktorlar
            {
                Adi = TxtDadi.Text,
                DTarihi = TxtTarih.Value,
                Email = TxtEmail.Text,
                Gsm = TxtGsm.Text,
                //Hastane1Id = Convert.ToInt32(TxtHastane1.SelectedValue),
                //Hastane2Id = Convert.ToInt32(TxtHastane2.SelectedValue),
                //Hastane3Id = Convert.ToInt32(TxtHastane3.SelectedValue),
                Muayenehane = TxtMuayen.Text,
                //SehirId = Convert.ToInt32(TxtSehir.SelectedValue),
                Tel1 = TxtTel1.Text,
                Tel2 = TxtTel2.Text,
                Unvan = TxtUnvan.Text,
                VergiDairesi = TxtVergiDairesi.Text,
                VergiNo=TxtVergiNo.Text,

            };
            if (TxtHastane1.SelectedValue != null) dkt.Hastane1Id = Convert.ToInt32(TxtHastane1.SelectedValue);
            if (TxtHastane2.SelectedValue != null) dkt.Hastane2Id = Convert.ToInt32(TxtHastane2.SelectedValue);
            if (TxtHastane3.SelectedValue != null) dkt.Hastane3Id = Convert.ToInt32(TxtHastane3.SelectedValue);
            if (TxtSehir.SelectedValue != null) dkt.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
            _db.tblDoktorlar.Add(dkt);
            _db.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Yapıldı");
            Temizle();
            Listele();
        }
        List<tblDoktorlar> dktList;
        private int secimId=-1;
        private tblDoktorlar kayitBul;

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            dktList = (from s in _db.tblDoktorlar select s).ToList();
            foreach (var item in dktList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = sira;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Tel1;
                Liste.Rows[i].Cells[4].Value = item.Tel2;
                Liste.Rows[i].Cells[5].Value = item.Gsm;
                Liste.Rows[i].Cells[6].Value = item.Email;
                if(item.Sehirler!=null)
                {
                    Liste.Rows[i].Cells[7].Value = item.Sehirler.name; 
                }
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
            foreach (Control k in ScDoktor.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }
            }
            TxtHastane1.SelectedIndex = -1;
            TxtHastane2.SelectedIndex = -1;
            TxtHastane3.SelectedIndex = -1;
            TxtSehir.SelectedIndex = -1;

        }


        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtDoktorBul.ClientSize.Height + 1);
            btn.Location = new Point(TxtDoktorBul.ClientSize.Width - btn.Width -1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TxtDoktorBul.Controls.Add(btn);
            btn.Dock = DockStyle.Left;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;

            base.OnLoad(e);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {

            int Id = f.DoktorlarListesiAc (true);
            if (Id > 0)
            {
                Ac(Id);
            }
            AnaSayfa.Aktarma = -1;
        }

        public void Ac(int id)
        {
            secimId = id;  
            if (secimId < 0)
            {
                MessageBox.Show("Kayır ID Bulunamamıştır.");
                return;

            }
            //tblHastaneler kayitBul = _db.tblHastaneler.Find(secimId);
            BtnDetayEkle.Visible = true;
            BtnDetayGoster.Visible = true;
            kayitBul = dktList.FirstOrDefault(x => x.Id == secimId);

            if (kayitBul != null)
            {
                TxtVergiNo.Text = kayitBul.VergiNo;
                TxtUnvan.Text = kayitBul.Unvan;
                if (kayitBul.Sehirler != null) TxtSehir.Text = kayitBul.Sehirler.name;
                TxtMuayen.Text = kayitBul.Muayenehane;
                TxtDadi.Text = kayitBul.Adi;
                TxtTel1.Text = kayitBul.Tel1;
                TxtTel2.Text = kayitBul.Tel2;
                TxtVergiDairesi.Text = kayitBul.VergiDairesi;
                TxtGsm.Text = kayitBul.Gsm;
                TxtDoktorBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
                if (kayitBul.tblHastaneler != null) TxtHastane1.Text = kayitBul.tblHastaneler.Adi;
                if (kayitBul.tblHastaneler1 != null) TxtHastane2.Text = kayitBul.tblHastaneler1.Adi;
                if (kayitBul.tblHastaneler2 != null) TxtHastane3.Text = kayitBul.tblHastaneler2.Adi;
                TxtTarih.Text = kayitBul.DTarihi.ToString();
                TxtEmail.Text = kayitBul.Email;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Temizle();
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }
            Ac(secimId);
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
                    kayitBul.Adi = TxtDadi.Text;
                    kayitBul.Muayenehane = TxtMuayen.Text;
                    kayitBul.Unvan = TxtUnvan.Text;
                    kayitBul.Tel1 = TxtTel1.Text;
                    kayitBul.VergiDairesi = TxtVergiDairesi.Text;
                    if (kayitBul.Sehirler != null) kayitBul.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                    kayitBul.Tel2 = TxtTel2.Text;
                    kayitBul.VergiNo = TxtVergiNo.Text;
                    kayitBul.Gsm = TxtGsm.Text;
                    if (kayitBul.tblHastaneler != null) kayitBul.Hastane1Id = Convert.ToInt32(TxtHastane1.SelectedValue);
                    if (kayitBul.tblHastaneler1 != null)kayitBul.Hastane2Id = Convert.ToInt32(TxtHastane2.SelectedValue);
                    if (kayitBul.tblHastaneler2 != null) kayitBul.Hastane3Id = Convert.ToInt32(TxtHastane3.SelectedValue);
                    kayitBul.DTarihi = TxtTarih.Value;
                    kayitBul.Email = TxtEmail.Text;


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
            Sil();
        }

        private void Sil()
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

      
    }
}
