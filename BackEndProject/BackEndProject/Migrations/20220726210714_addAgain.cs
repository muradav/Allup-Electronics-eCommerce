using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndProject.Migrations
{
    public partial class addAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bans", x => x.Id);
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
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryBans",
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
                    table.PrimaryKey("PK_DeliveryBans", x => x.Id);
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
                name: "User",
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
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false),
                    BestSeller = table.Column<bool>(nullable: false),
                    NewArrival = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: false),
                    TaxPercent = table.Column<double>(nullable: false),
                    StockCount = table.Column<int>(nullable: false),
                    PercentageDiscount = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_BasketItems_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Review",
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
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Products_ProductId",
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

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishList_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishList_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Bans",
                columns: new[] { "Id", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "images/banner-1.png" },
                    { 2, "images/banner-2.png" }
                });

            migrationBuilder.InsertData(
                table: "Bios",
                columns: new[] { "Id", "Contact", "Email", "ImageUrl", "Location", "SupportContact", "WorkTime" },
                values: new object[] { 1, "+123 456 789", "email@yourwebsitename.com", "images/logo.png", "45 Grand Central Terminal New York,NY 1017 United State USA", "+994553470880", "Mon-Sat 9:00pm - 5:00pm Sun:Closed" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "ImageUrl", "Time", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-1.jpg", new DateTime(2022, 7, 27, 1, 7, 13, 574, DateTimeKind.Local).AddTicks(3402), "This is first blog" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-2.jpg", new DateTime(2022, 7, 27, 1, 7, 13, 574, DateTimeKind.Local).AddTicks(4146), "This is second blog" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-3.jpg", new DateTime(2022, 7, 27, 1, 7, 13, 574, DateTimeKind.Local).AddTicks(4210), "This is third blog" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-4.jpg", new DateTime(2022, 7, 27, 1, 7, 13, 574, DateTimeKind.Local).AddTicks(4252), "This is fourth blog" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "UptadetAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8685), null, "images/brand/brand-3.jpg", false, "Dell", null },
                    { 9, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8530), null, "images/brand/brand-4.jpg", false, "HP", null },
                    { 8, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8494), null, "images/brand/brand-2.jpg", false, "Toshiba", null },
                    { 7, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8455), null, "images/brand/brand-1.jpg", false, "Gorenji", null },
                    { 6, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8416), null, "images/brand/brand-6.jpg", false, "Delonghi", null },
                    { 5, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8368), null, "images/brand/brand-5.jpg", false, "Hoffmann", null },
                    { 4, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8327), null, "images/brand/brand-4.jpg", false, "Xioami", null },
                    { 3, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8278), null, "images/brand/brand-3.jpg", false, "HTC", null },
                    { 2, new DateTime(2022, 7, 27, 1, 7, 13, 571, DateTimeKind.Local).AddTicks(8014), null, "images/brand/brand-2.jpg", false, "Apple", null },
                    { 1, new DateTime(2022, 7, 27, 1, 7, 13, 569, DateTimeKind.Local).AddTicks(309), null, "images/brand/brand-1.jpg", false, "Nokia", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 13, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8422), null, "images/category-1.jpg", false, "Technologics", null, null },
                    { 12, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8385), null, "images/category-12.jpg", false, "Video Games", 4, null },
                    { 11, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8348), null, "images/category-11.jpg", false, "Michrophone", 7, null },
                    { 10, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8311), null, "images/category-8.jpg", false, "Accessories", null, null },
                    { 9, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8269), null, "images/category-9.jpg", false, "Household", null, null },
                    { 8, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8223), null, "images/category-10.jpg", false, "Camera", 7, null },
                    { 3, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(7999), null, "images/category-3.jpg", false, "Smartphone", null, null },
                    { 6, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8128), null, "images/category-6.jpg", false, "Tops & Sets", null, null },
                    { 5, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8083), null, "images/category-5.jpg", false, "Bottoms", null, null },
                    { 4, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8045), null, "images/category-4.jpg", false, "Game Consoles", null, null },
                    { 2, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(7882), null, "images/category-1.jpg", false, "Laptop", 1, null },
                    { 1, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(6483), null, "images/category-2.jpg", false, "Computer", null, null },
                    { 7, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(8166), null, "images/category-7.jpg", false, "Audio & Video", null, null }
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
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "Desc", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "PercentageDiscount", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[,]
                {
                    { 9, true, 7, 2, new DateTime(2022, 7, 27, 1, 7, 13, 573, DateTimeKind.Local).AddTicks(5307), null, null, 0.0, true, false, false, "Zenbook", false, null, 5000.0, 39, 0.0, null },
                    { 8, false, 6, 3, new DateTime(2022, 7, 27, 1, 7, 13, 573, DateTimeKind.Local).AddTicks(5265), null, null, 0.0, true, false, true, "MiPods", true, null, 900.0, 75, 0.0, null },
                    { 1, false, 10, 4, new DateTime(2022, 7, 27, 1, 7, 13, 572, DateTimeKind.Local).AddTicks(9647), null, null, 30.0, true, false, false, "Joystic Logitech g66", true, null, 900.0, 33, 0.0, null },
                    { 4, true, 2, 7, new DateTime(2022, 7, 27, 1, 7, 13, 573, DateTimeKind.Local).AddTicks(5087), null, null, 0.0, true, false, false, "Printer", true, null, 300.0, 25, 0.0, null },
                    { 2, true, 5, 10, new DateTime(2022, 7, 27, 1, 7, 13, 573, DateTimeKind.Local).AddTicks(4793), null, null, 30.0, true, false, false, "Airpods Pro", false, null, 250.0, 30, 0.0, null },
                    { 3, false, 4, 10, new DateTime(2022, 7, 27, 1, 7, 13, 573, DateTimeKind.Local).AddTicks(5036), null, null, 0.0, true, false, true, "HDD", false, null, 75.0, 25, 0.0, null },
                    { 6, true, 1, 10, new DateTime(2022, 7, 27, 1, 7, 13, 573, DateTimeKind.Local).AddTicks(5179), null, null, 0.0, true, false, true, "Glasses", false, null, 99.0, 800, 0.0, null },
                    { 5, false, 2, 13, new DateTime(2022, 7, 27, 1, 7, 13, 573, DateTimeKind.Local).AddTicks(5131), null, null, 0.0, true, false, true, "Go Pro Max", true, null, 3000.0, 9, 0.0, null },
                    { 7, false, 3, 13, new DateTime(2022, 7, 27, 1, 7, 13, 573, DateTimeKind.Local).AddTicks(5221), null, null, 0.0, true, false, true, "Insta360", false, null, 199.0, 75, 0.0, null }
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
                name: "IX_BasketItems_UserId",
                table: "BasketItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
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
                name: "IX_Review_ProductId",
                table: "Review",
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

            migrationBuilder.CreateIndex(
                name: "IX_WishList_ProductId",
                table: "WishList",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_UserId",
                table: "WishList",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bans");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Bios");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "DeliveryBans");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "TagBlog");

            migrationBuilder.DropTable(
                name: "TagProducts");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
