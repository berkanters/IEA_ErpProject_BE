using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
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
    public partial class FirmalarListesi : Form
    {
         private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public bool Secim = false;
   
        private int secimId = -1;
        private tblFirmalar kayitBul;
        Formlar f = new Formlar();
        public FirmalarListesi()
        {
            InitializeComponent();
        }

        private void FirmalarListesi_Load(object sender, EventArgs e)
        {
            Listele();
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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 && Secim && Application.OpenForms["FirmaGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();
                
            }
            else if (Secim && Application.OpenForms["FirmaGiris"] != null)
            {
                FirmaGiris frm = Application.OpenForms["FirmaGiris"] as FirmaGiris;
                frm.Ac(secimId);
                Close();
            }
            else if (!Secim)
            {
                f.FirmaGirisAc(secimId);
                Close();
            }
        }

        private void BtnFirmaAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
