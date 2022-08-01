using Allup.DAL;
using Allup.Extentions;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Allup.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products
                .Include(p => p.ProductImages)
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .ToList();
            return View(products);
        }

        #region Maybe Used Later
        //public IActionResult ActiveList()
        //{
        //    List<Product> products = _context.Products
        //        .Include(p => p.ProductImages)
        //        .Include(p => p.Category)
        //        .Include(p => p.Brand)
        //        .Where(p => p.IsDeleted == false).ToList();

        //    return View(products);
        //}
        //public IActionResult DeleteList()
        //{
        //    List<Product> products = _context.Products
        //        .Include(p => p.ProductImages)
        //        .Include(p => p.Category)
        //        .Include(p => p.Brand)
        //        .Where(p => p.IsDeleted == true).ToList();

        //    return View(products);
        //}

        public IActionResult Undelete(int id)
        {
            Product deletedProduct = _context.Products.Find(id);
            if (deletedProduct == null) return NotFound();
            deletedProduct.DeletedAt = null;
            deletedProduct.IsDeleted = false;
            deletedProduct.CreatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();

            Product dbProduct = _context.Products.Include(p=>p.Category).FirstOrDefault(b => b.Id == id);

            if (dbProduct == null) return NotFound();

            ViewBag.Categories = new SelectList(_context.Categories.Where(c => c.Children.Count == 0 || c.ParentId != null).ToList(), "Id", "Name");
            ViewBag.Brands = new SelectList(_context.Brands.ToList(), "Id", "Name");
            ViewBag.Tags = new SelectList(_context.Tags.ToList(), "Id", "Name");
            return View(dbProduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Product product)
        {
            Product dbProduct = _context.Products.Include(p => p.ProductImages).FirstOrDefault(b => b.Id == product.Id);
            if (dbProduct == null) return NotFound();

            if (ModelState["Image"] != null)
            {
                if (!product.Image.IsImage())
                {
                    ModelState.AddModelError("Image", "Image Format Is Wrong");
                    return View();
                }
                if (product.Image.ImageSize(8000))
                {
                    ModelState.AddModelError("Image", "Image Is Oversize");
                    return View();
                }


                string patsh = Path.Combine(_env.WebRootPath, @"assets\images\product", dbProduct.ProductImages.Find(i => i.IsMain == true).ImageUrl).ToString();
                ImageService.DeleteImage(patsh);
                dbProduct.ProductImages.Find(i => i.IsMain == true).ImageUrl = "images/product/" + product.Image.SaveImage(_env, @"assets\images\product");
            }


            var existName = _context.Products.FirstOrDefault(x => x.Name.ToLower() == product.Name.ToLower());

            if (existName != null)
            {
                if (dbProduct.Name.ToLower() != existName.Name.ToLower())
                {
                    ModelState.AddModelError("Name", "Model Is Exsist");
                    return View("Update");
                }
            }

            dbProduct.Name = product.Name;
            dbProduct.CategoryId = product.CategoryId;
            dbProduct.Price = product.Price;
            dbProduct.StockCount = product.StockCount;
            dbProduct.BrandId = product.BrandId;
            dbProduct.TagProducts = product.TagProducts;
            dbProduct.UptadetAt = DateTime.Now;

            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            Product dbProduct = _context.Products.Find(id);

            if (dbProduct == null) return NotFound();

            dbProduct.IsDeleted = true;
            dbProduct.DeletedAt = DateTime.Now;
            dbProduct.CreatedAt = null;

            
            _context.SaveChanges();

            return RedirectToAction("index");

        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories.Where(c => c.Children.Count == 0 || c.ParentId != null && c.IsDeleted == false).ToList(), "Id", "Name");
            ViewBag.Brands = new SelectList(_context.Brands.Where(b => b.IsDeleted == false).ToList(), "Id", "Name");
            ViewBag.Tags = new SelectList(_context.Tags.ToList(), "Id", "Name");
            Product product = new Product();
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {

            if (!ModelState.IsValid) return View();

            Product newProduct = new Product
            {
                Name = product.Name,
                BrandId = product.BrandId,
                CategoryId = product.CategoryId,
                ProductImages = product.ProductImages,
                CreatedAt = DateTime.Now,
                Price = product.Price,
                StockCount = product.StockCount,

            };
            List<ProductImage> productImages = new List<ProductImage>();
            ProductImage newproductImage = new ProductImage
            {
                ImageUrl = "images/" + product.Image.SaveImage(_env, @"assets\images"),
                ProductId = newProduct.Id,
                IsMain = true
            };

            productImages.Add(newproductImage);
            newProduct.ProductImages = productImages;
            _context.Products.Add(newProduct);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
