﻿using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public OrderController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Order order = new Order();

            var basket = _context.Baskets.Include(b => b.BasketItems).ThenInclude(b=>b.Product).FirstOrDefault(b => b.UserId == userId);

            ViewBag.BasketItems = basket.BasketItems.ToList();

            return View(order);
        }

        [HttpPost]
        public IActionResult Sale(Order order, string radio = "Cash")
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(String.Empty, "Error has been occured");
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Order newOrder = new Order();

            var basket = _context.Baskets.Include(b => b.BasketItems).ThenInclude(b => b.Product).FirstOrDefault(b => b.UserId == userId);

            var basketItems = basket.BasketItems.ToList();


            newOrder.Address = order.Address;
            newOrder.City = order.City;
            newOrder.Country = order.Country;
            newOrder.CreatedAt = DateTime.Now;
            newOrder.Email = order.Email;
            newOrder.FirstName = order.FirstName;
            newOrder.Surname = order.Surname;
            newOrder.Phone = order.Phone;
            newOrder.UserId = userId;
            newOrder.OrderStatus = OrderStatus.Pending;
            newOrder.PaymantMethod = radio;


            _context.Orders.Add(newOrder);
            _context.SaveChanges();


            foreach (var item in basketItems)
            {
                OrderItem newOrderitem = new OrderItem();

                newOrderitem.ProductId = item.ProductId;
                newOrderitem.OrderId = newOrder.Id;
                newOrderitem.ProductCount = item.ProductCount;
                newOrderitem.ProductPrice = item.Product.Price;
                newOrderitem.Total += item.Product.Price * item.ProductCount;
                newOrder.TotalPrice += newOrderitem.Total;

                _context.OrderItems.Add(newOrderitem);
                _context.BasketItems.Remove(item);
            }
            

            _context.SaveChanges();
            return RedirectToAction("index","home");
        }

        public IActionResult Orders()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = _context.Orders.Where(o => o.UserId == userId).ToList();

            return View(orders);
        }

        public IActionResult OrderDetail(int id)
        {
            var order = _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(o => o.Product)
                .ThenInclude(o => o.ProductImages)
                .FirstOrDefault(o => o.Id == id);

            return View(order);
        }
    }
}
