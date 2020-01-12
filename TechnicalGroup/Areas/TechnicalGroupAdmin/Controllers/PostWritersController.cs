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

    public class PostWritersController : Controller
    {
        private readonly TechnicalGroupDbContext _context;

        public PostWritersController(TechnicalGroupDbContext context)
        {
            _context = context;
        }

        // GET: TechnicalGroupAdmin/PostWriters
        public async Task<IActionResult> Index()
        {
            return View(await _context.PostWriters.ToListAsync());
        }

        // GET: TechnicalGroupAdmin/PostWriters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postWriter = await _context.PostWriters
                .FirstOrDefaultAsync(m => m.ID == id);
            if (postWriter == null)
            {
                return NotFound();
            }

            return View(postWriter);
        }

        // GET: TechnicalGroupAdmin/PostWriters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TechnicalGroupAdmin/PostWriters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Fullname")] PostWriter postWriter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postWriter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(postWriter);
        }

        // GET: TechnicalGroupAdmin/PostWriters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postWriter = await _context.PostWriters.FindAsync(id);
            if (postWriter == null)
            {
                return NotFound();
            }
            return View(postWriter);
        }

        // POST: TechnicalGroupAdmin/PostWriters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Fullname")] PostWriter postWriter)
        {
            if (id != postWriter.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postWriter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostWriterExists(postWriter.ID))
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
            return View(postWriter);
        }

        // GET: TechnicalGroupAdmin/PostWriters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postWriter = await _context.PostWriters
                .FirstOrDefaultAsync(m => m.ID == id);
            if (postWriter == null)
            {
                return NotFound();
            }

            return View(postWriter);
        }

        // POST: TechnicalGroupAdmin/PostWriters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var postWriter = await _context.PostWriters.FindAsync(id);
            _context.PostWriters.Remove(postWriter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostWriterExists(int id)
        {
            return _context.PostWriters.Any(e => e.ID == id);
        }
    }
}
