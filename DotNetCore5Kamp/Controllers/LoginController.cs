using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using DotNetCore5Kamp.Models;

namespace DotNetCore5Kamp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //AuthorManager aum = new AuthorManager(new EFAuthorRepository());

        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View(p);
            }
        }

        

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
