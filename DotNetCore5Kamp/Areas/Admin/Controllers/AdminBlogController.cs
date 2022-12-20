using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Concrete;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace DotNetCore5Kamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.ListBlogWithCategory();
            return View(values);
        }
    }
}
