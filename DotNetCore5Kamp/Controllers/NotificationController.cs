using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager nm = new NotificationManager(new EFNotificationRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NotificationList()
        {
            var notifications = nm.ListEnabled();

            return View(notifications);
        }
    }
}
