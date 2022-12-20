using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Adınız ve soyadınız kısmını boş geçemezsiniz.");
            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Mail adresiniz boş olamaz.");
            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Şifreniz boş olamaz.");

            RuleFor(x => x.AuthorName).MinimumLength(2).WithMessage("2 karakterden az bir isim girişi yapamazsınız.");
            RuleFor(x => x.AuthorPassword).MinimumLength(6).WithMessage("Şifreniz 6 karakterden az olamaz.");

            RuleFor(x => x.AuthorName).MaximumLength(60).WithMessage("60 karakterden fazla bir isim koyamazsınız.");
            RuleFor(x => x.AuthorMail).MaximumLength(55).WithMessage("Mail adresiniz çok uzun.");
            RuleFor(x => x.AuthorPassword).MaximumLength(70).WithMessage("Kullanıcı şifreniz 70 karakterden fazla olamaz.");

            RuleFor(x => x.AuthorPassword).Matches(@"[A-Z]+").WithMessage("Şifreniz en az bir büyük harfli karakter içermelidir.")
                    .Matches(@"[a-z]+").WithMessage("Şifreniz en az bir küçük harfli karakter içermelidir.")
                    .Matches(@"[0-9]+").WithMessage("Şifreniz en az bir sayı içermelidir.")
                    .Matches(@"[!,?,*,.,_]+").WithMessage("Şifreniz en az bir özel karakter içermelidir. ( ! ? * . _ )");
        }
    }
}
