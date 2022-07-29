using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Allup.Controllers
{
    public class DbBasketController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public DbBasketController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null) return RedirectToAction("login", "account");

            Basket basket = _context.Baskets
                .Include(b => b.BasketItems)
                .ThenInclude(b => b.Product)
                .ThenInclude(b => b.ProductImages)
                .FirstOrDefault(b => b.UserId == userId);

            if (basket == null)
            {
                return RedirectToAction("index", "shop");
            }

            return View(basket);
        }

        public IActionResult AddItem(int? id, string ReturnUrl)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null) return RedirectToAction("login", "account");

            if (id == null) return NoContent();

            Product product = _context.Products.FirstOrDefault(x => x.Id == id);

            Basket basket = _context.Baskets.FirstOrDefault(b => b.UserId == userId);

            List<BasketItem> basketItems = _context.BasketItems.Where(b => b.BasketId == basket.Id).ToList();

            if (product.StockCount == 0) return NotFound();

            BasketItem isexsist = basketItems.Find(p => p.ProductId == id);

            if (isexsist == null)
            {
                BasketItem item = new BasketItem();
                item.ProductId = product.Id;
                item.BasketId = basket.Id;
                item.ProductCount = 1;
                item.Total = product.Price * item.ProductCount;

                _context.Add(item);
            }
            else
            {
                isexsist.ProductCount++;
                isexsist.Total = isexsist.Product.Price * isexsist.ProductCount;
            }

            
            _context.SaveChanges();

            if (ReturnUrl != null) return Redirect(ReturnUrl);

            return RedirectToAction("index", "shop");

        }


        public IActionResult RemoveCart(int id, string ReturnUrl)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null) return RedirectToAction("login", "account");

            Basket basket = _context.Baskets.FirstOrDefault(b => b.UserId == userId);

            List<BasketItem> basketItems = _context.BasketItems.Where(b => b.BasketId == basket.Id).ToList();

            BasketItem deleteItem = basketItems.FirstOrDefault(p => p.ProductId == id);

            _context.BasketItems.Remove(deleteItem);

            _context.SaveChanges();

            if (ReturnUrl != null) return Redirect(ReturnUrl);

            return RedirectToAction("index", "shop");
        }

        public IActionResult Remove(int id, string ReturnUrl)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null) return RedirectToAction("login", "account");

            Basket basket = _context.Baskets.FirstOrDefault(b => b.UserId == userId);

            List<BasketItem> basketItems = _context.BasketItems.Where(b => b.BasketId == basket.Id).ToList();

            BasketItem deleteItem = basketItems.FirstOrDefault(p => p.ProductId == id);

            _context.BasketItems.Remove(deleteItem);

            _context.SaveChanges();

            if (ReturnUrl != null) return Redirect(ReturnUrl);

            return RedirectToAction("index", "dbbasket");
        }

        public IActionResult Plus(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null) return RedirectToAction("login", "account");

            Basket basket = _context.Baskets.FirstOrDefault(b => b.UserId == userId);

            List<BasketItem> basketItems = _context.BasketItems.Where(b => b.BasketId == basket.Id).ToList();

            BasketItem increaseItem = basketItems.FirstOrDefault(p => p.ProductId == id);

            Product product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (increaseItem.ProductCount < _context.Products.FirstOrDefault(p => p.Id == id).StockCount)
            {
                var item = _context.BasketItems.FirstOrDefault(b => b.Id == increaseItem.Id);
                item.ProductCount++;
                item.Total = item.ProductCount * product.Price;
                _context.SaveChanges();
            }

            return RedirectToAction("index", "dbbasket");
        }

        public IActionResult Minus(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null) return RedirectToAction("login", "account");

            Basket basket = _context.Baskets.FirstOrDefault(b => b.UserId == userId);

            List<BasketItem> basketItems = _context.BasketItems.Where(b => b.BasketId == basket.Id).ToList();

            BasketItem decreaseItem = basketItems.FirstOrDefault(p => p.ProductId == id);

            Product product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (decreaseItem.ProductCount > 1 )
            {
                var item = _context.BasketItems.FirstOrDefault(b => b.Id == decreaseItem.Id);
                item.ProductCount--;
                item.Total = item.ProductCount * product.Price;
                _context.SaveChanges();
            }
            else
            {
                _context.BasketItems.Remove(decreaseItem);
                _context.SaveChanges();
            }

            return RedirectToAction("index", "dbbasket");
        }

    }
}
