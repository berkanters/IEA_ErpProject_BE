﻿using IEA_ErpProject.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastaneDetay : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public HastaneDetay()
        {
            InitializeComponent();
        }

        private void HastaneDetay_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            TxtYetkili.Focus();
        }

        private void ComboDoldur()
        {
            TxtDepartman.DataSource=_db.tblDepartmanlar.Where(x=>x.DepartmanKodu=="H").ToList();
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";
            TxtDepartman.SelectedIndex = -1;
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtYetkili.Text!=""&&TxtDepartman.SelectedIndex!= -1)
            {
                Liste.AllowUserToAddRows = false;
                int i = -1;
                if (Liste.Rows.Count >= 0)
                {
                    i = Liste.Rows.Count;
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = i + 1;
                    Liste.Rows[i].Cells[1].Value = LblHastaneId.Text;
                    Liste.Rows[i].Cells[2].Value = TxtYetkili.Text;
                    Liste.Rows[i].Cells[3].Value = TxtDepartman.SelectedValue;
                    Liste.Rows[i].Cells[4].Value = TxtTel.Text;
                    Liste.Rows[i].Cells[5].Value = TxtGsm.Text;
                    Liste.Rows[i].Cells[6].Value = TxtEmail.Text;
                }
               


                //foreach (var item in dtyList)
                //{
                //    Liste.Rows.Add();
                //    Liste.Rows[i].Cells[0].Value = sira;
                //    Liste.Rows[i].Cells[1].Value = item.Id;
                //    Liste.Rows[i].Cells[2].Value = item.GirisAdi;
                //    Liste.Rows[i].Cells[3].Value = item.YetkiliAdi;
                //    Liste.Rows[i].Cells[4].Value = item.DepartmanId;
                //    Liste.Rows[i].Cells[5].Value = item.Tel;
                //    Liste.Rows[i].Cells[6].Value = item.Gsm;
                //    Liste.Rows[i].Cells[7].Value = item.Email;
                //    i++;
                //    sira++;

                Temizle();

            }
            else
            {
                MessageBox.Show("İlgili Alanları Doldurun");
                ActiveControl = TxtYetkili;
            }


        }

        private void Temizle()
        {
            TxtYetkili.Clear();
            TxtDepartman.Text = "";
            TxtTel.Clear();
            TxtGsm.Clear();
            TxtEmail.Clear();

            ActiveControl = TxtYetkili;

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
        
        List<tblHastaneDetaylar> lst = new List<tblHastaneDetaylar>();
        private void YeniKayit()
        {
            if (Liste.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Önce Ekle butunu ile kayıt ekler misin güzel kardeşim.");
                return;
            }
            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                tblHastaneDetaylar dty = new tblHastaneDetaylar();

                dty.GirisId = Convert.ToInt32(Liste.Rows[i].Cells[1].Value);
                dty.YetkiliAdi = Liste.Rows[i].Cells[2].Value.ToString();
                dty.DepartmanId = Convert.ToInt32(Liste.Rows[i].Cells[3].Value);
                dty.Tel = Liste.Rows[i].Cells[4].Value.ToString();
                dty.Gsm = Liste.Rows[i].Cells[5].Value.ToString();
                dty.Email = Liste.Rows[i].Cells[6].Value.ToString();
                lst.Add(dty);
            }
            _db.tblHastaneDetaylar.AddRange(lst);
            _db.SaveChanges();
            MessageBox.Show("Kayıt Gerçekleşti.");
        }
    }
}
