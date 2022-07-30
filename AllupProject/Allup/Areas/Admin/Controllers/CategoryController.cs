using Allup.DAL;
using Allup.Extentions;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
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

		

	}
}
