using Allup.DAL;
using Allup.Extentions;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BrandController(AppDbContext context, IWebHostEnvironment env = null)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Brand> brands = _context.Brands
                .Include(b=>b.Products)
                .ToList();

            return View(brands);
        }

        public IActionResult ActiveList()
        {
            List<Brand> brands = _context.Brands
                .Where(p => p.IsDeleted == false).ToList();

            return View(brands);
        }
        public IActionResult DeleteList()
        {
            List<Brand> brands = _context.Brands
                .Where(p => p.IsDeleted == true).ToList();

            return View(brands);
        }

        public IActionResult Undelete(int id)
        {
            Brand deletedBrand = _context.Brands.Find(id);
            if (deletedBrand == null) return NotFound();
            deletedBrand.DeletedAt = null;
            deletedBrand.IsDeleted = false;
            deletedBrand.CreatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Create()
        {
            Brand brand = new Brand();
            return View(brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Brand brand)
        {
            if (!ModelState.IsValid) return View();

            Brand newBrand = new Brand
            {
                Name = brand.Name,
                CreatedAt = DateTime.Now,
                ImageUrl = "images/" + brand.Image.SaveImage(_env, @"assets\images"),
            };

            _context.Brands.Add(newBrand);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public  IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            Brand dbBrand =  _context.Brands.Find(id);

            if (dbBrand == null) return NotFound();

            dbBrand.IsDeleted = true;
            dbBrand.DeletedAt = DateTime.Now;
            dbBrand.CreatedAt = null;

            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if(id == null) return NotFound();

            Brand dbBrand = _context.Brands.FirstOrDefault(b => b.Id == id);

            if (dbBrand == null) return NotFound();

            return View(dbBrand);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Brand brand)
        {
            Brand dbBrand =  _context.Brands.FirstOrDefault(x => x.Id == brand.Id);
            if (dbBrand == null) return NotFound();

            if (ModelState["Image"] != null)
            {
                if (!brand.Image.IsImage())
                {
                    ModelState.AddModelError("Image", "Wrong format");
                    return View();
                }
                if (brand.Image.ImageSize(8000))
                {
                    ModelState.AddModelError("Image", "OVERsize");
                    return View();
                }


                string path = Path.Combine(_env.WebRootPath, @"assets\images\brand", dbBrand.ImageUrl);
                ImageService.DeleteImage(path);
                dbBrand.ImageUrl = "images/brand/" + brand.Image.SaveImage(_env, @"assets\images\brand");
            }
            var brandName = _context.Brands.FirstOrDefault(x => x.Name.ToLower() == brand.Name.ToLower());

            if (brandName != null)
            {
                if (dbBrand.Name.ToLower() != brandName.Name.ToLower())
                {
                    ModelState.AddModelError("Name", "Model Name is exsist");
                    return View("Update");
                }
            }
            dbBrand.Name = brand.Name;
            dbBrand.UptadetAt = DateTime.Now;

             _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
