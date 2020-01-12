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

    public class AboutItemsController : Controller
    {
        private readonly TechnicalGroupDbContext _context;

        public AboutItemsController(TechnicalGroupDbContext context)
        {
            _context = context;
        }

        // GET: TechnicalGroupAdmin/AboutItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutItems.ToListAsync());
        }

        // GET: TechnicalGroupAdmin/AboutItems/Details/5
       

        // GET: TechnicalGroupAdmin/AboutItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TechnicalGroupAdmin/AboutItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Title_Ru,Title_Az,Content,Content_Az,Content_Ru")] AboutItems aboutItems)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aboutItems);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutItems);
        }

        // GET: TechnicalGroupAdmin/AboutItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutItems = await _context.AboutItems.FindAsync(id);
            if (aboutItems == null)
            {
                return NotFound();
            }
            return View(aboutItems);
        }

        // POST: TechnicalGroupAdmin/AboutItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Title_Ru,Title_Az,Content,Content_Az,Content_Ru")] AboutItems aboutItems)
        {
            if (id != aboutItems.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutItems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutItemsExists(aboutItems.ID))
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
            return View(aboutItems);
        }

        // GET: TechnicalGroupAdmin/AboutItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutItems = await _context.AboutItems
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aboutItems == null)
            {
                return NotFound();
            }

            return View(aboutItems);
        }

        // POST: TechnicalGroupAdmin/AboutItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutItems = await _context.AboutItems.FindAsync(id);
            _context.AboutItems.Remove(aboutItems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutItemsExists(int id)
        {
            return _context.AboutItems.Any(e => e.ID == id);
        }
    }
}
