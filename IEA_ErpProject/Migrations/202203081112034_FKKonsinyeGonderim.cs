namespace IEA_ErpProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKKonsinyeGonderim : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.tblStokDurums",
            //    c => new
                    //{
                    //    Id = c.Int(nullable: false, identity: true),
                    //    Barkod = c.String(),
                    //    UrunKodu = c.String(),
                    //    LotSeriNo = c.String(),
                    //    StokAdet = c.Int(),
                    //    RafAdet = c.Int(),
                    //    KonsinyeAdet = c.Int(),
                    //    SubeAdet = c.Int(),
                    //    UrunHareketAdet = c.Int(),
                    //    SutKodu = c.String(),
                    //    BransNo = c.String(),
                    //    Uts = c.Boolean(),
                    //    UTarih = c.DateTime(),
                    //    SKTarih = c.DateTime(),
                    //})
                //.PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.tblKonsinyeGonderimler", "UrunId");
            AddForeignKey("dbo.tblKonsinyeGonderimler", "UrunId", "dbo.tblStokDurum", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblKonsinyeGonderimler", "UrunId", "dbo.tblStokDurum");
            DropIndex("dbo.tblKonsinyeGonderimler", new[] { "UrunId" });
            
        }
    }
}
