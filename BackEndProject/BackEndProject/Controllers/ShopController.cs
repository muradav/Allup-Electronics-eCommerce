using BackEndProject.DAL;
using BackEndProject.Helpers;
using BackEndProject.Models;
using BackEndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1, int pageSize = 6)
        {

            ShopVM shopVM = new ShopVM();

            shopVM.Categories = _context.Categories.ToList();
            shopVM.Products = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).Include(p => p.Category).ToList();
            shopVM.PagedLists = PagedList<Product>.CreateAsync(shopVM.Products, page, pageSize);
            shopVM.Brands = _context.Brands.ToList();
            shopVM.Banners = _context.DeliveryBans.ToList();

            return View(shopVM);
        }

       
    }

}
