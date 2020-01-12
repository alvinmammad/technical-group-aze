using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Controllers
{
    [Area("TechnicalGroupAdmin")]
    //[Route("TechnicalGroupAdmin/Dashboard")]
    [Authorize]
    public class DashboardController : Controller
    {
        //[Route("")]
        //[Route("Index")]
        public IActionResult Index()
        {
            string userName = HttpContext.User.Identity.Name;

            if (HttpContext.User.IsInRole("Administrator"))
            {
                ViewData["adminMessage"] = "You are an Administrator!";
            }

            if (HttpContext.User.IsInRole("Manager"))
            {
                ViewData["managerMessage"] = "You are a Manager!";
            }

            ViewData["username"] = userName;

            return View();
        }
    }
}