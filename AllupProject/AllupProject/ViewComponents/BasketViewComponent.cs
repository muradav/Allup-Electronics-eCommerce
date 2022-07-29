using AllupProject.DAL;
using AllupProject.Models;
using AllupProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupProject.ViewComponents
{
    public class BasketViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public BasketViewComponent(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {

            var userId = _userManager.GetUserId(Request.HttpContext.User);

            double totalPrice = 0;
            int totalCount = 0;

            Basket basket;

            if (userId == null)
            {
                basket = new Basket();
            }
            else
            {
                basket = _context.Baskets
                .Include(b => b.BasketItems)
                .ThenInclude(b => b.Product)
                .ThenInclude(b => b.ProductImages)
                .FirstOrDefault(b => b.UserId == userId);

                if (basket == null)
                {
                    basket = new Basket() { UserId = userId };
                    basket.BasketItems = new List<BasketItem>();
                    _context.Add(basket);
                    _context.SaveChanges();
                }

                foreach (var item in basket.BasketItems)
                {
                    totalPrice += item.ProductCount * item.Product.Price;
                    totalCount += item.ProductCount;
                }
            }

            ViewBag.TotalPrice = totalPrice;
            ViewBag.TotalCount = totalCount;

            return View(await Task.FromResult(basket));
        }
    }
}
