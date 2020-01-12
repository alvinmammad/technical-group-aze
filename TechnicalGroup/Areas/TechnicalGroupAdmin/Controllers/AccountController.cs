using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechnicalGroup.Areas.TechnicalGroupAdmin.Models;
using TechnicalGroup.Data;
using TechnicalGroup.ViewModels;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Controllers
{
    //[Route("account")]
    [Authorize]
    [Area("TechnicalGroupAdmin")]
    public class AccountController : Controller
    {
        private readonly TechnicalGroupDbContext _context;
        public AccountController(TechnicalGroupDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Login(VMLogin model)
        {
            if (model.UserName==null && model.Password==null)
            {
                ViewData["message"] = "İstifadəçi adı və ya şifrə boş ola bilməz";
                return View();
            }
            bool isUservalid = false;
            Admin user = _context.Admin.Where(usr =>
            usr.UserName == model.UserName &&
            usr.Password == model.Password).SingleOrDefault();
            if (user != null)
            {
                isUservalid = true;
            }
            if (ModelState.IsValid && isUservalid)
            {
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.Name, user.UserName));

                string[] roles = user.Roles.Split(",");

                foreach (string role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                var identity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.
                AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();
                props.IsPersistent = model.RememberMe;

                HttpContext.SignInAsync(
                CookieAuthenticationDefaults.
                AuthenticationScheme,
                principal, props).Wait();
                return RedirectToAction("Index", "Products");
            }
            else
            {
                ViewData["message"] = "İstifadəçi adı və ya şifrə yanlışdır .";

            }
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}