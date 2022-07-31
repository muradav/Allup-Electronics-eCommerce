using Allup.DAL;
using Allup.Helpers;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1, int pageSize = 8)
        {

            ShopVM shopVM = new ShopVM();

            shopVM.Categories = _context.Categories.ToList();
            shopVM.Products = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).Include(p => p.Category).Include(p=>p.Comments).ToList();
            shopVM.PagedLists  =  PagedList<Product>.CreateAsync(shopVM.Products, page, pageSize);
            shopVM.Brands = _context.Brands.ToList();
            shopVM.Banners = _context.ShippingBanners.ToList();
            shopVM.Comments = _context.Comments.ToList();

            return View(shopVM);
        }
       
    }
}
