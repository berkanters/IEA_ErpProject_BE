using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    [Table("tblKonsinyeGonderimler")]
    public class tblKonsinyeGonderim:BaseEntity
    {
        public int GonderimId { get; set; }
        [StringLength(15)]
        public string CariTur { get; set; }
        [StringLength(200)]
        public string CariAdi { get; set; }
        public string CariId { get; set; }
        public DateTime GonderimTarih { get; set; }
        [StringLength(250)]
        public string Aciklama { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        [ForeignKey("UrunId")]
        public tblStokDurum TblStokDurum { get; set; }
        
    }

    
}
