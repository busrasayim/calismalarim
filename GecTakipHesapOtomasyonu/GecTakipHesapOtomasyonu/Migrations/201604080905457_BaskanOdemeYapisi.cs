namespace GecTakipHesapOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaskanOdemeYapisi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaskanOdemeleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OdendiMi = c.Boolean(nullable: false),
                        Ogrenci_Id = c.Int(),
                        Baskan_Id = c.Int(),
                        Odeyen_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ogrenciler", t => t.Ogrenci_Id)
                .ForeignKey("dbo.Ogrenciler", t => t.Baskan_Id)
                .ForeignKey("dbo.Ogrenciler", t => t.Odeyen_Id)
                .Index(t => t.Ogrenci_Id)
                .Index(t => t.Baskan_Id)
                .Index(t => t.Odeyen_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BaskanOdemeleri", "Odeyen_Id", "dbo.Ogrenciler");
            DropForeignKey("dbo.BaskanOdemeleri", "Baskan_Id", "dbo.Ogrenciler");
            DropForeignKey("dbo.BaskanOdemeleri", "Ogrenci_Id", "dbo.Ogrenciler");
            DropIndex("dbo.BaskanOdemeleri", new[] { "Odeyen_Id" });
            DropIndex("dbo.BaskanOdemeleri", new[] { "Baskan_Id" });
            DropIndex("dbo.BaskanOdemeleri", new[] { "Ogrenci_Id" });
            DropTable("dbo.BaskanOdemeleri");
        }
    }
}
