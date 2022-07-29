using AllupProject.DAL;
using AllupProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupProject.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _context;

        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Subscribe([FromForm] Subscription subscription)
        {

            Subscription newSubs = new Subscription();

            newSubs.Email = subscription.Email;

            _context.Add(newSubs);
            _context.SaveChanges();

            return Ok();
        }

    }
}
