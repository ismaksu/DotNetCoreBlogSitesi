using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adını Boş Bırakamazsınız.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre Kısmını Boş Bırakamazsınız.")]
        public string Password { get; set; }
    }
}
