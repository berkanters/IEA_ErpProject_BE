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

namespace IEA_ErpProject.BilgiGiris.Personeller
{
    public partial class PersonellerListesi : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public bool Secim = false;
        List<tblPersoneller> prsList;
        private int secimId = -1;
        private tblDoktorlar kayitBul;
        Formlar f = new Formlar();
        public PersonellerListesi()
        {
            InitializeComponent();
        }

        private void PersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 && Secim && Application.OpenForms["PersonelGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();

            }
            else if (Secim && Application.OpenForms["PersonelGiris"] != null)
            {
                PersonelGiris prs = Application.OpenForms["PersonelGiris"] as PersonelGiris;
                prs.Ac(secimId);
                Close();
            }
            else if (!Secim)
            {
                f.PersonelGirisAc(secimId);
                Close();
            }
        }

        private void BtnPersonelAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
