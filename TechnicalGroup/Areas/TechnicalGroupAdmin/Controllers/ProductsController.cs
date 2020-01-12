using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Data;
using TechnicalGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using static TechnicalGroup.Utilities.Utilities;
using TechnicalGroup.Areas.TechnicalGroupAdmin.Models.AdminVM;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Controllers
{
    [Area("TechnicalGroupAdmin")]
    [Authorize]

    public class ProductsController : Controller
    {
        private readonly IHostingEnvironment env;
        private readonly TechnicalGroupDbContext db;
        public ProductsController(TechnicalGroupDbContext _db,IHostingEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        //[Route("index")]
        public async Task<IActionResult> Index()
        {
            var technicalGroupDbContext = db.Products.Include(p => p.ProductPhotos);
            return View(await technicalGroupDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VMProductPhotos productPhotos = new VMProductPhotos()
            {
                Photos = await db.ProductPhotos.Where(pp => pp.ProductID == id).ToListAsync(),
                Product = await db.Products.Include(p => p.ProductPhotos).Where(p => p.ID == id).FirstOrDefaultAsync()
            };
           
            if (productPhotos == null)
            {
                return NotFound();
            }
            return View(productPhotos);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewData["ProductCategoryID"] = new SelectList(db.ProductCategories, "ID", "CategoryName_Az");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Products product)
        {
            if (ModelState.IsValid)
            {
                Products new_product = new Products();
                new_product.ProductCategoryID = product.ProductCategoryID;
                new_product.Description = product.Description;
                new_product.Description_Az = product.Description_Az;
                new_product.Description_Ru = product.Description_Ru;
                new_product.Info = product.Info;
                new_product.Info_Az = product.Info_Az;
                new_product.Info_Ru = product.Info_Ru;
                new_product.IsActive = product.IsActive;
                new_product.Name = product.Name;
                new_product.Price= product.Price;
                new_product.Discount = product.Discount;
                db.Products.Add(new_product);

                foreach (var photo in product.PhotoNames)
                {
                    ProductPhotos productPhoto = new ProductPhotos();
                    productPhoto.Product= new_product;
                    productPhoto.Photo = photo;
                    db.ProductPhotos.Add(productPhoto);
                }

                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            ViewData["ProductCategoryID"] = new SelectList(db.ProductCategories, "ID", "CategoryName_Az");
            return View(product);
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
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Products", DateTime.Now.ToShortDateString().Replace("/", "") + photo.FileName);
                if (System.IO.File.Exists(path))
                {
                    var guid = new Guid();
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Products", guid + DateTime.Now.ToShortDateString().Replace("/", "") + photo.FileName);
                    filename = guid + DateTime.Now.ToShortDateString().Replace("/", "") + photo.FileName;
                }

                //add photo to folder
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }
                var photo_info = new
                {
                    src = "/images/Products/" + filename,
                    name = filename
                };
                photo_infos.Add(photo_info);
            }
            return Json(new { status = 200, data = photo_infos });

        }
      
      

        [HttpPost]
        public JsonResult DeletePhoto(string filename)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Products", filename);
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

            var products = await db.Products.Include(p=>p.ProductPhotos)
                .FirstOrDefaultAsync(p => p.ID == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: TechnicalGroupAdmin/Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var products = await db.Products.FindAsync(id);
            db.Products.Remove(products);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(int id)
        {
            return db.Products.Any(e => e.ID == id);
        }

    }
}