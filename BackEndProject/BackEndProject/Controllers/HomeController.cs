using BackEndProject.DAL;
using BackEndProject.Models;
using BackEndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BackEndProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<Product> products = _context.Products.Include(p => p.ProductImages).ToList();
            List<Category> categories = _context.Categories.ToList();

            Category computer = categories.FirstOrDefault(c => c.Id == 1);
            Category smartphone = categories.FirstOrDefault(c => c.Id == 3);
            Category gameConsole = categories.FirstOrDefault(c => c.Id == 4);

            List<Category> computers = categories.Where(c => c.ParentId == computer.Id).ToList();
            List<Category> smartphones = categories.Where(c => c.ParentId == smartphone.Id).ToList();
            List<Category> gameConsoles = categories.Where(c => c.ParentId == gameConsole.Id).ToList();

            HomeVM home = new HomeVM();


            if (computers.Count == 0)
            {
                home.Computers = products.Where(p => p.CategoryId == computer.Id).ToList();
            }
            else
            {
                foreach (var item in computers)
                {
                    home.Computers = products.Where(p => p.CategoryId == item.Id).ToList();
                }
            }


            if (smartphones.Count == 0)
            {
                home.Smartphones = products.Where(p => p.CategoryId == smartphone.Id).ToList();
            }
            else
            {
                foreach (var item in smartphones)
                {
                    home.Smartphones = products.Where(p => p.CategoryId == item.Id).ToList();
                }
            }


            if (smartphones.Count == 0)
            {
                home.GameConsoles = products.Where(p => p.CategoryId == gameConsole.Id).ToList();
            }
            else
            {
                foreach (var item in gameConsoles)
                {
                    home.GameConsoles = products.Where(p => p.CategoryId == item.Id).ToList();
                }
            }


            home.Sliders = _context.Sliders.ToList();
            home.Bans = _context.Bans.ToList();
            home.Categories = categories;
            home.Brands = _context.Brands.ToList();
            home.DeliveryBans = _context.DeliveryBans.ToList();
            home.Blogs = _context.Blogs.ToList();
            home.Testimonials = _context.Testimonials.ToList();
            home.Featured = products.Where(p => p.IsFeatured == true).ToList();
            home.NewArrivals = products.Where(p => p.NewArrival == true).ToList();
            home.BestSellers = products.Where(p => p.BestSeller == true).ToList();
            home.DiscountedProducts = products.Where(p => p.DiscountPrice >= 30).ToList();



            CategorySubChecker(categories);
            return View(home);
        }

        public void CategorySubChecker(List<Category> categories)
        {
            foreach (var item in categories)
            {
                if (item.ParentId != null)
                {
                    Category category = categories.Find(c => c.Id == item.ParentId);
                    category.Children = new List<Category>();
                    category.Children.Add(item);
                }
            }
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
