using IEA_ErpProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.Fonksiyonlar
{
    public class Numaralar
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private readonly ErpProContext _code = new ErpProContext();
        public string UidNo()
        {
            try
            {
                var numara=(from s in _db.tblUrunKayitUst
                           orderby s.Id descending select s).First().Uid;
                numara++;
                string num = numara.ToString().PadLeft(7,'0');
                return num;
            }
            catch (Exception e)
            {
                return "0000001";
                
            }
        }

        public string UGirisNo()
        {
            try
            {
                var numara = (from s in _db.tblUrunGirisUst orderby s.Id descending select s).First().GirisId;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception e)
            {
                return "0000001";
            }
        }

        public string KonsinyeGonderimNo()
        {
            try
            {
                var numara = (from s in _code.TblKonsinyeGonderimler orderby s.Id descending select s).First().GonderimId;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception e)
            {
                return "0000001";
            }

        }
    }
}
