using AllupProject.Helpers;
using AllupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupProject.ViewModels
{
    public class ShopVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Brand> Brands { get; set; }
        public PagedList<Product> PagedLists { get; set; }
        public Product Product { get; set; }
        public List<ShippingBanner> Banners { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Comment> Comments { get; set; }
        public User User { get; set; }


    }
}
