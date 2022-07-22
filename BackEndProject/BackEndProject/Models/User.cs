using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndProject.Models
{
    public class User:IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
