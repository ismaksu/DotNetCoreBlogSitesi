using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DotNetCore5Kamp.Models;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Controllers
{
    public class AuthorController : Controller
    {
        AuthorManager aum = new AuthorManager(new EFAuthorRepository());
        UserManager um = new UserManager(new EFUserRepository());

        private readonly UserManager<AppUser> _userManager;

        public AuthorController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        Context c = new Context();

        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var name = c.Users.Where(x => x.UserName == username).Select(y => y.Name).FirstOrDefault();

            ViewBag.name = name;
            return View();
        }

        public IActionResult AuthorProfile()
        {
            return View();
        }

        public IActionResult AuthorTest()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AuthorEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.name = values.Name;
            model.username = values.UserName;
            model.mail = values.Email;
            model.imageurl = values.ImageURL;
            model.password = values.PasswordHash;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AuthorEditProfile(UserUpdateViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.Name = model.name;
            values.UserName = model.username;
            values.Email = model.mail;
            values.ImageURL = model.imageurl;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");
        }

        public PartialViewResult AuthorFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult AuthorAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AuthorAdd(AddProfileImage pImage)
        {
            AuthorValidator auv = new AuthorValidator();
            Author p = new Author();
            if (pImage.AuthorImage != null)
            {
                var extension = Path.GetExtension(pImage.AuthorImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AuthorImages/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImage.AuthorImage.CopyTo(stream);
                p.AuthorImage = "/AuthorImages/" + newImageName;
            }

            p.AuthorMail = pImage.AuthorMail;
            p.AuthorName = pImage.AuthorName;
            p.AuthorPassword = pImage.AuthorPassword;
            p.AuthorStat = pImage.AuthorStat;
            p.AuthorDesc = pImage.AuthorDesc;

            ValidationResult result = auv.Validate(p);

            if (result.IsValid)
            {
                aum.AddEntity(p);

                return RedirectToAction("Index", "Dashboard");
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
