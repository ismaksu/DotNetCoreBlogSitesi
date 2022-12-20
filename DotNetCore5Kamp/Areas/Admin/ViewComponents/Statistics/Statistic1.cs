using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetCore5Kamp.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.blogSayi = bm.ListEntity().Count();
            ViewBag.mesajSayi = c.Contacts.Count();
            ViewBag.yorumSayi = c.Comments.Count();

            string apiKey = "27326dde9535cd51c49957c6a1c179c7";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + apiKey;

            XDocument document = XDocument.Load(connection);

            ViewBag.sicaklik = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
