using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechnicalGroup.Data;
using TechnicalGroup.Models;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Controllers
{
    [Area("TechnicalGroupAdmin")]
    [Authorize]

    public class HomeAboutItemsController : Controller
    {
        private readonly TechnicalGroupDbContext _context;

        public HomeAboutItemsController(TechnicalGroupDbContext context)
        {
            _context = context;
        }

        // GET: TechnicalGroupAdmin/HomeAboutItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeAboutItems.ToListAsync());
        }

        // GET: TechnicalGroupAdmin/HomeAboutItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TechnicalGroupAdmin/HomeAboutItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Item,Item_Ru,Item_Az")] HomeAboutItems homeAboutItems)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeAboutItems);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeAboutItems);
        }

        // GET: TechnicalGroupAdmin/HomeAboutItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeAboutItems = await _context.HomeAboutItems.FindAsync(id);
            if (homeAboutItems == null)
            {
                return NotFound();
            }
            return View(homeAboutItems);
        }

        // POST: TechnicalGroupAdmin/HomeAboutItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Item,Item_Ru,Item_Az")] HomeAboutItems homeAboutItems)
        {
            if (id != homeAboutItems.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeAboutItems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeAboutItemsExists(homeAboutItems.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(homeAboutItems);
        }

        // GET: TechnicalGroupAdmin/HomeAboutItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeAboutItems = await _context.HomeAboutItems
                .FirstOrDefaultAsync(m => m.ID == id);
            if (homeAboutItems == null)
            {
                return NotFound();
            }

            return View(homeAboutItems);
        }

        // POST: TechnicalGroupAdmin/HomeAboutItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeAboutItems = await _context.HomeAboutItems.FindAsync(id);
            _context.HomeAboutItems.Remove(homeAboutItems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeAboutItemsExists(int id)
        {
            return _context.HomeAboutItems.Any(e => e.ID == id);
        }
    }
}
