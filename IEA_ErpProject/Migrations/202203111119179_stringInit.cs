namespace IEA_ErpProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringInit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblKonsinyeGonderimler", "CreatedUser", c => c.String());
            AlterColumn("dbo.tblKonsinyeGonderimler", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.tblKonsinyeGonderimler", "UpdateUser", c => c.String());
            AlterColumn("dbo.tblKonsinyeGonderimler", "UpdateDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblKonsinyeGonderimler", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tblKonsinyeGonderimler", "UpdateUser", c => c.Int(nullable: false));
            AlterColumn("dbo.tblKonsinyeGonderimler", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tblKonsinyeGonderimler", "CreatedUser", c => c.Int(nullable: false));
        }
    }
}
