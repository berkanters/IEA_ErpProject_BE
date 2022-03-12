using IEA_ErpProject.Entity;
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
    public partial class FirmaDetayGoster : Form
    {
        public readonly ErpPro102SEntities _db = new ErpPro102SEntities();

        public string Fadi = "";
        public FirmaDetayGoster()
        {
            InitializeComponent();
        }

        private void FirmaDetayGoster_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var frmDetayList = (from s in _db.tblFirmaDetaylar where s.tblFirmalar.Adi == Fadi select s).ToList();
            foreach (var item in frmDetayList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = sira;
                Liste.Rows[i].Cells[3].Value = item.YetkiliAdi;
                Liste.Rows[i].Cells[4].Value = item.tblDepartmanlar.Adi;
                Liste.Rows[i].Cells[5].Value = item.Tel;
                Liste.Rows[i].Cells[6].Value = item.Gsm;
                Liste.Rows[i].Cells[7].Value = item.Email;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }
    }
}
