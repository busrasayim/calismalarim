using AcitanSozlukWeb.Models;
using AcitanSozlukWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcitanSozlukWeb.Controllers
{
    public class LoginController : Controller
    {
        AcitanSozlukDbContext db = new AcitanSozlukDbContext();

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user, HttpPostedFileBase Avatar_file)
        {
            user.Id = Guid.NewGuid();

            if (Avatar_file != null && Avatar_file.ContentLength > 0)
            {
                byte[] avatar_bytes = new byte[Avatar_file.ContentLength];
                Avatar_file.InputStream.Read(avatar_bytes, 0, Avatar_file.ContentLength - 1);

                user.Avatar = avatar_bytes;
                //user.Avatar = new byte?[avatar_bytes.Length];

                //for (int i = 0; i < avatar_bytes.Length; i++)
                //    user.Avatar[i] = avatar_bytes[i];
            }

            db.Users.Add(user);
            db.SaveChanges();

            return RedirectToAction("Login");
        }


        public JsonResult CheckNickname(string nickname)
        {
            nickname = nickname.Trim();

            User user = db.Users.Where(x => x.Nickname.ToLower() == nickname.ToLower()).SingleOrDefault();

            MyJsonResult<bool,bool> result = new MyJsonResult<bool,bool>();

            if (user != null)
            {
                result.Value1 = true;
            }
            else
            {
                result.Value1 = false;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Login()
        {
            LoginPageViewModel model = new LoginPageViewModel();

            if (Request.Cookies.Count > 0)
            {
                if (Request.Cookies["nickname"] != null)
                {
                    model.Nickname = Request.Cookies["nickname"].Value;
                }

                //if(Request.Cookies["password"] != null)
                //{
                //    model.Password = Request.Cookies["password"].Value;
                //}
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginPageViewModel model)
        {
            User loginUser = db.Users.Where(x => x.Nickname == model.Nickname && x.Password == model.Password).SingleOrDefault();

            if (loginUser != null)
            {
                loginUser.Password = string.Empty;
                Session["user_session"] = loginUser;

                if (model.RememberMe)
                {
                    HttpCookie cookie_nickname = new HttpCookie("nickname", model.Nickname);
                    //HttpCookie cookie_password = new HttpCookie("password", model.Password);

                    cookie_nickname.Expires = DateTime.Now.AddMinutes(2);
                    //cookie_password.Expires = DateTime.Now.AddMinutes(2);

                    Response.Cookies.Add(cookie_nickname);
                    //Response.Cookies.Add(cookie_password);
                }
                else
                {
                    HttpCookie cookie_nickname = new HttpCookie("nickname", "");
                    cookie_nickname.Expires = DateTime.Now.AddSeconds(5);
                    Response.Cookies.Set(cookie_nickname);
                }

                return RedirectToAction("AnaSayfa", "Home");
            }

            // 1. yöntem
            //ViewBag.Hata = "Kullanıcı adı ya da şifre hatalıdır.";

            // 2. yöntem
            //ModelState.AddModelError("hata", "Kullanıcı adı ya da şifre hatalıdır.");

            // 3. yöntem
            model.HasError = true;
            model.ErrorMessage = "Kullanıcı adı ya da şifre hatalıdır.";

            return View(model);
        }

        [HttpPost]
        public ActionResult RememberPassword(LoginPageViewModel model)
        {
            User user = db.Users.Where(x => x.EMail == model.EmailAddress).FirstOrDefault();

            if (user != null)
            {
                // E-posta gönder adamın password'ünü..
                // user.EMail    
                // user.Password

                model.HasError = false;
                model.SuccessMessage = "Şifreniz e-posta adresinize gönderilmiştir.";
            }
            else
            {
                model.SuccessMessage = string.Empty;

                model.HasError = true;
                model.ErrorMessage = "Böyle bir e-posta yok hacı..";
            }

            return View("Login", model);
        }
    }
}