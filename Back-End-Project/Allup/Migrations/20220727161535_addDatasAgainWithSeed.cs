using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class addDatasAgainWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bios",
                columns: new[] { "Id", "Contact", "Email", "ImageUrl", "Location", "SupportContact", "WorkTime" },
                values: new object[] { 1, "+123 456 789", "email@yourwebsitename.com", "images/logo.png", "45 Grand Central Terminal New York,NY 1017 United State USA", "+994553470880", "Mon-Sat 9:00pm - 5:00pm Sun:Closed" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", new DateTime(2022, 7, 27, 20, 15, 34, 114, DateTimeKind.Local).AddTicks(8538), "This is first blog" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", new DateTime(2022, 7, 27, 20, 15, 34, 115, DateTimeKind.Local).AddTicks(297), "This is second blog" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", new DateTime(2022, 7, 27, 20, 15, 34, 115, DateTimeKind.Local).AddTicks(448), "This is third blog" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", new DateTime(2022, 7, 27, 20, 15, 34, 115, DateTimeKind.Local).AddTicks(539), "This is fourth blog" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 96, DateTimeKind.Local).AddTicks(3411), "Nokia" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(5203), "Apple" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(5692), "HTC" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(5798), "Xioami" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(5902), "Hoffmann" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(6044), "Delonghi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(6148), "Gorenji" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(6239), "Toshiba" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(6332), "HP" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 105, DateTimeKind.Local).AddTicks(6437), "Dell" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 109, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 20, 15, 34, 110, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 112, DateTimeKind.Local).AddTicks(3112), "Airpods Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 112, DateTimeKind.Local).AddTicks(3548), "HDD" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 112, DateTimeKind.Local).AddTicks(3675), "Printer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 112, DateTimeKind.Local).AddTicks(3793), "Go Pro Max" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 112, DateTimeKind.Local).AddTicks(3916), "Glasses" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 112, DateTimeKind.Local).AddTicks(4012), "Insta360" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 112, DateTimeKind.Local).AddTicks(4102), "MiPods" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 27, 20, 15, 34, 112, DateTimeKind.Local).AddTicks(4197), "Zenbook" });

            migrationBuilder.UpdateData(
                table: "ShippingBanners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "Every third product", "Free Delivery" });

            migrationBuilder.UpdateData(
                table: "ShippingBanners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "24/7", "Delivery" });

            migrationBuilder.UpdateData(
                table: "ShippingBanners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "24hour delivery", "GoturApar Delivery" });

            migrationBuilder.UpdateData(
                table: "ShippingBanners",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "Stay at home delivery", "Gelme Getiririk Delivery" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiscountSec", "Title" },
                values: new object[] { "Save $120 when you buy", "2020 Virtual Reality" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "DiscountSec", "Title" },
                values: new object[] { "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "Save $120 when you buy", "4K HDR Smart TV 43" });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorEmail", "AuthorName", "Content" },
                values: new object[] { "murad@gmail.com", "Murad", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorEmail", "AuthorName", "Content" },
                values: new object[] { "azad@gmail.ru", "Azad", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorEmail", "AuthorName", "Content" },
                values: new object[] { "anar@gmail.ru", "Anar", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Insana pul geldikce onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashlayir..", new DateTime(2022, 7, 26, 23, 0, 22, 60, DateTimeKind.Local).AddTicks(2279), "Bu gun ne alim ?" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Insana pul geldi ve onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashladi...", new DateTime(2022, 7, 26, 23, 0, 22, 60, DateTimeKind.Local).AddTicks(3162), "Dunen ne aldim ?" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Insana pul gelerse onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashlayacaq..", new DateTime(2022, 7, 26, 23, 0, 22, 60, DateTimeKind.Local).AddTicks(3217), "Sabah ne alim ?" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "ARtiq blog ve onun contenti....", new DateTime(2022, 7, 26, 23, 0, 22, 60, DateTimeKind.Local).AddTicks(3249), "Bu umumiyyetle artiq blogdur evvelkilere baxin" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 54, DateTimeKind.Local).AddTicks(2210), "Adidas" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4197), "Samsung" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4464), "Asus" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4498), "Philips" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4527), "Sony" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4568), "Xiaomi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4598), "Apple" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4627), "Gucci" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4656), "Pegasus" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 57, DateTimeKind.Local).AddTicks(4687), "Logitech" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 23, 0, 22, 58, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 59, DateTimeKind.Local).AddTicks(2780), "Qulaqliqs" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 59, DateTimeKind.Local).AddTicks(3055), "Flashcard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 59, DateTimeKind.Local).AddTicks(3096), "Printer (Samsung Yta-55)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 59, DateTimeKind.Local).AddTicks(3136), "Drone" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 59, DateTimeKind.Local).AddTicks(3185), "Sunglasses" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 59, DateTimeKind.Local).AddTicks(3221), "PhotoAparatte" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 59, DateTimeKind.Local).AddTicks(3256), "Xiaomi mi9t" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 0, 22, 59, DateTimeKind.Local).AddTicks(3367), "Macbook Pro3" });

            migrationBuilder.UpdateData(
                table: "ShippingBanners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "Gotur Apar", "Pulsuz Dasinmaa" });

            migrationBuilder.UpdateData(
                table: "ShippingBanners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "Hefte ici her axsam", "Ideal Dasinmaa" });

            migrationBuilder.UpdateData(
                table: "ShippingBanners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "Hefte sonu her seher", "LIMAK KARGO LTD" });

            migrationBuilder.UpdateData(
                table: "ShippingBanners",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "7/24 en bahali ve en keyfiyyetli dasinma biz beleyik ! ve bundan sonrada beledi belediki !", "BALIYEV KARGOS" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiscountSec", "Title" },
                values: new object[] { "Save $666 when you buy", "2079 Virtual Reality" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "DiscountSec", "Title" },
                values: new object[] { "Etceken masindan istifade etmekle siz, qessabdan aldiginiz iri tikeleri rahatliqla qiyme halina cevirib dadli kotletler hazirlaya bilersiniz !", "Mohtesem Companiyyaa Shok shok !!!", "Et ceken masinnnnn" });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorEmail", "AuthorName", "Content" },
                values: new object[] { "farid@baliyev.com", "Farid", "Cagir ginen dost tanisivi otursun seniynen" });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorEmail", "AuthorName", "Content" },
                values: new object[] { "nakata@mail.ru", "Takashi", "Vurdun insanlari bir birine" });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorEmail", "AuthorName", "Content" },
                values: new object[] { "hiri@mail.ru", "Hiroshi", "Bomba kimidi havalar" });
        }
    }
}
