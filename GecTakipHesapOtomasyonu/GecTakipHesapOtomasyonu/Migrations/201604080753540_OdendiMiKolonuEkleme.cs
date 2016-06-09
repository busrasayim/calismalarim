namespace GecTakipHesapOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OdendiMiKolonuEkleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gecikmeler", "OdendiMi", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gecikmeler", "OdendiMi");
        }
    }
}
