using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EFAboutRepository());

        public IActionResult Index()
        {
            var values = abm.ListEntity();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
            
            return PartialView();
        }
    }
}
