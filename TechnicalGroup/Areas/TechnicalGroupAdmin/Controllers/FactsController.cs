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

    public class FactsController : Controller
    {
        private readonly TechnicalGroupDbContext _context;

        public FactsController(TechnicalGroupDbContext context)
        {
            _context = context;
        }

        // GET: TechnicalGroupAdmin/Facts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Facts.ToListAsync());
        }

        // GET: TechnicalGroupAdmin/Facts/Details/5

        // GET: TechnicalGroupAdmin/Facts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TechnicalGroupAdmin/Facts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Key,Value,Value_Ru,Value_Az")] Facts facts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(facts);
        }

        // GET: TechnicalGroupAdmin/Facts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facts = await _context.Facts.FindAsync(id);
            if (facts == null)
            {
                return NotFound();
            }
            return View(facts);
        }

        // POST: TechnicalGroupAdmin/Facts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Key,Value,Value_Ru,Value_Az")] Facts facts)
        {
            if (id != facts.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactsExists(facts.ID))
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
            return View(facts);
        }

        // GET: TechnicalGroupAdmin/Facts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facts = await _context.Facts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (facts == null)
            {
                return NotFound();
            }

            return View(facts);
        }

        // POST: TechnicalGroupAdmin/Facts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facts = await _context.Facts.FindAsync(id);
            _context.Facts.Remove(facts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FactsExists(int id)
        {
            return _context.Facts.Any(e => e.ID == id);
        }
    }
}
