using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GecTakipHesapOtomasyonu
{
    public class GecTakipHesapOtoDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Gecikme> Gecikmeler { get; set; }
        public DbSet<BaskanOdeme> BaskanOdemeler { get; set; }
    }

    [Table("Ogrenciler")]   // Tablo adı böyle olsun.
    public class Ogrenci
    {
        // Otomatik artan, primary key..
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(15)]
        public string Ad { get; set; }

        [Required, StringLength(15)]
        public string Soyad { get; set; }

        [StringLength(60)]
        public string EPosta { get; set; }

        public DateTime? SonGecikmeTarihi { get; set; }

        [StringLength(250)]
        public string Notlar { get; set; }

        // İlişkili property.. (Virtual olmasına dikkat !)
        public virtual List<Gecikme> Gecikmeleri { get; set; }
        public virtual List<BaskanOdeme> BaskanOdemeleri { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }

    [Table("Gecikmeler")]
    public class Gecikme
    {
        // Otomatik artan, primary key..
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        [Required]
        public DateTime Tarih { get; set; }

        public bool? OdendiMi { get; set; }

        [Required]
        public TimeSpan GirisSaati { get; set; }

        [Required]
        public TimeSpan GelisSaati { get; set; }

        public decimal Tutar { get; set; }

        // ilişkili nesne. (Virtual olmasına dikkat!)
        public virtual Ogrenci Ogrencisi { get; set; }
    }

    [Table("BaskanOdemeleri")]
    public class BaskanOdeme
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public decimal Tutar { get; set; }

        [Required]
        public bool OdendiMi { get; set; }

        public virtual Ogrenci Odeyen { get; set; }
        public virtual Ogrenci Baskan { get; set; }
    }
}
