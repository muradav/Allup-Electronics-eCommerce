using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig1res : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    SupportContact = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    WorkTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingBanners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingBanners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountSec = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(nullable: true),
                    AuthorEmail = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false),
                    BestSeller = table.Column<bool>(nullable: false),
                    NewArrival = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: false),
                    TaxPercent = table.Column<double>(nullable: false),
                    StockCount = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagBlog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagBlog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagBlog_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagBlog_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<double>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(nullable: true),
                    SenderEmail = table.Column<string>(nullable: true),
                    SendText = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Banners",
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
                    { 1, "Insana pul geldikce onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashlayir..", "images/blog-1.jpg", new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(9085), "Bu gun ne alim ?" },
                    { 2, "Insana pul geldi ve onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashladi...", "images/blog-2.jpg", new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(9950), "Dunen ne aldim ?" },
                    { 3, "Insana pul gelerse onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashlayacaq..", "images/blog-3.jpg", new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(9992), "Sabah ne alim ?" },
                    { 4, "ARtiq blog ve onun contenti....", "images/blog-4.jpg", new DateTime(2022, 7, 25, 23, 46, 13, 239, DateTimeKind.Local).AddTicks(12), "Bu umumiyyetle artiq blogdur evvelkilere baxin" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "UptadetAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8468), null, "images/brand/brand-3.jpg", false, "Logitech", null },
                    { 9, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8447), null, "images/brand/brand-4.jpg", false, "Pegasus", null },
                    { 8, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8428), null, "images/brand/brand-2.jpg", false, "Gucci", null },
                    { 7, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8409), null, "images/brand/brand-1.jpg", false, "Apple", null },
                    { 6, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8389), null, "images/brand/brand-6.jpg", false, "Xiaomi", null },
                    { 5, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8364), null, "images/brand/brand-5.jpg", false, "Sony", null },
                    { 4, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8343), null, "images/brand/brand-4.jpg", false, "Philips", null },
                    { 3, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8318), null, "images/brand/brand-3.jpg", false, "Asus", null },
                    { 2, new DateTime(2022, 7, 25, 23, 46, 13, 236, DateTimeKind.Local).AddTicks(8121), null, "images/brand/brand-2.jpg", false, "Samsung", null },
                    { 1, new DateTime(2022, 7, 25, 23, 46, 13, 234, DateTimeKind.Local).AddTicks(2426), null, "images/brand/brand-1.jpg", false, "Adidas", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 13, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(4072), null, "images/category-1.jpg", false, "Technologics", null, null },
                    { 12, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(4053), null, "images/category-12.jpg", false, "Video Games", 4, null },
                    { 11, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(4033), null, "images/category-11.jpg", false, "Michrophone", 7, null },
                    { 10, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(4013), null, "images/category-8.jpg", false, "Accessories", null, null },
                    { 9, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3992), null, "images/category-9.jpg", false, "Household", null, null },
                    { 8, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3906), null, "images/category-10.jpg", false, "Camera", 7, null },
                    { 3, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3795), null, "images/category-3.jpg", false, "Smartphone", null, null },
                    { 6, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3856), null, "images/category-6.jpg", false, "Tops & Sets", null, null },
                    { 5, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3835), null, "images/category-5.jpg", false, "Bottoms", null, null },
                    { 4, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3815), null, "images/category-4.jpg", false, "Game Consoles", null, null },
                    { 1, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3769), null, "images/category-2.jpg", false, "Computer", null, null },
                    { 2, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3553), null, "images/category-1.jpg", false, "Laptop", 1, null },
                    { 7, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(3876), null, "images/category-7.jpg", false, "Audio & Video", null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingBanners",
                columns: new[] { "Id", "Desc", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Gotur Apar", "images/banner-icon/icon1.png", "Pulsuz Dasinmaa" },
                    { 2, "Hefte ici her axsam", "images/banner-icon/icon2.png", "Ideal Dasinmaa" },
                    { 3, "Hefte sonu her seher", "images/banner-icon/icon3.png", "LIMAK KARGO LTD" },
                    { 4, "7/24 en bahali ve en keyfiyyetli dasinma biz beleyik ! ve bundan sonrada beledi belediki !", "images/banner-icon/icon4.png", "BALIYEV KARGOS" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Desc", "DiscountSec", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "Save $666 when you buy", "images/slider-1.jpg", "2079 Virtual Reality" },
                    { 2, "Etceken masindan istifade etmekle siz, qessabdan aldiginiz iri tikeleri rahatliqla qiyme halina cevirib dadli kotletler hazirlaya bilersiniz !", "Mohtesem Companiyyaa Shok shok !!!", "images/slider-2.jpg", "Et ceken masinnnnn" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "AuthorEmail", "AuthorName", "Content", "ImageUrl" },
                values: new object[,]
                {
                    { 2, "nakata@mail.ru", "Takashi", "Vurdun insanlari bir birine", "images/author-2.jpg" },
                    { 1, "farid@baliyev.com", "Farid", "Cagir ginen dost tanisivi otursun seniynen", "images/author-1.png" },
                    { 3, "hiri@mail.ru", "Hiroshi", "Bomba kimidi havalar", "images/author-3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[,]
                {
                    { 9, true, 7, 2, new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(908), null, 0.0, true, false, false, "Macbook Pro3", false, 5000.0, 39, 0.0, null },
                    { 8, false, 6, 3, new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(874), null, 0.0, true, false, true, "Xiaomi mi9t", true, 900.0, 75, 0.0, null },
                    { 1, false, 10, 4, new DateTime(2022, 7, 25, 23, 46, 13, 237, DateTimeKind.Local).AddTicks(4530), null, 30.0, true, false, false, "Joystic Logitech g66", true, 900.0, 33, 0.0, null },
                    { 4, true, 2, 7, new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(699), null, 0.0, true, false, false, "Printer (Samsung Yta-55)", true, 300.0, 25, 0.0, null },
                    { 2, true, 5, 10, new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(402), null, 30.0, true, false, false, "Qulaqliqs", false, 250.0, 30, 0.0, null },
                    { 3, false, 4, 10, new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(658), null, 0.0, true, false, true, "Flashcard", false, 75.0, 25, 0.0, null },
                    { 6, true, 1, 10, new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(792), null, 0.0, true, false, true, "Sunglasses", false, 99.0, 800, 0.0, null },
                    { 5, false, 2, 13, new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(737), null, 0.0, true, false, true, "Drone", true, 3000.0, 9, 0.0, null },
                    { 7, false, 3, 13, new DateTime(2022, 7, 25, 23, 46, 13, 238, DateTimeKind.Local).AddTicks(829), null, 0.0, true, false, true, "PhotoAparatte", false, 199.0, 75, 0.0, null }
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

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TagBlog_BlogId",
                table: "TagBlog",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_TagBlog_TagId",
                table: "TagBlog",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TagProducts_ProductId",
                table: "TagProducts",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Bios");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ShippingBanners");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "TagBlog");

            migrationBuilder.DropTable(
                name: "TagProducts");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
