using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    public class MyInitializer:CreateDatabaseIfNotExists<ErpProContext>
    {
        protected override void Seed(ErpProContext context)
        {
            //Adding admin user 
            tblUser admin = new tblUser();
            admin.Name = "Berkant";
            admin.Password = "12345";
            admin.UserName = "BerkantE";
            
            context.TblUsers.Add(admin);
            context.SaveChanges();
            
            
            //base.Seed(context);
        }
    }
}
