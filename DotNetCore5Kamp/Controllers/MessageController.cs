using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager mm2 = new Message2Manager(new EFMessage2Repository());
        Context c = new Context();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var userID = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var values = mm2.ListInboxByAuthor(userID);
            return View(values);
        }

        public IActionResult Sendbox()
        {
            var username = User.Identity.Name;
            var userID = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var values = mm2.ListSendboxByAuthor(userID);
            return View(values);
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var values = mm2.FindByID(id);
            return View(values);
        }

        [HttpGet]
        public IActionResult MessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessageSend(Message2 msg)
        {
            var username = User.Identity.Name;
            var userID = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();

            msg.SenderID = userID;
            msg.ReceiverID = 4;
            msg.MessageStat = true;
            msg.MessageDate = DateTime.Now;

            mm2.AddEntity(msg);

            return RedirectToAction("Inbox");
        }
    }
}
