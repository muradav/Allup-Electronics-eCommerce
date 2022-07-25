using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndProject.Migrations
{
    public partial class addDatasWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bans",
                columns: new[] { "Id", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "images/banner-1.png" },
                    { 2, "images/banner-2.png" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "ImageUrl", "Time", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-1.jpg", new DateTime(2022, 7, 24, 22, 37, 13, 688, DateTimeKind.Local).AddTicks(6052), "This is first blog" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-2.jpg", new DateTime(2022, 7, 24, 22, 37, 13, 688, DateTimeKind.Local).AddTicks(6904), "This is second blog" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-3.jpg", new DateTime(2022, 7, 24, 22, 37, 13, 688, DateTimeKind.Local).AddTicks(6980), "This is third blog" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-4.jpg", new DateTime(2022, 7, 24, 22, 37, 13, 688, DateTimeKind.Local).AddTicks(7028), "This is fourth blog" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "UptadetAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(7369), null, "images/brand/brand-3.jpg", false, "Dell", null },
                    { 9, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(7316), null, "images/brand/brand-4.jpg", false, "HP", null },
                    { 8, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(7268), null, "images/brand/brand-2.jpg", false, "Toshiba", null },
                    { 7, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(7218), null, "images/brand/brand-1.jpg", false, "Gorenji", null },
                    { 6, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(7169), null, "images/brand/brand-6.jpg", false, "Delonghi", null },
                    { 5, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(7105), null, "images/brand/brand-5.jpg", false, "Hoffmann", null },
                    { 4, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(7050), null, "images/brand/brand-4.jpg", false, "Xioami", null },
                    { 3, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(6969), null, "images/brand/brand-3.jpg", false, "HTC", null },
                    { 2, new DateTime(2022, 7, 24, 22, 37, 13, 685, DateTimeKind.Local).AddTicks(6716), null, "images/brand/brand-2.jpg", false, "Apple", null },
                    { 1, new DateTime(2022, 7, 24, 22, 37, 13, 682, DateTimeKind.Local).AddTicks(2632), null, "images/brand/brand-1.jpg", false, "Nokia", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 13, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8893), null, "images/category-1.jpg", false, "Technologics", null, null },
                    { 12, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8844), null, "images/category-12.jpg", false, "Video Games", 4, null },
                    { 11, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8793), null, "images/category-11.jpg", false, "Michrophone", 7, null },
                    { 10, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8727), null, "images/category-8.jpg", false, "Accessories", null, null },
                    { 9, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8674), null, "images/category-9.jpg", false, "Household", null, null },
                    { 8, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8618), null, "images/category-10.jpg", false, "Camera", 7, null },
                    { 3, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8337), null, "images/category-3.jpg", false, "Smartphone", null, null },
                    { 6, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8501), null, "images/category-6.jpg", false, "Tops & Sets", null, null },
                    { 5, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8443), null, "images/category-5.jpg", false, "Bottoms", null, null },
                    { 4, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8393), null, "images/category-4.jpg", false, "Game Consoles", null, null },
                    { 2, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8196), null, "images/category-1.jpg", false, "Laptop", 1, null },
                    { 1, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(6402), null, "images/category-2.jpg", false, "Computer", null, null },
                    { 7, new DateTime(2022, 7, 24, 22, 37, 13, 686, DateTimeKind.Local).AddTicks(8549), null, "images/category-7.jpg", false, "Audio & Video", null, null }
                });

            migrationBuilder.InsertData(
                table: "DeliveryBans",
                columns: new[] { "Id", "Desc", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Every third product", "images/banner-icon/icon1.png", "Free Delivery" },
                    { 2, "24/7", "images/banner-icon/icon2.png", "Delivery" },
                    { 3, "24hour delivery", "images/banner-icon/icon3.png", "GoturApar Delivery" },
                    { 4, "Stay at home delivery", "images/banner-icon/icon4.png", "Gelme Getiririk Delivery" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Desc", "DiscountSec", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "Save $120 when you buy", "images/slider-1.jpg", "2020 Virtual Reality" },
                    { 2, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "Save $120 when you buy", "images/slider-2.jpg", "4K HDR Smart TV 43" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "AuthorEmail", "AuthorName", "Content", "ImageUrl" },
                values: new object[,]
                {
                    { 2, "azad@gmail.ru", "Azad", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "images/author-2.jpg" },
                    { 1, "murad@gmail.com", "Murad", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "images/author-1.png" },
                    { 3, "anar@gmail.ru", "Anar", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "images/author-3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[,]
                {
                    { 9, true, 7, 2, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(6794), null, 0.0, true, false, false, "Zenbook", false, 5000.0, 39, 0.0, null },
                    { 8, false, 6, 3, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(6737), null, 0.0, true, false, true, "MiPods", true, 900.0, 75, 0.0, null },
                    { 1, false, 10, 4, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(133), null, 30.0, true, false, false, "Joystic Logitech g66", true, 900.0, 33, 0.0, null },
                    { 4, true, 2, 7, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(6496), null, 0.0, true, false, false, "Printer", true, 300.0, 25, 0.0, null },
                    { 2, true, 5, 10, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(6229), null, 30.0, true, false, false, "Airpods Pro", false, 250.0, 30, 0.0, null },
                    { 3, false, 4, 10, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(6431), null, 0.0, true, false, true, "HDD", false, 75.0, 25, 0.0, null },
                    { 6, true, 1, 10, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(6621), null, 0.0, true, false, true, "Glasses", false, 99.0, 800, 0.0, null },
                    { 5, false, 2, 13, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(6556), null, 0.0, true, false, true, "Go Pro Max", true, 3000.0, 9, 0.0, null },
                    { 7, false, 3, 13, new DateTime(2022, 7, 24, 22, 37, 13, 687, DateTimeKind.Local).AddTicks(6680), null, 0.0, true, false, true, "Insta360", false, 199.0, 75, 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[,]
                {
                    { 17, "images/category-1.jpg", true, 9 },
                    { 8, "images/product/product-15.jpg", false, 5 },
                    { 7, "images/product/product-14.jpg", true, 5 },
                    { 12, "images/product/product-12.jpg", false, 6 },
                    { 11, "images/product/product-13.jpg", true, 6 },
                    { 10, "images/product/product-7.jpg", false, 3 },
                    { 9, "images/product/product-8.jpg", true, 3 },
                    { 6, "images/product/product-6.jpg", false, 2 },
                    { 5, "images/product/product-5.jpg", true, 2 },
                    { 4, "images/product/product-2.jpg", false, 4 },
                    { 3, "images/product/product-1.jpg", true, 4 },
                    { 2, "images/product/product-9.jpg", false, 1 },
                    { 1, "images/product/product-3.jpg", true, 1 },
                    { 16, "images/product/product-11.jpg", false, 8 },
                    { 15, "images/category-3.jpg", true, 8 },
                    { 18, "images/category-6.jpg", false, 9 },
                    { 13, "images/product/product-10.jpg", true, 7 },
                    { 14, "images/product/product-11.jpg", false, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DeliveryBans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryBans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeliveryBans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeliveryBans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
