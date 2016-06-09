using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcitanSozlukWeb.ViewModels
{
    public class LoginPageViewModel
    {
        [DisplayName("Kullanıcı Adı"),
            Required(ErrorMessage = "Kullanıcı adı boş geçilemez."),
            StringLength(25, ErrorMessage = "Kullanıcı adı maks. 25 karakter olmalıdır.")]
        public string Nickname { get; set; }

        [DisplayName("Şifre"),
            Required(ErrorMessage = "Şifre boş geçilemez."),
            StringLength(15, ErrorMessage = "Şifre maks. 15 karakter olmalıdır.")]
        public string Password { get; set; }

        [DisplayName("Beni Hatırla!")]
        public bool RememberMe { get; set; }

        [DisplayName("E-Posta Adresi"),
            Required(ErrorMessage = "E-Posta adresi boş geçilemez."),
            EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adresi giriniz.")]
        public string EmailAddress { get; set; }

        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }

        public string SuccessMessage { get; set; }
    }
}