using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic4:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var admin = c.Admins.FirstOrDefault();
            ViewBag.adminName = admin.AdminUsername;
            ViewBag.adminDesc = admin.AdminDescription;
            ViewBag.adminImg = admin.AdminImage;
            return View();
        }
    }
}
