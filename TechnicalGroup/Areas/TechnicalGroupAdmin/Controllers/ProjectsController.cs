using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechnicalGroup.Areas.TechnicalGroupAdmin.Models.AdminVM;
using TechnicalGroup.Data;
using TechnicalGroup.Models;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Controllers
{
    [Area("TechnicalGroupAdmin")]
    [Authorize]

    public class ProjectsController : Controller
    {
        private readonly TechnicalGroupDbContext _context;
        private readonly IHostingEnvironment _env;


        public ProjectsController(TechnicalGroupDbContext context,IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: TechnicalGroupAdmin/Projects
        public async Task<IActionResult> Index()
        {
            return View(await _context.Projects.Include(p=>p.ProjectPhotos).ToListAsync());
        }

        // GET: TechnicalGroupAdmin/Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VMProjectPhotos projectPhotos = new VMProjectPhotos()
            {
                Photos = await _context.ProjectPhotos.Where(pp => pp.ProjectID == id).ToListAsync(),
                Project = await _context.Projects.Include(p => p.ProjectPhotos).Where(p => p.ID == id).FirstOrDefaultAsync()
            };



            if (projectPhotos == null)
            {
                return NotFound();
            }

            return View(projectPhotos);
        }

        // GET: TechnicalGroupAdmin/Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind(include:"ID,LittleContent,LittleContent_Ru,LittleContent_Az,Description,Description_Ru,Description_Az")]*/ Projects projects)
        {
            if (ModelState.IsValid)
            {
                Projects newProject = new Projects();
                newProject.LittleContent = projects.LittleContent;
                newProject.LittleContent_Az = projects.LittleContent_Az;
                newProject.LittleContent_Ru = projects.LittleContent_Ru;
                newProject.Description = projects.Description;
                newProject.Description_Az = projects.Description_Az;
                newProject.Description_Ru= projects.Description_Ru;
               
                _context.Projects.Add(newProject);

                foreach (var photo in projects.PhotoNames)
                {
                    ProjectPhotos projectPhotos= new ProjectPhotos();
                    projectPhotos.Project= newProject;
                    projectPhotos.Photo = photo;
                    _context.ProjectPhotos.Add(projectPhotos);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(projects);
        }


        [HttpPost]
        public JsonResult AddPhoto()
        {
            List<IFormFile> photos = Request.Form.Files.ToList();

            List<object> photo_infos = new List<object>();

            foreach (var photo in photos)
            {
                string filename = DateTime.Now.ToShortDateString().Replace("/", "") + photo.FileName;
                //create path
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Projects", DateTime.Now.ToShortDateString().Replace("/", "") + photo.FileName);
                if (System.IO.File.Exists(path))
                {
                    var guid = new Guid();
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Projects", guid + DateTime.Now.ToShortDateString().Replace("/", "") + photo.FileName);
                    filename = guid + DateTime.Now.ToShortDateString().Replace("/", "") + photo.FileName;
                }

                //add photo to folder
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }
                var photo_info = new
                {
                    src = "/images/Projects/" + filename,
                    name = filename
                };
                photo_infos.Add(photo_info);
            }
            return Json(new { status = 200, data = photo_infos });

        }

        [HttpPost]
        public JsonResult DeletePhoto(string filename)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Projects", filename);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return Json(new { status = 200 });
            }
            else
            {
                return Json(new { status = 400 });
            }
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projects = await _context.Projects
                .FirstOrDefaultAsync(m => m.ID == id);
            if (projects == null)
            {
                return NotFound();
            }

            return View(projects);
        }

        // POST: TechnicalGroupAdmin/Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projects = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(projects);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectsExists(int id)
        {
            return _context.Projects.Any(e => e.ID == id);
        }
    }
}
