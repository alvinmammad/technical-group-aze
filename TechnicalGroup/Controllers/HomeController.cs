using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using TechnicalGroup.Data;
using TechnicalGroup.ViewModels;
using TechnicalGroup.Models;
using Microsoft.EntityFrameworkCore;

namespace TechnicalGroup.Controllers
{
    //[Route("home")]
    public class HomeController : Controller
    {
        private readonly TechnicalGroupDbContext _context;
        //private readonly HttpContext httpContext;

        public HomeController(TechnicalGroupDbContext context)
        {
            _context = context;
            //httpContext = _httpContext;
        }
        public IActionResult Index(string lang)
        {
            ViewBag.lang = lang;
            VMHome model = new VMHome()
            {
                AboutItems = _context.HomeAboutItems.Take(6).ToList(),
                Facts = _context.Facts.Take(4).ToList(),
                Posts = _context.Posts.Include(p => p.PostWriter).OrderBy(p => p.CreatedDate).Take(3).ToList(),
                Products = _context.Products.Include(p => p.ProductPhotos).Where(p => p.IsActive == true).OrderBy(p => p.ID).Take(8).ToList(),
                Projects = _context.Projects.Include(p => p.ProjectPhotos).OrderBy(p => p.ID).Take(6).ToList(),
                ServiceItems = _context.ServiceItems.OrderBy(si => si.ID).Take(9).ToList()
            };
            return View(model);
        }

        public IActionResult Contact()
        {
            VMContact model = new VMContact()
            {
                Settings = _context.Settings.First()
            };
            return View(model);
        }
        public JsonResult Message(VMContact model)
        {
            if (string.IsNullOrEmpty(model.Name)
                ||
                string.IsNullOrEmpty(model.Phone)
                ||
                string.IsNullOrEmpty(model.Email)
                ||
                string.IsNullOrEmpty(model.Subject)
                ||
                string.IsNullOrEmpty(model.Message))
            {
                Response.StatusCode = 406;
                return Json("Bütün xanalar doldurulmalıdır");
            }

            var body = "<ul>" +
                "<li>Ad : {0}</li>" +
                "<li>E-poçt: {1}</li>" +
                "<li>Mesajın başlığı : {3}</li>" +
                "<li>Mesaj : {2}</li>" +
                "<li>Əlaqə nömrəsi : {4}</li>" +
                "</ul>";
            var MailMessage = new MailMessage();
            MailMessage.To.Add(new MailAddress(model.Email));
            MailMessage.From= new MailAddress("info@technicalgroup.az");
            MailMessage.Subject = "Your email subject";
            MailMessage.Body = string.Format(body, model.Name, model.Email, model.Message, model.Subject, model.Phone);
            MailMessage.IsBodyHtml = true;

            

            SmtpClient client = new SmtpClient
            {
                Host = "webmail.technicalgroup.az",
                Port = 465,
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout=20000,
                Credentials = new NetworkCredential
                {
                    UserName = "info@technicalgroup.az",
                    Password = "Adm1n12345!@"
                }
                
            };

            client.Send(MailMessage);


            return Json("Mesajınız uğurla göndərildi , təşəkkürlər !");
        }



        public IActionResult About(string lang)
        {
            ViewBag.lang = lang;
            VMAbout model = new VMAbout()
            {
                AboutItems = _context.AboutItems.Take(3).ToList(),
                Facts = _context.Facts.Take(4).ToList(),
                Setting = _context.Settings.FirstOrDefault()
            };
            return View(model);
        }

        public IActionResult Services()
        {
            List<ServiceItems> serviceItems = _context.ServiceItems.ToList();
            return View(serviceItems);
        }

        public IActionResult Projects(string lang)
        {
            ViewBag.lang = lang;
            ViewBag.TotalCount = _context.Projects.Count();
            return View(
                _context.Projects.Include(p => p.ProjectPhotos).OrderByDescending(p => p.ID).Take(3).ToList()
                );
        }

        public IActionResult LoadProjects(int skip, string lang)
        {
            ViewBag.lang = lang;
            var model =
               _context.Projects.Include(p => p.ProjectPhotos).OrderByDescending(p => p.ID).Skip(skip).Take(3).ToList();
            return PartialView("_ProjectsPartial", model);

        }

        public IActionResult ProjectDetail(int? id, string lang)
        {
            ViewBag.lang = lang;
            if (!id.HasValue)
            {
                return RedirectToAction("Error");
            }
            VMProjectPhotosUI project = new VMProjectPhotosUI
            {
                ProjectPhotos = _context.ProjectPhotos.Where(pp => pp.ProjectID == id).ToList(),
                Project = _context.Projects.Include(p => p.ProjectPhotos).Where(p => p.ID == id).FirstOrDefault()
            };
            if (project == null)
            {
                return RedirectToAction("Error");
            }
            return View(project);
        }


        public IActionResult Products(string lang)
        {
            ViewBag.lang = lang;
            ViewBag.TotalCountProducts = _context.Products.Where(p=>p.IsActive==true).Count();
            VMProducts model = new VMProducts();
            model.Products = _context.Products.Include(p => p.ProductCategory).Include(p => p.ProductPhotos).Where(p => p.IsActive == true).OrderBy(p => p.ID).Take(4).ToList();
            model.Categories = _context.ProductCategories.OrderBy(c => c.CategoryName).ToList();
            return View(model);
        }

