using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static TechnicalGroup.Extensions.IFormFileExtensions;
using static TechnicalGroup.Utilities.Utilities;
using Microsoft.EntityFrameworkCore;
using TechnicalGroup.Data;
using TechnicalGroup.Models;
using Microsoft.AspNetCore.Authorization;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Controllers
{
    [Area("TechnicalGroupAdmin")]
    [Authorize]

    public class SettingsController : Controller
    {
        private readonly TechnicalGroupDbContext _context;
        private readonly IHostingEnvironment _env;
        public SettingsController(TechnicalGroupDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env; 

        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Settings.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var settings = await _context.Settings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (settings == null)
            {
                return NotFound();
            }

            return View(settings);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var settings = await _context.Settings.FindAsync(id);
            if (settings == null)
            {
                return NotFound();
            }
            return View(settings);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Settings settings)
        {
            if (!ModelState.IsValid) return View(settings);

            Settings settingFromDB = await _context.Settings.FindAsync(settings.ID);

            if (settings.SiteLogoImage != null)
            {
                if (!settings.SiteLogoImage.IsImage())
                {
                    ModelState.AddModelError("Photo", "Fayl növü uyğun deyil !");
                    return View(settings);
                }

                if (!settings.SiteLogoImage.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "Şəkil ölçüsü 2 MB-dan çox ola bilməz !");
                    return View(settings);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, settingFromDB.SiteLogo);

                //save new image
                settingFromDB.SiteLogo = await settings.SiteLogoImage.SaveAsync(_env.WebRootPath, "Statics");
            }

            settingFromDB.MainBannerTitle = settings.MainBannerTitle;
            settingFromDB.MainBannerTitle_Az= settings.MainBannerTitle_Az;
            settingFromDB.MainBannerTitle_Ru = settings.MainBannerTitle_Ru;
            settingFromDB.ContactAddress = settings.ContactAddress;
            settingFromDB.ContactEmail= settings.ContactEmail;
            settingFromDB.ContactPhone= settings.ContactPhone;
            settingFromDB.AboutDesc= settings.AboutDesc;
            settingFromDB.AboutDesc_Az= settings.AboutDesc_Az;
            settingFromDB.AboutDesc_Ru= settings.AboutDesc_Ru;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }       

        private bool SettingsExists(int id)
        {
            return _context.Settings.Any(e => e.ID == id);
        }
    }
}
