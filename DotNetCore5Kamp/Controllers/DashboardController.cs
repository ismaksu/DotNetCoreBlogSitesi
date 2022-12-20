using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            Context c = new Context();

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userid = c.Users.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            ViewBag.value1 = c.Blogs.Count().ToString();
            ViewBag.value2 = c.Blogs.Where(x => x.AuthorID == userid).Count().ToString();
            ViewBag.value3 = c.Categories.Count().ToString();
            return View();
        }
    }
}
