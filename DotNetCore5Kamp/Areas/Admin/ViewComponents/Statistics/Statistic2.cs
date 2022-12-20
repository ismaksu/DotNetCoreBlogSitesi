using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.sonEklenen = c.Blogs.OrderByDescending(x => x.BlogCreationDate).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
