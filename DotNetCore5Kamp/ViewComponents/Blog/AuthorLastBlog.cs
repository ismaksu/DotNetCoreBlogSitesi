using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.ViewComponents.Blog
{
    public class AuthorLastBlog:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.ListBlogByAuthor(1);
            return View(values);
        }
    }
}
