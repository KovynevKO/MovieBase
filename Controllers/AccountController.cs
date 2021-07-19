using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieBase.Models;
using MovieBase.Models.Repository;
using MovieBase.ViewModels.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MovieBase.Controllers
{
    public class AccountController : Controller
    {
        private IAccountRepository accountRepository;
        public AccountController(IAccountRepository repository)
        {
            this.accountRepository = repository;
        }
 
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.IsUserInRole = User?.Identity?.IsAuthenticated;
            if (ViewBag.IsUserInRole == null)
                ViewBag.IsUserInRole = false;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            User user = await accountRepository.GetUserByLogIn(model.Login, model.Password);
            if (user != null)
            {
                await Authenticate(user);

                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Registration()
        {
            ViewBag.IsUserInRole = User?.Identity?.IsAuthenticated;
            if (ViewBag.IsUserInRole == null)
                ViewBag.IsUserInRole = false;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {  
                User user = await accountRepository.GetUserByEmail(model.Email);
                if (user == null)
                {
                    user = new User { Email = model.Email, Login = model.Login, Password = model.Password, Role = "User" };

                    await accountRepository.Add(user);
                    await accountRepository.Save();
                    await Authenticate(user); 

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
            };
  
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
    
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
