using AcitanSozlukWeb.Models;
using AcitanSozlukWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcitanSozlukWeb.Controllers
{
    public class ArticleController : Controller
    {
        AcitanSozlukDbContext db = new AcitanSozlukDbContext();

        // /Article/Like/5?current=false
        // /Article/Like?nid=5&current=false
        public JsonResult Like(int id, bool current)
        {
            MyJsonResult<int,int> result = new MyJsonResult<int, int>();

            if (Session["user_session"] != null)
            {
                User user = Session["user_session"] as User;

                // Kullanıcı giriş yapmış demektir..
                UserArticle user_article = db.UserArticles.Where(x => x.Article.Id == id && x.User.Id == user.Id).FirstOrDefault();

                if (user_article != null)
                {
                    // adam bu makaleye dokunmuş..
                    if (current == true)
                    {
                        // Like edilmiş bir article 'ı like ederek nötr olmak istiyor demektir.
                        // UserArticle verisi silinir ve like count azaltılır.
                        db.UserArticles.Remove(user_article);

                        if (db.SaveChanges() > 0)
                        {
                            Article article = db.Articles.Where(x => x.Id == id).FirstOrDefault();
                            article.LikedCount -= 1;

                            db.SaveChanges();

                            result.Value1 = article.LikedCount;
                            result.Value2 = article.DislikedCount;
                            return Json(result, JsonRequestBehavior.AllowGet);
                        }
                    }
                    else
                    {
                        // Article disliked'dır. Article like'lanır.
                        // Article like ve dlike count'lar ayarlanır. 
                        user_article.IsLiked = true;

                        if(db.SaveChanges() > 0)
                        {
                            Article article = db.Articles.Where(x => x.Id == id).FirstOrDefault();
                            article.LikedCount += 1;
                            article.DislikedCount -= 1;

                            result.Value1 = article.LikedCount;
                            result.Value2 = article.DislikedCount;
                            return Json(result, JsonRequestBehavior.AllowGet);
                        }
                    }
                }
                else
                {
                    // Makaleye bu adam ilk defa dokunuyor.
                    user_article = new UserArticle();
                    user_article.Article = db.Articles.Where(x => x.Id == id).FirstOrDefault();

                    if (user_article.Article == null)
                    {
                        result.HasError = true;
                        result.Error = "Makale bulunamadı ya da silinmiş.";

                        return Json(result, JsonRequestBehavior.AllowGet);
                    }

                    user_article.User = db.Users.Where(x => x.Id == user.Id).SingleOrDefault();
                    user_article.IsLiked = true;

                    db.UserArticles.Add(user_article); // insert ettik. İlk defa like'ladı.

                    if (db.SaveChanges() > 0)
                    {
                        user_article.Article.LikedCount += 1;
                        db.SaveChanges();

                        result.Value1 = user_article.Article.LikedCount;
                        result.Value2 = user_article.Article.DislikedCount;
                        return Json(result, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            else
            {
                // Giriş yapmadan like olmaz...
                result.HasError = true;
                result.Error = "Like için giriş yapmalısınız.";
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Dislike(int id,bool current)
        {
            MyJsonResult<int, int> result = new MyJsonResult<int, int>();

            if (Session["user_session"] != null)
            {
                User user = Session["user_session"] as User;

                // Kullanıcı giriş yapmış demektir..
                UserArticle user_article = db.UserArticles.Where(x => x.Article.Id == id && x.User.Id == user.Id).FirstOrDefault();

                if (user_article != null)
                {
                    // adam bu makaleye dokunmuş..
                    if (current == true)
                    {
                        // Like edilmiş bir article 'ı like ederek nötr olmak istiyor demektir.
                        // UserArticle verisi silinir ve like count azaltılır.
                        db.UserArticles.Remove(user_article);

                        if (db.SaveChanges() > 0)
                        {
                            Article article = db.Articles.Where(x => x.Id == id).FirstOrDefault();
                            article.DislikedCount -= 1;

                            db.SaveChanges();

                            result.Value1 = article.LikedCount;
                            result.Value2 = article.DislikedCount;
                            return Json(result, JsonRequestBehavior.AllowGet);
                        }
                    }
                    else
                    {
                        // Article disliked'dır. Article like'lanır.
                        // Article like ve dlike count'lar ayarlanır. 
                        user_article.IsLiked = false;

                        if (db.SaveChanges() > 0)
                        {
                            Article article = db.Articles.Where(x => x.Id == id).FirstOrDefault();
                            article.LikedCount -= 1;
                            article.DislikedCount += 1;

                            result.Value1 = article.LikedCount;
                            result.Value2 = article.DislikedCount;
                            return Json(result, JsonRequestBehavior.AllowGet);
                        }
                    }
                }
                else
                {
                    // Makaleye bu adam ilk defa dokunuyor.
                    user_article = new UserArticle();
                    user_article.Article = db.Articles.Where(x => x.Id == id).FirstOrDefault();

                    if (user_article.Article == null)
                    {
                        result.HasError = true;
                        result.Error = "Makale bulunamadı ya da silinmiş.";

                        return Json(result, JsonRequestBehavior.AllowGet);
                    }

                    user_article.User = db.Users.Where(x => x.Id == user.Id).SingleOrDefault();
                    user_article.IsLiked = false;

                    db.UserArticles.Add(user_article); // insert ettik. İlk defa like'ladı.

                    if (db.SaveChanges() > 0)
                    {
                        user_article.Article.DislikedCount += 1;
                        db.SaveChanges();

                        result.Value1 = user_article.Article.LikedCount;
                        result.Value2 = user_article.Article.DislikedCount;
                        return Json(result, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            else
            {
                // Giriş yapmadan like olmaz...
                result.HasError = true;
                result.Error = "Like için giriş yapmalısınız.";
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShowDetail(int id)
        {
            Article article = db.Articles.Where(x => x.Id == id).SingleOrDefault();

            ShowDetailViewModel model = new ShowDetailViewModel();
            model.Id = article.Id;
            model.CreatedOn = article.CreatedOn;
            model.Description = article.Description;
            model.DislikedCount = article.DislikedCount;
            model.HashTags = article.HashTags;
            model.LikedCount = article.LikedCount;
            model.OwnUser = article.OwnUser;
            model.PublishedOn = article.PublishedOn;
            model.Summary = article.Summary;
            model.Title = article.Title;

            if (Session["user_session"] != null)
            {
                User user = Session["user_session"] as User;

                if (user != null)
                {
                    UserArticle userArticle = db.UserArticles.Where(x => x.Article.Id == article.Id && x.User.Id == user.Id).SingleOrDefault();

                    if (userArticle == null)
                    {
                        // Kullanıcı bu yazı ile ilgili bir işlem yapmamıştır.
                        model.IsLiked = null;
                    }
                    else
                    {
                        // Eğer kullanıcı bu yazı ile ilgili bir işlem yapmış ise(like or dislike)
                        model.IsLiked = userArticle.IsLiked;
                    }
                }
            }


            return View(model);
        }
    }
}