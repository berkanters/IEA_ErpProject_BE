using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.Giris
{
    public partial class GirisEkrani : Form
    {
        private readonly ErpProContext code = new ErpProContext();
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TxtKullanici.Text!="" && TxtPassword.Text!="")
            {
                var srg = code.TblUsers.FirstOrDefault
                (
                    s => s.UserName == TxtKullanici.Text && s.Password == TxtPassword.Text
                );
                //var srg1 = (from s in code.TblUsers
                //   where (s.UserName == TxtKullanici.Text && s.Password == TxtPassword.Text)
                //    select s.Id).FirstOrDefault();

                if (srg!=null) //üsttekini kullanım srg!=null da yapabilirdik
                {
                    AnaSayfa ana = new AnaSayfa();
                    ana.Show();
                    ana.LblUserName.Text = srg.Name;
                    ana.LblUserNick.Text = srg.UserName;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı yada Şifre Hatalı lütfen kontrol ediniz");
                }
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
