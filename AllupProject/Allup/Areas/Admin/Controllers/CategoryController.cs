using Allup.DAL;
using Allup.Extentions;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Allup.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
		public IActionResult Index()
		{
			var categories = _context.Categories.ToList();

			return View(categories);
		}
		#region Maybe Used
		//public IActionResult ActiveList()
		//{
		//	List<Category> categories = _context.Categories
		//		.Where(p => p.IsDeleted == false).ToList();

		//	return View(categories);
		//}
		//public IActionResult DeleteList()
		//{
		//	List<Category> categories = _context.Categories
		//		.Where(p => p.IsDeleted == true).ToList();

		//	return View(categories);
		//}

		public IActionResult Undelete(int id)
		{
			Category deletedCategory = _context.Categories.Find(id);
			if (deletedCategory == null) return NotFound();
			deletedCategory.DeletedAt = null;
			deletedCategory.IsDeleted = false;
			deletedCategory.CreatedAt = DateTime.Now;
			_context.SaveChanges();
			return RedirectToAction("index");
		}
		#endregion

		public IActionResult Create()
		{
			var dbParents = _context.Categories.Where(x => x.ParentId == null).ToList();
			var dbChildren = _context.Categories.Where(x => x.ParentId != null).ToList();
			ViewBag.Parents = new SelectList(dbParents, "Id", "Name");
			ViewBag.Children = new SelectList(dbChildren, "Id", "Name");


			Category category = new Category();
			return View(category);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Category category)
		{
			if (!ModelState.IsValid) return View();

			Category newCategory = new Category
			{
				Name = category.Name,
				Children = category.Children,
				ParentId = category.ParentId,
				CreatedAt = DateTime.Now,
				ImageUrl = "images/" + category.Image.SaveImage(_env, @"assets\images"),
			};

			_context.Categories.Add(newCategory);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult Update(int? id)
		{
			if (id == null) return NotFound();

			Category dbCategory = _context.Categories.FirstOrDefault(b => b.Id == id);

			if (dbCategory == null) return NotFound();

			var dbParents = _context.Categories.Where(x => x.ParentId == null).ToList();
			var dbChildren = _context.Categories.Where(x => x.ParentId != null).ToList();
			ViewBag.Parents = new SelectList(dbParents, "Id", "Name");
			ViewBag.Children = new SelectList(dbChildren, "Id", "Name");

			return View(dbCategory);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Update(Category category)
		{
			Category dbCategory = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
			if (dbCategory == null) return NotFound();

			if (ModelState["Image"] != null)
			{
				if (!category.Image.IsImage())
				{
					ModelState.AddModelError("Image", "Wrong format");
					return View();
				}
				if (category.Image.ImageSize(8000))
				{
					ModelState.AddModelError("Image", "OVERsize");
					return View();
				}


				string path = Path.Combine(_env.WebRootPath, @"assets\images\", dbCategory.ImageUrl);
				ImageService.DeleteImage(path);
				dbCategory.ImageUrl = "images/" + category.Image.SaveImage(_env, @"assets\images\");
			}
			var catName = _context.Brands.FirstOrDefault(x => x.Name.ToLower() == category.Name.ToLower());

			if (catName != null)
			{
				if (dbCategory.Name.ToLower() != dbCategory.Name.ToLower())
				{
					ModelState.AddModelError("Name", "Model Name is exsist");
					return View("Update");
				}
			}
			dbCategory.Name = category.Name;
			dbCategory.UptadetAt = DateTime.Now;

			_context.SaveChanges();
			return RedirectToAction("index");
		}

	}
}
