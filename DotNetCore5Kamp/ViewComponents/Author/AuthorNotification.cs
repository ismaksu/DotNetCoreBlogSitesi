using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.ViewComponents.Author
{
    public class AuthorNotification : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        NotificationManager nm = new NotificationManager(new EFNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = nm.ListEnabled();
            return View(values);
        }
    }
}
