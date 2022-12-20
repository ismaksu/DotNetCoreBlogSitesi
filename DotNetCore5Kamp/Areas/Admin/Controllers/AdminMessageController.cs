using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DotNetCore5Kamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        Context c = new Context();
        Message2Manager mm2 = new Message2Manager(new EFMessage2Repository());

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
        public IActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMessage(Message2 msg)
        {
            var user = c.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            var usermail = user.Email;
            var authorID = user.Id;

            msg.SenderID = authorID;
            msg.MessageDate = DateTime.Now;
            msg.ReceiverID = 4;
            msg.MessageStat = true;

            mm2.AddEntity(msg);

            return RedirectToAction("Sendbox");
        }
    }
}
