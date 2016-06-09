using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;

namespace AcitanSozlukWeb.Models
{
    public class AcitanSozlukDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<UserArticle> UserArticles { get; set; }

        public AcitanSozlukDbContext()
        {
            Database.SetInitializer(new MyDbInit());
        }
    }


    public class MyDbInit : CreateDatabaseIfNotExists<AcitanSozlukDbContext>
    {
        protected override void Seed(AcitanSozlukDbContext context)
        {
            // Insert Users..
            // 
            for (int i = 0; i < 5; i++)
            {
                context.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    EMail = FakeData.NetworkData.GetEmail(),
                    Biography = FakeData.TextData.GetSentences(3),
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Nickname = "user" + i.ToString(),
                    FacebookLink = FakeData.NetworkData.GetDomain(),
                    TwitterLink = FakeData.NetworkData.GetDomain(),
                    Password = "1234"
                });
            }

            context.SaveChanges();

            // Insert Articles..
            // 
            List<User> users = context.Users.ToList();

            for (int i = 0; i < 75; i++)
            {
                string[] hashtags = new string[FakeData.NumberData.GetNumber(1, 5)];
                for (int k = 0; k < hashtags.Length; k++)
                {
                    hashtags[k] = "#" + FakeData.NameData.GetFirstName();
                }

                string summary = FakeData.TextData.GetSentences(2);

                if (summary.Length > 140)
                {
                    summary = summary.Substring(0, 139);
                }

                context.Articles.Add(new Article()
                {
                    Title = FakeData.TextData.GetSentence(),
                    Description = FakeData.TextData.GetSentences(4),
                    Summary = summary,
                    HashTags = string.Join(";", hashtags),
                    CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddMonths(-2), DateTime.Now.AddDays(-14)),
                    PublishedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddDays(-13), DateTime.Now),
                    LikedCount = FakeData.NumberData.GetNumber(250, 2000),
                    DislikedCount = FakeData.NumberData.GetNumber(25, 100),
                    OwnUser = users[FakeData.NumberData.GetNumber(0, users.Count - 1)]
                });
            }

            context.SaveChanges();

            // Insert UserArticles..
            // 
            List<Article> articles = context.Articles.ToList();

            for (int i = 0; i < articles.Count * users.Count; i++)
            {
                context.UserArticles.Add(new UserArticle()
                {
                    User = users[FakeData.NumberData.GetNumber(0, users.Count - 1)],
                    Article = articles[FakeData.NumberData.GetNumber(0, articles.Count - 1)],
                    IsLiked = (i % 3 == 0) ? false : true
                });
            }

            context.SaveChanges();
        }
    }



    [Table("Users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez."),
            StringLength(20, ErrorMessage = "Maks. 20 karakter olsun istersen.."),
            DisplayName("Kullanıcı Adı")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "İsim boş geçilemez."),
            StringLength(20, ErrorMessage = "Maks. 20 karakter olsun istersen.."),
            DisplayName("Adınız")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad boş geçilemez."),
            StringLength(20, ErrorMessage = "Maks. 20 karakter olsun istersen.."),
            DisplayName("Soyadınız")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez."),
            StringLength(25, ErrorMessage = "Maks. 25 karakter olsun istersen.."),
            DisplayName("Şifreniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "E-Posta boş geçilemez."),
            StringLength(60, ErrorMessage = "Maks. 60 karakter olsun istersen.."),
            EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi dedik!"),
            DisplayName("E-Posta Adresiniz")]
        public string EMail { get; set; }

        [Column(TypeName = "image"),
            DisplayName("Profil Resmi")]
        public byte[] Avatar { get; set; }

        [StringLength(250, ErrorMessage = "Maks. 250 karakter olsun istersen.."),
            DisplayName("Biyografi")]
        public string Biography { get; set; }

        [StringLength(120, ErrorMessage = "Maks. 120 karakter olsun istersen.."),
            DisplayName("Facebook Url"),
            RegularExpression(@"(https\:\/\/www.facebook.com\/public\/.+)",ErrorMessage ="Lütfen bir facebook profil url si giriniz.")]
        public string FacebookLink { get; set; }

        [StringLength(120, ErrorMessage = "Maks. 120 karakter olsun istersen.."),
            DisplayName("Twitter Url"),
            RegularExpression(@"(https\:\/\/twitter.com\/.+)", ErrorMessage = "Lütfen bir twitter profil url si giriniz.")]
        public string TwitterLink { get; set; }

        public virtual List<Article> Articles { get; set; }
    }

    [Table("UserArticles")]
    public class UserArticle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsLiked { get; set; }

        public virtual Article Article { get; set; }
        public virtual User User { get; set; }
    }

    [Table("Articles")]
    public class Article
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Yazı başlığı boş geçilemez."),
            StringLength(80, ErrorMessage = "Maks. 80 karakter olsun istersen..")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Özet boş geçilemez."),
            StringLength(140, ErrorMessage = "Maks. 140 karakter olsun istersen..")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Yazı detayı boş geçilemez."),
            StringLength(300, ErrorMessage = "Maks. 300 karakter olsun istersen..")]
        public string Description { get; set; }

        [StringLength(150, ErrorMessage = "Maks. 150 karakter olsun istersen..")]
        public string HashTags { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? PublishedOn { get; set; }

        public int LikedCount { get; set; }
        public int DislikedCount { get; set; }

        public virtual User OwnUser { get; set; }
    }

}