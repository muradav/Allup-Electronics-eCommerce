using AllupProject.DAL;
using AllupProject.Models;
using AllupProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupProject.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<BasketVM> products = GetBasket();

            if (products != null)
            {
                foreach (var item in products)
                {
                    Product dbProduct = _context.Products.Include(p=>p.ProductImages).FirstOrDefault(p => p.Id == item.Id);
                    item.Name = dbProduct.Name;
                    item.Price = dbProduct.Price;
                    item.ImgUrl = dbProduct.ProductImages.FirstOrDefault(i => i.IsMain == true).ImageUrl;
                    item.CategoryId = dbProduct.CategoryId;
                }
            }
            else
            {
                products = new List<BasketVM>();
            }
            return View(products);
        }

        public IActionResult AddItem(int? id, string ReturnUrl)
        {
            if (id == null) return NoContent();

            Product product = _context.Products.FirstOrDefault(x => x.Id == id);

            if (product == null) return NotFound();

            List<BasketVM> products = GetBasket();

            BasketVM isexsist = products.Find(p => p.Id == id);

            if (isexsist == null)
            {
                BasketVM basketVM = new BasketVM
                {
                    Id = product.Id,
                    Count = 1,
                    Price = product.Price,
                };
                products.Add(basketVM);
            }
            else
            {
                isexsist.Count++;
            }

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products));

            if (ReturnUrl != null) return Redirect(ReturnUrl);

            return RedirectToAction("index", "shop");
        }

        public IActionResult Remove(int? id, string ReturnUrl)
        {

            List<BasketVM> products = GetBasket();

            if (products == null) return NotFound();

            BasketVM deleteProduct = products.FirstOrDefault(p => p.Id == id);

            products.Remove(deleteProduct);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products));

            if (ReturnUrl != null) return Redirect(ReturnUrl);

            return RedirectToAction("index", "shop");
        }

        public IActionResult Plus(int id)
        {
            string basket = Request.Cookies["basket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM plusPro = products.Find(p => p.Id == id);
            if (plusPro.Count < _context.Products.FirstOrDefault(p => p.Id == id).StockCount)
            {
                plusPro.Count++;
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products));
            return RedirectToAction("index", "basket");
        }

        public IActionResult Minus(int id)
        {
            string basket = Request.Cookies["basket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM minusPro = products.Find(p => p.Id == id);
            if (minusPro.Count > 1)
            {
                minusPro.Count--;
            }
            else
            {
                products.Remove(minusPro);
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products));
            return RedirectToAction("index", "basket");
        }
        public List<BasketVM> GetBasket()
        {
            string basket = Request.Cookies["basket"];

            List<BasketVM> products = basket != null ? JsonConvert.DeserializeObject<List<BasketVM>>(basket)
                : new List<BasketVM>();

            return products;
        }

    }
}
