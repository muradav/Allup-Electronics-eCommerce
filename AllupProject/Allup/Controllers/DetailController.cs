using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class DetailController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public DetailController(AppDbContext context,UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShopVM shopVM = new ShopVM();

            Product dbProcduct = _context.Products
                    .Include(p => p.ProductImages)
                    .Include(p => p.Brand)
                    .Include(p => p.Category)
                    .Include(p => p.Comments)
                    .ThenInclude(p=>p.User)
                    .Include(p => p.TagProducts)
                    .FirstOrDefault(p => p.Id == id);

            if (dbProcduct == null) return NotFound();

            shopVM.Product = dbProcduct;
            shopVM.Categories = _context.Categories.ToList();
            shopVM.Reviews = _context.Reviews.ToList();
            shopVM.Products = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).Include(p => p.Category).ToList();
            shopVM.Brands = _context.Brands.ToList();
            shopVM.Banners = _context.ShippingBanners.ToList();
            //shopVM.User = _context.Users


            return View(shopVM);

        }

        [HttpPost]
        public async Task<IActionResult> AddComment(int id, string content)
        {
            if (content == null) return View();

            User user;

            if (User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            else
            {
                return RedirectToAction("login", "account");
            }

            Comment comment = new Comment
            {
                Content = content,
                UserId = user.Id,
                ProductId = id,
                CreatedAt = DateTime.Now
            };

            await _context.AddAsync(comment);
            await _context.SaveChangesAsync();

            return RedirectToAction("index", new { id = id });
        }

    }
}

