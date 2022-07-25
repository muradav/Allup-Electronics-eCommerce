using BackEndProject.Models;
using System.Collections.Generic;

namespace BackEndProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Ban> Bans { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Featured { get; set; }
        public List<Product> BestSellers { get; set; }
        public List<Product> NewArrivals { get; set; }
        public List<Product> DiscountedProducts { get; set; }
        public List<Product> Computers { get; set; }
        public List<Product> Smartphones { get; set; }
        public List<Product> GameConsoles { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<DeliveryBan> DeliveryBans { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}
