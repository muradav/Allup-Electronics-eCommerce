using Allup.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.DAL
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagProduct> TagProducts { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<ShippingBanner> ShippingBanners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Brands

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Nokia",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-1.jpg",
                });

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 2,
                    Name = "Apple",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-2.jpg",
                });

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 3,
                    Name = "HTC",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-3.jpg",
                });

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 4,
                    Name = "Xioami",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-4.jpg",
                });

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 5,
                    Name = "Hoffmann",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-5.jpg",
                });

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 6,
                    Name = "Delonghi",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-6.jpg",
                });

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 7,
                    Name = "Gorenji",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-1.jpg",
                });

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 8,
                    Name = "Toshiba",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-2.jpg",
                });

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 9,
                    Name = "HP",
                    CreatedAt = DateTime.Now,
                    ImageUrl = "images/brand/brand-4.jpg",
                });

            builder.Entity<Brand>().HasData(
               new Brand
               {
                   Id = 10,
                   Name = "Dell",
                   CreatedAt = DateTime.Now,
                   ImageUrl = "images/brand/brand-3.jpg",
               });

            #endregion

            #region Sliders

            builder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = 1,
                    Title = "2020 Virtual Reality",
                    DiscountSec = "Save $120 when you buy",
                    Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform",
                    ImageUrl = "images/slider-1.jpg",
                });

            builder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = 2,
                    Title = "4K HDR Smart TV 43",
                    DiscountSec = "Save $120 when you buy",
                    Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform",
                    ImageUrl = "images/slider-2.jpg",
                });

            #endregion

            #region Banners
            builder.Entity<Banner>().HasData(
               new Banner
               {
                   Id = 1,
                   ImageUrl = "images/banner-1.png",
               });

            builder.Entity<Banner>().HasData(
               new Banner
               {
                   Id = 2,
                   ImageUrl = "images/banner-2.png",
               });

            #endregion

            #region Categories

            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   ImageUrl = "images/category-2.jpg",
                   IsDeleted = false,
                   Name = "Computer",
                   CreatedAt = DateTime.Now,
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 2,
                   ImageUrl = "images/category-1.jpg",
                   ParentId = 1,
                   IsDeleted = false,
                   Name = "Laptop",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 3,
                   ImageUrl = "images/category-3.jpg",
                   IsDeleted = false,
                   Name = "Smartphone",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 4,
                   ImageUrl = "images/category-4.jpg",
                   IsDeleted = false,
                   Name = "Game Consoles",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 5,
                   ImageUrl = "images/category-5.jpg",
                   IsDeleted = false,
                   Name = "Bottoms",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 6,
                   ImageUrl = "images/category-6.jpg",
                   IsDeleted = false,
                   Name = "Tops & Sets",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 7,
                   ImageUrl = "images/category-7.jpg",
                   IsDeleted = false,
                   Name = "Audio & Video",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 8,
                   ImageUrl = "images/category-10.jpg",
                   ParentId = 7,
                   IsDeleted = false,
                   Name = "Camera",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 9,
                   ImageUrl = "images/category-9.jpg",
                   IsDeleted = false,
                   Name = "Household",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 10,
                   ImageUrl = "images/category-8.jpg",
                   IsDeleted = false,
                   Name = "Accessories",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 11,
                   ImageUrl = "images/category-11.jpg",
                   ParentId = 7,
                   IsDeleted = false,
                   Name = "Michrophone",
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 12,
                   ImageUrl = "images/category-12.jpg",
                   ParentId = 4,
                   IsDeleted = false,
                   Name = "Video Games",
                   CreatedAt = DateTime.Now
               });

            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 13,
                   ImageUrl = "images/category-1.jpg",
                   IsDeleted = false,
                   Name = "Technologics",
                   CreatedAt = DateTime.Now
               });


            #endregion

            #region Products


            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    NewArrival = true,
                    InStock = true,
                    BestSeller = false,
                    IsFeatured = false,
                    Name = "Joystic Logitech g66",
                    Price = 900,
                    StockCount = 33,
                    CategoryId = 4,
                    BrandId = 10,
                    DiscountPrice = 30,
                    TaxPercent = 0,
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    NewArrival = false,
                    BestSeller = true,
                    IsFeatured = false,
                    InStock = true,
                    Name = "Airpods Pro",
                    Price = 250,
                    StockCount = 30,
                    CategoryId = 10,
                    BrandId = 5,
                    DiscountPrice = 30,
                    TaxPercent = 0,
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3,
                    CreatedAt = DateTime.Now,
                    NewArrival = false,
                    BestSeller = false,
                    IsFeatured = true,
                    InStock = true,
                    Name = "HDD",
                    Price = 75,
                    StockCount = 25,
                    CategoryId = 10,
                    BrandId = 4,
                    DiscountPrice = 0,
                    TaxPercent = 0,
                });


            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 4,
                    CreatedAt = DateTime.Now,
                    NewArrival = true,
                    BestSeller = true,
                    IsFeatured = false,
                    InStock = true,
                    Name = "Printer",
                    Price = 300,
                    StockCount = 25,
                    CategoryId = 7,
                    BrandId = 2,
                    DiscountPrice = 0,
                    TaxPercent = 0,
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 5,
                    CreatedAt = DateTime.Now,
                    NewArrival = true,
                    BestSeller = false,
                    IsFeatured = true,
                    InStock = true,
                    Name = "Go Pro Max",
                    Price = 3000,
                    StockCount = 9,
                    CategoryId = 13,
                    BrandId = 2,
                    DiscountPrice = 0,
                    TaxPercent = 0,
                });

            builder.Entity<Product>().HasData(
               new Product
               {
                   Id = 6,
                   CreatedAt = DateTime.Now,
                   NewArrival = false,
                   BestSeller = true,
                   IsFeatured = true,
                   InStock = true,
                   Name = "Glasses",
                   Price = 99,
                   StockCount = 800,
                   CategoryId = 10,
                   BrandId = 1,
                   DiscountPrice = 0,
                   TaxPercent = 0,
               });
            builder.Entity<Product>().HasData(
               new Product
               {
                   Id = 7,
                   CreatedAt = DateTime.Now,
                   NewArrival = false,
                   BestSeller = false,
                   IsFeatured = true,
                   InStock = true,
                   Name = "Insta360",
                   Price = 199,
                   StockCount = 75,
                   CategoryId = 13,
                   BrandId = 3,
                   DiscountPrice = 0,
                   TaxPercent = 0,
               });
            builder.Entity<Product>().HasData(
               new Product
               {
                   Id = 8,
                   CreatedAt = DateTime.Now,
                   NewArrival = true,
                   BestSeller = false,
                   IsFeatured = true,
                   InStock = true,
                   Name = "MiPods",
                   Price = 900,
                   StockCount = 75,
                   CategoryId = 3,
                   BrandId = 6,
                   DiscountPrice = 0,
                   TaxPercent = 0,
               });
            builder.Entity<Product>().HasData(
               new Product
               {
                   Id = 9,
                   CreatedAt = DateTime.Now,
                   NewArrival = false,
                   BestSeller = true,
                   IsFeatured = false,
                   InStock = true,
                   Name = "Zenbook",
                   Price = 5000,
                   StockCount = 39,
                   CategoryId = 2,
                   BrandId = 7,
                   DiscountPrice = 0,
                   TaxPercent = 0,
               });


            #endregion

            #region ProductImages

            builder.Entity<ProductImage>().HasData(
               new ProductImage
               {
                   Id = 1,
                   ImageUrl = "images/product/product-3.jpg",
                   IsMain = true,
                   ProductId = 1,
               });

            builder.Entity<ProductImage>().HasData(
               new ProductImage
               {
                   Id = 2,
                   ImageUrl = "images/product/product-9.jpg",
                   IsMain = false,
                   ProductId = 1,
               });

            builder.Entity<ProductImage>().HasData(
               new ProductImage
               {
                   Id = 3,
                   ImageUrl = "images/product/product-1.jpg",
                   IsMain = true,
                   ProductId = 4,
               });

            builder.Entity<ProductImage>().HasData(
               new ProductImage
               {
                   Id = 4,
                   ImageUrl = "images/product/product-2.jpg",
                   IsMain = false,
                   ProductId = 4,
               });

            builder.Entity<ProductImage>().HasData(
               new ProductImage
               {
                   Id = 5,
                   ImageUrl = "images/product/product-5.jpg",
                   IsMain = true,
                   ProductId = 2,
               });

            builder.Entity<ProductImage>().HasData(
               new ProductImage
               {
                   Id = 6,
                   ImageUrl = "images/product/product-6.jpg",
                   IsMain = false,
                   ProductId = 2,
               });

            builder.Entity<ProductImage>().HasData(
               new ProductImage
               {
                   Id = 7,
                   ImageUrl = "images/product/product-14.jpg",
                   IsMain = true,
                   ProductId = 5,
               });
            builder.Entity<ProductImage>().HasData(
              new ProductImage
              {
                  Id = 8,
                  ImageUrl = "images/product/product-15.jpg",
                  IsMain = false,
                  ProductId = 5,
              });
            builder.Entity<ProductImage>().HasData(
              new ProductImage
              {
                  Id = 9,
                  ImageUrl = "images/product/product-8.jpg",
                  IsMain = true,
                  ProductId = 3,
              });
            builder.Entity<ProductImage>().HasData(
              new ProductImage
              {
                  Id = 10,
                  ImageUrl = "images/product/product-7.jpg",
                  IsMain = false,
                  ProductId = 3,
              });
            builder.Entity<ProductImage>().HasData(
              new ProductImage
              {
                  Id = 11,
                  ImageUrl = "images/product/product-13.jpg",
                  IsMain = true,
                  ProductId = 6,
              });
            builder.Entity<ProductImage>().HasData(
              new ProductImage
              {
                  Id = 12,
                  ImageUrl = "images/product/product-12.jpg",
                  IsMain = false,
                  ProductId = 6,
              });

            builder.Entity<ProductImage>().HasData(
             new ProductImage
             {
                 Id = 13,
                 ImageUrl = "images/product/product-10.jpg",
                 IsMain = true,
                 ProductId = 7,
             });
            builder.Entity<ProductImage>().HasData(
             new ProductImage
             {
                 Id = 14,
                 ImageUrl = "images/product/product-11.jpg",
                 IsMain = false,
                 ProductId = 7,
             });
            builder.Entity<ProductImage>().HasData(
             new ProductImage
             {
                 Id = 15,
                 ImageUrl = "images/category-3.jpg",
                 IsMain = true,
                 ProductId = 8,
             });
            builder.Entity<ProductImage>().HasData(
             new ProductImage
             {
                 Id = 16,
                 ImageUrl = "images/product/product-11.jpg",
                 IsMain = false,
                 ProductId = 8,
             });
            builder.Entity<ProductImage>().HasData(
            new ProductImage
            {
                Id = 17,
                ImageUrl = "images/category-1.jpg",
                IsMain = true,
                ProductId = 9,
            });

            builder.Entity<ProductImage>().HasData(
            new ProductImage
            {
                Id = 18,
                ImageUrl = "images/category-6.jpg",
                IsMain = false,
                ProductId = 9,
            });


            #endregion

            #region DeliveryBan
            builder.Entity<ShippingBanner>().HasData(
             new ShippingBanner
             {
                 Id = 1,
                 ImageUrl = "images/banner-icon/icon1.png",
                 Title = "Free Delivery",
                 Desc = "Every third product",
             });

            builder.Entity<ShippingBanner>().HasData(
              new ShippingBanner
              {
                  Id = 2,
                  ImageUrl = "images/banner-icon/icon2.png",
                  Title = "Delivery",
                  Desc = "24/7"
              });
            builder.Entity<ShippingBanner>().HasData(
              new ShippingBanner
              {
                  Id = 3,
                  ImageUrl = "images/banner-icon/icon3.png",
                  Title = "GoturApar Delivery",
                  Desc = "24hour delivery",
              });
            builder.Entity<ShippingBanner>().HasData(
              new ShippingBanner
              {
                  Id = 4,
                  ImageUrl = "images/banner-icon/icon4.png",
                  Title = "Gelme Getiririk Delivery",
                  Desc = "Stay at home delivery",
              });
            #endregion

            #region Blogs
            builder.Entity<Blog>().HasData(
               new Blog
               {
                   Id = 1,
                   ImageUrl = "images/blog-1.jpg",
                   Title = "This is first blog",
                   Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.",
                   Time = DateTime.Now,
               });
            builder.Entity<Blog>().HasData(
               new Blog
               {
                   Id = 2,
                   ImageUrl = "images/blog-2.jpg",
                   Title = "This is second blog",
                   Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.",
                   Time = DateTime.Now,
               });
            builder.Entity<Blog>().HasData(
               new Blog
               {
                   Id = 3,
                   ImageUrl = "images/blog-3.jpg",
                   Title = "This is third blog",
                   Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.",
                   Time = DateTime.Now,
               });
            builder.Entity<Blog>().HasData(
               new Blog
               {
                   Id = 4,
                   ImageUrl = "images/blog-4.jpg",
                   Title = "This is fourth blog",
                   Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.",
                   Time = DateTime.Now,
               });

            #endregion

            #region Testimonial
            builder.Entity<Testimonial>().HasData(
               new Testimonial
               {
                   Id = 1,
                   AuthorName = "Murad",
                   AuthorEmail = "murad@gmail.com",
                   Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                   ImageUrl = "images/author-1.png",
               });
            builder.Entity<Testimonial>().HasData(
               new Testimonial
               {
                   Id = 2,
                   AuthorName = "Azad",
                   AuthorEmail = "azad@gmail.ru",
                   Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                   ImageUrl = "images/author-2.jpg",
               });
            builder.Entity<Testimonial>().HasData(
               new Testimonial
               {
                   Id = 3,
                   AuthorName = "Anar",
                   AuthorEmail = "anar@gmail.ru",
                   Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                   ImageUrl = "images/author-3.jpg",
               });

            #endregion

            #region Bio
            builder.Entity<Bio>().HasData(
               new Bio
               {
                   Id = 1,
                   ImageUrl = "images/logo.png",
                   SupportContact = "+994553470880",
                   Location = "45 Grand Central Terminal New York,NY 1017 United State USA",
                   Contact = "+123 456 789",
                   Email = "email@yourwebsitename.com",
                   WorkTime = "Mon-Sat 9:00pm - 5:00pm Sun:Closed",
               });


            #endregion

        }
    }
}
