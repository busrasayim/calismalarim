using AcitanSozlukWeb.Models;
using AcitanSozlukWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcitanSozlukWeb.Controllers
{
    public class HomeController : Controller
    {
        AcitanSozlukDbContext db = new AcitanSozlukDbContext();

        public ActionResult AnaSayfa(int? top = 0)
        {
            if (top <= 0)
                top = 10;

            //List<Article> articles = new List<Article>();

            //for (int i = 0; i < top; i++)
            //{
            //    string[] hashtags = new string[FakeData.NumberData.GetNumber(1, 5)];
            //    for (int k = 0; k < hashtags.Length; k++)
            //    {
            //        hashtags[k] = "#" + FakeData.NameData.GetFirstName();
            //    }

            //    articles.Add(new Article()
            //    {
            //        Id = i,
            //        Title = FakeData.TextData.GetSentence(),
            //        Description = FakeData.TextData.GetSentences(4),
            //        Summary = FakeData.TextData.GetSentences(2),
            //        HashTags = string.Join(";", hashtags),
            //        LikedCount = FakeData.NumberData.GetNumber(250, 2000),
            //        DislikedCount = FakeData.NumberData.GetNumber(25, 100)
            //    });
            //}

            HomePageViewModel model = new HomePageViewModel();
            model.Articles = db.Articles.OrderByDescending(x => x.PublishedOn).Take(top.Value).ToList();
            // TODO : Kullanıcı login olmuş ise bu verileri doldur.Kullanıcının gelen yazılardaki like ettikleri ve dislike ettikleri gelmeli. 

            if(Session["user_session"] != null)
            {
                User user = Session["user_session"] as User;

                if(user != null)
                {
                    model.LikedArticleIds = 
                        db.UserArticles.Where(
                            x => x.User.Id == user.Id && x.IsLiked == true).Select(
                            x => x.Article.Id).ToList();

                    model.DislikedArticleIds =
                        db.UserArticles.Where(
                            x => x.User.Id == user.Id && x.IsLiked == false).Select(
                            x => x.Article.Id).ToList();
                }
            }

            return View(model);
        }

        public ActionResult AddArticle()
        {
            return View();
        }
    }
}