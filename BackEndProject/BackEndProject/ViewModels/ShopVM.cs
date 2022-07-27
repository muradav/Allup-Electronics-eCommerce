using BackEndProject.Helpers;
using BackEndProject.Models;
using System.Collections.Generic;

namespace BackEndProject.ViewModels
{
    public class ShopVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Brand> Brands { get; set; }
        public PagedList<Product> PagedLists { get; set; }
        public Product Product { get; set; }
        public List<DeliveryBan> Banners { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Comment> Comments { get; set; }
        public User User { get; set; }
    }
}
