using DotNetCore5Kamp.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuthorList()
        {
            var jsonAuthors = JsonConvert.SerializeObject(authors);
            return Json(jsonAuthors);
        }

        public IActionResult ListAuthorByID(int authorId)
        {
            var findAuthor = authors.FirstOrDefault(x => x.ID == authorId);
            var jsonAuthors = JsonConvert.SerializeObject(findAuthor);
            return Json(jsonAuthors);
        }

        [HttpPost]
        public IActionResult AddAuthor(AuthorClass author)
        {
            authors.Add(author);
            var jsonAuthors = JsonConvert.SerializeObject(author);
            return Json(jsonAuthors);
        }

        public IActionResult DeleteAuthor(int id)
        {
            var author = authors.FirstOrDefault(x => x.ID == id);
            authors.Remove(author);
            return Json(author);
        }

        public IActionResult UpdateAuthor(AuthorClass _author)
        {
            var author = authors.FirstOrDefault(x => x.ID == _author.ID);
            author.Name = _author.Name;
            var jsonAuthor = JsonConvert.SerializeObject(author);
            return Json(jsonAuthor);
        }

        public static List<AuthorClass> authors = new List<AuthorClass>
        {
            new AuthorClass
            {
                ID = 1,
                Name = "İsmail"
            },
            new AuthorClass
            {
                ID = 2,
                Name = "Emily"
            },
            new AuthorClass
            {
                ID = 3,
                Name = "Rei"
            }
        };
    }
}
