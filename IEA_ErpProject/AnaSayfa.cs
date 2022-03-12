using IEA_ErpProject.BilgiGiris.Doktorlar;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.BilgiGiris.Hastaneler;
using IEA_ErpProject.BilgiGiris.Personeller;
using IEA_ErpProject.BilgiGiris.Urunler;
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Stok;
using IEA_ErpProject.UrunGirisIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Giris;
using IEA_ErpProject.KonsinyeIslemleri.Gonderim;

namespace IEA_ErpProject
{
    public partial class AnaSayfa : Form
    {
        public static int Aktarma = -1;
        Formlar f = new Formlar();
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        

        private void MenuOlustur(string info)
        {
            if (info == "bilgi")
            {
                tvMenu.Nodes.Clear();
                tvMenu.Nodes.Add("Hastaneler");//Root Elemanı
                tvMenu.Nodes[0].Nodes.Add("Hastaneler Listesi");//Child
                tvMenu.Nodes[0].Nodes.Add("Hastane Bilgi Giriş");

                tvMenu.Nodes.Add("Doktorlar");
                tvMenu.Nodes[1].Nodes.Add("Doktorlar Listesi");
                tvMenu.Nodes[1].Nodes.Add("Doktor Bilgi Giriş");

                tvMenu.Nodes.Add("Firmalar");
                tvMenu.Nodes[2].Nodes.Add("Firmalar Listesi");
                tvMenu.Nodes[2].Nodes.Add("Firma Bilgi Giriş");

                tvMenu.Nodes.Add("Personeller");
                tvMenu.Nodes[3].Nodes.Add("Personeller Listesi");
                tvMenu.Nodes[3].Nodes.Add("Personel Bilgi Giriş");

                tvMenu.Nodes.Add("Ürünler");
                tvMenu.Nodes[4].Nodes.Add("Ürün Kayıt Listesi");
                tvMenu.Nodes[4].Nodes.Add("Ürün Kayıt");

            }
            else if (info == "urun")
            {
                tvMenu.Nodes.Clear();
                tvMenu.Nodes.Add("Ürünler Giriş");
                tvMenu.Nodes[0].Nodes.Add("Ürünler Giriş Listesi");
                tvMenu.Nodes[0].Nodes.Add("Ürün Bilgi Giriş");
            }
            else if (info == "stok")
            {
                tvMenu.Nodes.Clear();
                tvMenu.Nodes.Add("Stok");
                tvMenu.Nodes[0].Nodes.Add("Stok Durum");
                //tvMenu.Nodes[0].Nodes.Add("Ürün Bilgi Giriş");
            }
            else if (info == "Konsinye")
            {
                tvMenu.Nodes.Clear();
                tvMenu.Nodes.Add("Konsinye");
                tvMenu.Nodes[0].Nodes.Add("Gonderim");
                tvMenu.Nodes[0].Nodes[0].Nodes.Add("Konsinye Gonderim");
                tvMenu.Nodes[0].Nodes[0].Nodes.Add("Konsinye Gonderim Listesi");
                tvMenu.Nodes[0].Nodes.Add("Cikis");
                tvMenu.Nodes[0].Nodes[1].Nodes.Add("Konsinye Cikis");
                tvMenu.Nodes[0].Nodes[1].Nodes.Add("Konsinye Cikis Listesi");

            }
        }



        #region DoubleClickE
        private void tvMenu_DoubleClick(object sender, EventArgs e)
        {
            string isim = " ";
            if (tvMenu.SelectedNode != null)
            {
                isim = tvMenu.SelectedNode.Text;
            }
            if (isim == "Hastaneler Listesi" && Application.OpenForms["HastanelerListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa
                //frm.Show();
                f.HastanelerListesiAc();
            }
            else if (isim == "Hastane Bilgi Giriş" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["DoktorlarListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa
                //frm.Show();
                f.DoktorlarListesiAc();
            }
            else if (isim == "Doktor Bilgi Giriş" && Application.OpenForms["DoktorGiris"] == null)
            {
                DoktorGiris frm = new DoktorGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Firmalar Listesi" && Application.OpenForms["FirmalarListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa
                //frm.Show();
                f.FirmalarListesiAc();
            }
            else if (isim == "Firma Bilgi Giriş" && Application.OpenForms["FirmaGiris"] == null)
            {
                FirmaGiris frm = new FirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();

            }
            else if (isim == "Ürün Kayıt Listesi" && Application.OpenForms["UrunKayitListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa
                //frm.Show();
                f.UrunKayitListesiAc();
            }
            else if (isim == "Ürün Kayıt" && Application.OpenForms["UrunKayit"] == null)
            {
                UrunKayit frm = new UrunKayit();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
           
            else if (isim == "Personel Bilgi Giriş" && Application.OpenForms["PersonelGiris"] == null)
            {
                PersonelGiris frm = new PersonelGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Personeller Listesi" && Application.OpenForms["PersonellerListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa
                //frm.Show();
                f.PersonellerListesiAc();
            }
            else if (isim == "Ürünler Giriş Listesi" && Application.OpenForms["UrunGirisListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa
                //frm.Show();
                f.UrunlerGirisListesiAc();
            }
            else if (isim == "Ürün Bilgi Giriş" && Application.OpenForms["UrunGiris"] == null)
            {
                UrunGiris frm = new UrunGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();

            }
            else if (isim == "Stok Durum" && Application.OpenForms["StokDurum"] as StokDurum == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa
                //frm.Show();
                f.StokDurumAc();
            }
            else if (isim == "Konsinye Gonderim" && Application.OpenForms["KonsinyeGonderim"] as KonsinyeGonderim == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa
                //frm.Show();
                f.KonsinyeGonderimAc();
            }
           

            #endregion

        }
        #region ButonKotrol
        private void BtnStok_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnUrunGiris.Text;
            MenuOlustur("stok");
        }
        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnBilgiGiris.Text;
            MenuOlustur("bilgi");
        }
        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnUrunGiris.Text;
            MenuOlustur("urun");

        }
        #endregion

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Programdan Çıkış Yapmak İstiyor musunuz?",
            //    "Çıkış İşlemi",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dr == DialogResult.Yes)
            //{
            //    Application.ExitThread();
            //}
            //else
            //{
            //    e.Cancel= true;
            //    //GirisEkrani giris = new GirisEkrani();
            //    //giris.Visible = true;
            //}

            Cikis(e);
        }

        private void Cikis(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Programdan Çıkış Yapmak İstiyor musunuz?",
                "Çıkış İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
                //GirisEkrani giris = new GirisEkrani();
                //giris.Visible = true;
            }
        }

        private void btnSolUstCollapse_Click(object sender, EventArgs e)
        {
            //288; 692

            if (pnlSol.Size.Width>145)
            {
                pnlSol.Width = 145;
                btnBilgiGiris.Height = 40;
                btnUrunGiris.Height= 40;
                BtnKonsinye.Height=40;
                BtnStok.Height=40;

            }
            else
            {
                pnlSol.Width = 288;
                btnBilgiGiris.Height = 72;
                btnUrunGiris.Height = 72;
                BtnKonsinye.Height = 72;
                BtnStok.Height = 72;
            }
        }

        private void BtnKonsinye_Click(object sender, EventArgs e)
        {
            lblMenu.Text = BtnKonsinye.Text;
            MenuOlustur("Konsinye");
        }

        
    }
}
