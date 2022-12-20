using DotNetCore5Kamp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<CommentUser>
            {
                new CommentUser
                {
                    ID = 1,
                    Username = "İsmail"
                },
                new CommentUser
                {
                    ID = 2,
                    Username = "Mehmet"
                },
                new CommentUser
                {
                    ID = 3,
                    Username = "Emel"
                }
            };
            return View(commentValues);
        }
    }
}
