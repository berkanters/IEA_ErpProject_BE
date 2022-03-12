using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    [Table("tblUsers")]
    public class tblUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Ad"),StringLength(50, ErrorMessage = "{0} Alanı max {1} karakterdir")]
        [Required(ErrorMessage = "{0}  Alanı Girilmesi Zorunludur ")]
        public string Name { get; set; }

        [DisplayName("Sifre"), StringLength(maximumLength:10,MinimumLength = (5), ErrorMessage = "{0} Alanı max {1}  min{2} karakterdir ")]
        [Required(ErrorMessage = "{0}  Alanı Girilmesi Zorunludur ")]
        public string Password { get; set; }

        [DisplayName("Kullanici Adi"), StringLength(maximumLength: 10, MinimumLength = (5), ErrorMessage = "{0} Alanı max {1}  min{2} karakterdir ")]
        [Required(ErrorMessage = "{0}  Alanı Girilmesi Zorunludur ")]
        public string UserName { get; set; }

    }
}
