using DotNetCore5Kamp.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Oyun",
                CategoryCount = 14
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Film/Dizi",
                CategoryCount = 10
            });
            return Json(new { jsonList = list });
        }
    }
}
