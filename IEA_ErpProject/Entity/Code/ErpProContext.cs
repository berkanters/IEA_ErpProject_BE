using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.Entity.Code
{
    public class ErpProContext:DbContext //DbContext ErpProContext Sınıfının base'i dir
    {
        public ErpProContext() : base("name=ErpProCode")
        {
            Database.SetInitializer(new MyInitializer());
        }
        public DbSet<tblUser> TblUsers { get; set; }
        public DbSet<tblKonsinyeGonderim> TblKonsinyeGonderimler { get; set; }
        AnaSayfa ana = Application.OpenForms["AnaSayfa"] as AnaSayfa;
        public override int SaveChanges()
        {
            var datas =ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                if (data.State==EntityState.Added)
                {
                    data.Entity.CreatedDate=DateTime.Now;
                    
                    data.Entity.CreatedUser = ana.LblUserNick.Text;
                    data.Entity.isDeleted=false;
                }
                else if (data.State==EntityState.Modified)
                {
                    data.Entity.UpdateDate=DateTime.Now;
                    data.Entity.UpdateUser=ana.LblUserNick.Text;
                    
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        //    modelBuilder.Entity<tblKonsinyeGonderim>()
        //        .HasKey(n=>n.TblStokDurum)
        //        .WithRequired()
        }
    }
}