        public IActionResult ProductDetail(int? id, string lang)
        {
            ViewBag.lang = lang;
            if (!id.HasValue)
            {
                return RedirectToAction("Error");
            }
            //var product = _context.Products.Include(p => p.ProductPhotos).Include(p => p.ProductCategory).FirstOrDefault(p => p.ID == id);
            VMProductPhotosUI product = new VMProductPhotosUI
            {
                ProductPhotos = _context.ProductPhotos.Where(pp => pp.ProductID == id).ToList(),
                Product = _context.Products.Include(p => p.ProductPhotos).Include(p => p.ProductCategory).Where(p => p.ID == id).FirstOrDefault()
            };
            if (product == null)
            {
                return RedirectToAction("Error");
            }

            Meta meta = new Meta()
            {
                Name = product.Product.Name,
                Desc = product.Product.Description_Az,
                Type = "article",
                Image = this.GetBaseUrl() + Url.Content("images/Products/" + product.Product.Photo)
            };

            ViewBag.Meta = meta;
            return View(product);
        }
        private string GetBaseUrl()
        {
            var request = Request;
            var host = request.Host.ToUriComponent();
            var pathBase = request.PathBase.ToUriComponent();
            var baseUrl = string.Format($"{request.Scheme}://{host}{pathBase}");
            return baseUrl;
        }

        public IActionResult LoadProducts(int value, string lang)
        {
            ViewBag.lang = lang;

            var products = _context.Products.Include(p => p.ProductPhotos).Where(p => p.ProductCategoryID == value && p.IsActive==true).ToList();
            return PartialView("_ProductsPartial", products);
        }

        public IActionResult LoadFilteredProducts(string value, string lang)
        {
            ViewBag.lang = lang;
            List<Products> product = _context.Products.Include(p => p.ProductPhotos).Where(p=>p.IsActive==true).ToList();
            if (!string.IsNullOrEmpty(value))
            {
                if (value == "name")
                {
                    return PartialView("_ProductsPartial", product.Where(p => p.IsActive == true).OrderBy(p => p.Name).ToList());
                }
                else if (value == "cheap")
                {
                    return PartialView("_ProductsPartial", product.Where(p => p.IsActive == true).OrderBy(p => p.Price).ToList());

                }
                else if (value == "expensive")
                {
                    return PartialView("_ProductsPartial", product.Where(p => p.IsActive == true).OrderByDescending(p => p.Price).ToList());

                }

                else if (value == "discount")
                {
                    return PartialView("_ProductsPartial", product.Where(p => p.IsActive == true && p.Discount > 0).OrderBy(p => p.Discount).ToList());
                }

                else
                {
                    if (product != null && product.Count > 0)
                    {
                        return PartialView("_ProductsPartial", product);
                    }
                    else
                    {
                        return PartialView("_ProductsPartial", product);
                    }
                }

            }

            return PartialView("_ProductsPartial", product);

        }

        public IActionResult LoadMoreProducts(int skip, string lang)
        {
            ViewBag.lang = lang;
            VMProducts model = new VMProducts();
            var products = _context.Products.Include(p => p.ProductPhotos).Where(p => p.IsActive == true).Skip(skip).Take(4).ToList();
            return PartialView("_ProductsPartial", products);
        }

        public IActionResult Blog(string lang, int page = 1)
        {

            ViewBag.lang = lang;
            VMBlog model = new VMBlog();
            model.TotalPage = Convert.ToInt32(Math.Ceiling(_context.Posts.Count() / 3.0));
            if (page < 1 || page > model.TotalPage)
            {
                return RedirectToAction("Error");
            }

            model.Posts = _context.Posts.Include(p => p.PostWriter).OrderByDescending(p => p.CreatedDate).Skip((page - 1) * 3).Take(3).ToList();
            model.Page = page;
            return View(model);
        }

        public IActionResult BlogDetail(int? id, string lang)
        {
            ViewBag.lang = lang;
            if (!id.HasValue)
            {
                return RedirectToAction("Error");
            }
            VMSingleBlog model = new VMSingleBlog();
            model.Post = _context.Posts.FirstOrDefault(p => p.ID == id);

            if (model == null)
            {
                return RedirectToAction("Error");
            }
            ViewBag.Posts = _context.Posts.ToList();
            return View(model);
        }

        public ActionResult Comments(string OwnerFullname, string OwnerEmail,string Text, int PostID)
        {
            Comments comment = new Comments();
            comment.OwnerFullname = OwnerFullname;
            comment.Text = Text;
            comment.PostID = PostID;
            comment.Date = DateTime.Now;
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return RedirectToAction("blogdetail");
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true }
                );

            Uri uri = new Uri($"{Request.Scheme}://{Request.Host}" + returnUrl.Substring(1));
            return Redirect(uri.AbsoluteUri);
        }


        public IActionResult Error()
        {
            return View();
        }

    }
}
