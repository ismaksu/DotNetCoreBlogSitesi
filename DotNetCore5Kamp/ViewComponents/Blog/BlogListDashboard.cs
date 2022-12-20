using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.ListBlogWithCategory().OrderByDescending(x => x.BlogCreationDate).Take(10).ToList();
            return View(values);
        }
    }
}
