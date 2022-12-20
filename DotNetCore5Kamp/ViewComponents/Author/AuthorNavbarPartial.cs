using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotNetCore5Kamp.ViewComponents.Author
{
    public class AuthorNavbarPartial : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var mail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var name = c.Users.Where(x => x.UserName == username).Select(y => y.Name).FirstOrDefault();
            var image = c.Authors.Where(x => x.AuthorMail == mail).Select(y => y.AuthorImage).FirstOrDefault();

            ViewBag.userName = username;
            ViewBag.name = name;
            ViewBag.image = image;

            return View();
        }
    }
}
