using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Controllers
{

    public class BlogController : Controller
    {

        BlogManager bm = new BlogManager(new EFBlogRepository());
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.ListBlogWithCategory();
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult BlogDetails(int id)
        {
            var values = bm.ListBlogByID(id);
            ViewBag.ids = id;
            return View(values);
        }

        [Authorize]
        public IActionResult BlogListByAuthor()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var userID = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();

            var values = bm.ListBlogWithCategory(userID);
            return View(values);
        }

        [Authorize]
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryValues = (from x in cm.ListEntity()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var userID = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();

            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(blog);

            if (result.IsValid)
            {
                blog.BlogCreationDate = DateTime.Now;
                blog.BlogStat = true;
                blog.AuthorID = userID;
                bm.AddEntity(blog);
                return RedirectToAction("BlogListByAuthor", "Blog");
            }
            else
            {
                List<SelectListItem> categoryValues = (from x in cm.ListEntity()
                                                       select new SelectListItem
                                                       {
                                                           Text = x.CategoryName,
                                                           Value = x.CategoryID.ToString()
                                                       }).ToList();
                ViewBag.categoryValues = categoryValues;
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();


        }

        [Authorize]
        public IActionResult BlogDelete(int id)
        {
            var blogValue = bm.FindByID(id);
            bm.DeleteEntity(blogValue);
            return RedirectToAction("BlogListByAuthor", "Blog");
        }

        [Authorize]
        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            List<SelectListItem> categoryValues = (from x in cm.ListEntity()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;
            var blogValue = bm.FindByID(id);
            return View(blogValue);
        }

        [Authorize]
        [HttpPost]
        public IActionResult BlogEdit(Blog blog)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(blog);

            if (result.IsValid)
            {
                bm.UpdateEntity(blog);
                return RedirectToAction("BlogListByAuthor", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
