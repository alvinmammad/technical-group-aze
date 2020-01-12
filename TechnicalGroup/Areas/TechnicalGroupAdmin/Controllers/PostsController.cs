using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static TechnicalGroup.Utilities.Utilities;
using Microsoft.EntityFrameworkCore;
using TechnicalGroup.Data;
using TechnicalGroup.Extensions;
using TechnicalGroup.Models;
using Microsoft.AspNetCore.Authorization;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Controllers
{
    [Area("TechnicalGroupAdmin")]
    [Authorize]

    public class PostsController : Controller
    {
        private readonly TechnicalGroupDbContext _context;
        private readonly IHostingEnvironment _env;
        public PostsController(TechnicalGroupDbContext context, IHostingEnvironment env)
        {
            _env = env;
            _context = context;
        }

        // GET: TechnicalGroupAdmin/Posts
        public async Task<IActionResult> Index()
        {
            var technicalGroupDbContext = _context.Posts.Include(p => p.PostWriter);
            return View(await technicalGroupDbContext.ToListAsync());
        }

        // GET: TechnicalGroupAdmin/Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.PostWriter)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: TechnicalGroupAdmin/Posts/Create
        public IActionResult Create()
        {
            ViewData["PostWriterID"] = new SelectList(_context.PostWriters, "ID", "Fullname");
            return View();
        }

        // POST: TechnicalGroupAdmin/Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("ID,Image,Title,Title_Ru,Title_Az,Text,Text_Ru,Text_Az,InstagramURL,PostWriterID")]*/ Post post)
        {
            if (!ModelState.IsValid)
            {
                ViewData["PostWriterID"] = new SelectList(_context.PostWriters, "ID", "Fullname", post.PostWriterID);
                return View(post);

            }
            if (post.Photo == null)
            {
                ModelState.AddModelError("Photo", "Şəkil seçilməlidir .");
                return View(post);
            }

            if (!post.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Faylın tipi düzgün deyil .");
                return View(post);
            }

            if (post.Photo.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("Photo", "Şəkilin ölçüsü 2 MB-dan çox olmamalıdır .");
                return View(post);
            }

            post.Image = await post.Photo.SaveAsync(_env.WebRootPath, "Posts");
            _context.Add(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        // GET: TechnicalGroupAdmin/Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["PostWriterID"] = new SelectList(_context.PostWriters, "ID", "Fullname", post.PostWriterID);
            return View(post);
        }

        // POST: TechnicalGroupAdmin/Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, /*[Bind("ID,Image,CreatedDate,Title,Title_Ru,Title_Az,Text,Text_Ru,Text_Az,InstagramURL,PostWriterID")]*/ Post post)
        {
            if (!ModelState.IsValid)
            {
                ViewData["PostWriterID"] = new SelectList(_context.PostWriters, "ID", "Fullname", post.PostWriterID);
                return View(post);

            };

            Post postFromDB = await _context.Posts.FindAsync(post.ID);

            if (post.Photo != null)
            {
                if (!post.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Fayl növü uyğun deyil !");
                    return View(post);
                }

                if (!post.Photo.IsLessThan(2))
                {
                    ModelState.AddModelError("Photo", "Şəkil ölçüsü 2 MB-dan çox ola bilməz !");
                    return View(post);
                }

                //remove old image
                RemoveImage(_env.WebRootPath, postFromDB.Image);

                //save new image
                postFromDB.Image= await post.Photo.SaveAsync(_env.WebRootPath, "Posts");
            }
            postFromDB.InstagramURL = post.InstagramURL;
            postFromDB.PostWriterID = post.PostWriterID;
            postFromDB.Text = post.Text;
            postFromDB.Text_Az = post.Text_Az;
            postFromDB.Text_Ru = post.Text_Ru;
            postFromDB.Title = post.Title;
            postFromDB.Title_Az = post.Title_Az;
            postFromDB.Title_Ru = post.Title_Ru;
            postFromDB.CreatedDate = post.CreatedDate;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        // GET: TechnicalGroupAdmin/Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.PostWriter)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: TechnicalGroupAdmin/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            
            RemoveImage(_env.WebRootPath, post.Image);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.ID == id);
        }
    }
}
