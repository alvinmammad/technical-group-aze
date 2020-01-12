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

    public class ServiceItemsController : Controller
    {
        private readonly TechnicalGroupDbContext _context;

        public ServiceItemsController(TechnicalGroupDbContext context)
        {
            _context = context;
        }

        // GET: TechnicalGroupAdmin/ServiceItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServiceItems.ToListAsync());
        }

        // GET: TechnicalGroupAdmin/ServiceItems/Details/5
        

        // GET: TechnicalGroupAdmin/ServiceItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TechnicalGroupAdmin/ServiceItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Title_Ru,Title_Az,Content,Content_Ru,Content_Az")] ServiceItems serviceItems)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceItems);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceItems);
        }

        // GET: TechnicalGroupAdmin/ServiceItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceItems = await _context.ServiceItems.FindAsync(id);
            if (serviceItems == null)
            {
                return NotFound();
            }
            return View(serviceItems);
        }

        // POST: TechnicalGroupAdmin/ServiceItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Title_Ru,Title_Az,Content,Content_Ru,Content_Az")] ServiceItems serviceItems)
        {
            if (id != serviceItems.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceItems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceItemsExists(serviceItems.ID))
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
            return View(serviceItems);
        }

        // GET: TechnicalGroupAdmin/ServiceItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceItems = await _context.ServiceItems
                .FirstOrDefaultAsync(m => m.ID == id);
            if (serviceItems == null)
            {
                return NotFound();
            }

            return View(serviceItems);
        }

        // POST: TechnicalGroupAdmin/ServiceItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceItems = await _context.ServiceItems.FindAsync(id);
            _context.ServiceItems.Remove(serviceItems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceItemsExists(int id)
        {
            return _context.ServiceItems.Any(e => e.ID == id);
        }
    }
}
