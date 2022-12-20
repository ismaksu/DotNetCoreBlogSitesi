using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.ViewComponents.Author
{
    public class AuthorAboutDashboard:ViewComponent
    {
        AuthorManager aum = new AuthorManager(new EFAuthorRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userID = c.Users.Where(x => x.Email == userMail).Select(y => y.Id).FirstOrDefault();

            var authorValues = aum.ListWriterByID(userID);
            return View(authorValues);
        }
    }
}
