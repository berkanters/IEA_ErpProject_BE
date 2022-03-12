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
using IEA_ErpProject.Entity;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.KonsinyeIslemleri.Gonderim
{
    public partial class KonsinyeGonderimListesi : Form
    {
        public bool Secim = false;
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public int secimId = -1;
        public int gonderimId = -1;
        private readonly ErpProContext _code=new ErpProContext();
        
        public KonsinyeGonderimListesi()
        {
            InitializeComponent();
        }

        private void KonsinyeGonderimListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i=0;
            //var srg = (from s in _code.TblKonsinyeGonderimler
            //    where s.isDeleted != true
            //    where s.CariAdi.Contains(TxtGonderimAra.Text)
            //    select s);

            var srg1 = (from s in _code.TblKonsinyeGonderimler
                    where s.isDeleted != true
                    where s.CariAdi.Contains(TxtGonderimAra.Text)
                    select s)
                .GroupBy(s => new { s.GonderimId })
                .Select(group => group.FirstOrDefault()).ToList();
            
                foreach (var s in srg1)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = s.Id;
                Liste.Rows[i].Cells[2].Value = s.CariTur;
                Liste.Rows[i].Cells[3].Value = s.CariAdi;
                Liste.Rows[i].Cells[4].Value = s.GonderimTarih;
                Liste.Rows[i].Cells[5].Value = s.Aciklama;
                Liste.Rows[i].Cells[6].Value = s.GonderimId;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly=true;

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && gonderimId > 0)
            {
                AnaSayfa.Aktarma = gonderimId;
                
            }
            else if (!Secim && gonderimId > 0)
            {
                KonsinyeGonderim kns = new KonsinyeGonderim();
                kns.MdiParent = Form.ActiveForm;
                kns.StartPosition = FormStartPosition.CenterScreen;
                kns.Show();
                kns.KonGonderimAc(gonderimId);

            }
            Close();
        }

        private void Sec()
        {
            if (Liste.CurrentRow != null) gonderimId = Convert.ToInt32(Liste.CurrentRow.Cells[6].Value);
        }

        private void BtnGonderimBul_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
