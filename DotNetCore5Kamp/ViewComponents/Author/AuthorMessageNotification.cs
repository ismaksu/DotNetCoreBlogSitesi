using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.ViewComponents.Author
{
    public class AuthorMessageNotification:ViewComponent
    {
        Message2Manager mm2 = new Message2Manager(new EFMessage2Repository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            int id = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var values = mm2.ListInboxByAuthor(id);
            return View(values);
        }
    }
}
