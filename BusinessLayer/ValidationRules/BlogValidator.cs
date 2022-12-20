using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş olamaz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş olamaz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Bir blog resmi eklemek zorundasınız.");

            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog başlığı 5 karakterden küçük olamaz.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog başlığı 150 karakterden fazla olamaz.");
            RuleFor(x => x.BlogContent).MinimumLength(50).WithMessage("Blog yazınız 50 karakterden az olamaz.");
        }
    }
}
