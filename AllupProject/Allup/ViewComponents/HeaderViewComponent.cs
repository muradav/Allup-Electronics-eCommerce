using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public HeaderViewComponent(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = _userManager.GetUserId(Request.HttpContext.User);

            List<Order> orders;

            if (userId == null)
            {
                orders = new List<Order>();
            }
            else
            {
                orders = _context.Orders.Where(o => o.UserId == userId).ToList(); ;
            }


            ViewBag.Cats = _context.Categories.ToList();
            ViewBag.OrderCount = orders.Count;
            Bio bio = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
