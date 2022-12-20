using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Models
{
    public class UserRegisterViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Lütfen ad soyad giriniz.")]
        public string Name { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen bir şifre giriniz.")]
        public string Password { get; set; }

        [Display(Name = "Şifre Onaylama")]
        [Required(ErrorMessage = "Şifreler uyuşmuyor.")]
        public string PasswordControl { get; set; }

        [Display(Name = "E-Posta Adresi")]
        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz.")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
        public string Username { get; set; }
    }
}
