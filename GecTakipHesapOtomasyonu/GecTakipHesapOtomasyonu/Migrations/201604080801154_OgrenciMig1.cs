namespace GecTakipHesapOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OgrenciMig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ogrenciler", "SonGecikmeTarihi", c => c.DateTime());
            AddColumn("dbo.Ogrenciler", "Notlar", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ogrenciler", "Notlar");
            DropColumn("dbo.Ogrenciler", "SonGecikmeTarihi");
        }
    }
}
