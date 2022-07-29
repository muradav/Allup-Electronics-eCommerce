using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class again : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PaymantMethod = table.Column<string>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    OrderStatus = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<double>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ProductCount = table.Column<int>(nullable: false),
                    BasketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                    ProductPrice = table.Column<double>(nullable: false),
                    ProductCount = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                table: "Bios",
                columns: new[] { "Id", "Contact", "Email", "ImageUrl", "Location", "SupportContact", "WorkTime" },
                values: new object[] { 1, "+123 456 789", "email@yourwebsitename.com", "images/logo.png", "45 Grand Central Terminal New York,NY 1017 United State USA", "+994553470880", "Mon-Sat 9:00pm - 5:00pm Sun:Closed" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "ImageUrl", "Time", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-1.jpg", new DateTime(2022, 7, 30, 1, 15, 43, 764, DateTimeKind.Local).AddTicks(5316), "This is first blog" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-2.jpg", new DateTime(2022, 7, 30, 1, 15, 43, 764, DateTimeKind.Local).AddTicks(6707), "This is second blog" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-3.jpg", new DateTime(2022, 7, 30, 1, 15, 43, 764, DateTimeKind.Local).AddTicks(6842), "This is third blog" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eget dui rhoncus, malesuada lectus vel, rhoncus felis. Suspendisse nec tempor nunc, non maximus lacus.", "images/blog-4.jpg", new DateTime(2022, 7, 30, 1, 15, 43, 764, DateTimeKind.Local).AddTicks(6931), "This is fourth blog" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "UptadetAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(2955), null, "images/brand/brand-3.jpg", false, "Dell", null },
                    { 9, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(2844), null, "images/brand/brand-4.jpg", false, "HP", null },
                    { 8, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(2747), null, "images/brand/brand-2.jpg", false, "Toshiba", null },
                    { 7, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(2651), null, "images/brand/brand-1.jpg", false, "Gorenji", null },
                    { 6, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(2555), null, "images/brand/brand-6.jpg", false, "Delonghi", null },
                    { 4, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(2352), null, "images/brand/brand-4.jpg", false, "Xioami", null },
                    { 3, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(2238), null, "images/brand/brand-3.jpg", false, "HTC", null },
                    { 2, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(1741), null, "images/brand/brand-2.jpg", false, "Apple", null },
                    { 1, new DateTime(2022, 7, 30, 1, 15, 43, 755, DateTimeKind.Local).AddTicks(4808), null, "images/brand/brand-1.jpg", false, "Nokia", null },
                    { 5, new DateTime(2022, 7, 30, 1, 15, 43, 760, DateTimeKind.Local).AddTicks(2446), null, "images/brand/brand-5.jpg", false, "Hoffmann", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(8301), null, "images/category-9.jpg", false, "Household", null, null },
                    { 13, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(8739), null, "images/category-1.jpg", false, "Technologics", null, null },
                    { 10, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(8427), null, "images/category-8.jpg", false, "Accessories", null, null },
                    { 6, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(7931), null, "images/category-6.jpg", false, "Tops & Sets", null, null },
                    { 7, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(8034), null, "images/category-7.jpg", false, "Audio & Video", null, null },
                    { 4, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(7690), null, "images/category-4.jpg", false, "Game Consoles", null, null },
                    { 3, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(7476), null, "images/category-3.jpg", false, "Smartphone", null, null },
                    { 1, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(5798), null, "images/category-2.jpg", false, "Computer", null, null },
                    { 5, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(7816), null, "images/category-5.jpg", false, "Bottoms", null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingBanners",
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
                    { 2, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "Save $120 when you buy", "images/slider-2.jpg", "4K HDR Smart TV 43" },
                    { 1, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "Save $120 when you buy", "images/slider-1.jpg", "2020 Virtual Reality" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UptadetAt" },
                values: new object[,]
                {
                    { 8, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(1878), null, "used", null },
                    { 7, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(1764), null, "new", null },
                    { 6, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(1682), null, "windowsphone", null },
                    { 5, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(1590), null, "ios", null },
                    { 2, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(1278), null, "iphone", null },
                    { 3, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(1417), null, "samsung", null },
                    { 1, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(9), null, "phone", null },
                    { 9, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(1975), null, "microsoft", null },
                    { 4, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(1505), null, "android", null },
                    { 10, new DateTime(2022, 7, 30, 1, 15, 43, 766, DateTimeKind.Local).AddTicks(2062), null, "linux", null }
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
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(7286), null, "images/category-1.jpg", false, "Laptop", 1, null },
                    { 12, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(8636), null, "images/category-12.jpg", false, "Video Games", 4, null },
                    { 8, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(8179), null, "images/category-10.jpg", false, "Camera", 7, null },
                    { 11, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(8534), null, "images/category-11.jpg", false, "Michrophone", 7, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[,]
                {
                    { 8, false, 6, 3, new DateTime(2022, 7, 30, 1, 15, 43, 762, DateTimeKind.Local).AddTicks(9908), null, 0.0, true, false, true, "MiPods", true, 79.0, 17, 0.0, null },
                    { 1, false, 10, 4, new DateTime(2022, 7, 30, 1, 15, 43, 761, DateTimeKind.Local).AddTicks(9865), null, 30.0, true, false, false, "Joystic Logitech g66", true, 90.0, 23, 0.0, null },
                    { 4, true, 2, 7, new DateTime(2022, 7, 30, 1, 15, 43, 762, DateTimeKind.Local).AddTicks(9467), null, 0.0, true, false, false, "Printer", true, 35.0, 21, 0.0, null },
                    { 2, true, 5, 10, new DateTime(2022, 7, 30, 1, 15, 43, 762, DateTimeKind.Local).AddTicks(8914), null, 30.0, true, false, false, "Airpods Pro", false, 20.0, 13, 0.0, null },
                    { 3, false, 4, 10, new DateTime(2022, 7, 30, 1, 15, 43, 762, DateTimeKind.Local).AddTicks(9348), null, 0.0, true, false, true, "HDD", false, 45.0, 15, 0.0, null },
                    { 6, true, 1, 10, new DateTime(2022, 7, 30, 1, 15, 43, 762, DateTimeKind.Local).AddTicks(9689), null, 0.0, true, false, true, "Glasses", false, 59.0, 8, 0.0, null },
                    { 5, false, 2, 13, new DateTime(2022, 7, 30, 1, 15, 43, 762, DateTimeKind.Local).AddTicks(9571), null, 0.0, true, false, true, "Go Pro Max", true, 410.0, 19, 0.0, null },
                    { 7, false, 3, 13, new DateTime(2022, 7, 30, 1, 15, 43, 762, DateTimeKind.Local).AddTicks(9798), null, 0.0, true, false, true, "Insta360", false, 79.0, 7, 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[,]
                {
                    { 6, "images/product/product-6.jpg", false, 2 },
                    { 8, "images/product/product-15.jpg", false, 5 },
                    { 7, "images/product/product-14.jpg", true, 5 },
                    { 12, "images/product/product-12.jpg", false, 6 },
                    { 11, "images/product/product-13.jpg", true, 6 },
                    { 10, "images/product/product-7.jpg", false, 3 },
                    { 9, "images/product/product-8.jpg", true, 3 },
                    { 13, "images/product/product-10.jpg", true, 7 },
                    { 14, "images/product/product-11.jpg", false, 7 },
                    { 4, "images/product/product-2.jpg", false, 4 },
                    { 3, "images/product/product-1.jpg", true, 4 },
                    { 2, "images/product/product-9.jpg", false, 1 },
                    { 1, "images/product/product-3.jpg", true, 1 },
                    { 16, "images/product/product-11.jpg", false, 8 },
                    { 15, "images/category-3.jpg", true, 8 },
                    { 5, "images/product/product-5.jpg", true, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[] { 9, true, 7, 2, new DateTime(2022, 7, 30, 1, 15, 43, 763, DateTimeKind.Local).AddTicks(32), null, 0.0, true, false, false, "Zenbook", false, 340.0, 9, 0.0, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[] { 17, "images/category-1.jpg", true, 9 });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[] { 18, "images/category-6.jpg", false, 9 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ProductId",
                table: "WishLists",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_UserId",
                table: "WishLists",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Bios");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ShippingBanners");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "TagBlog");

            migrationBuilder.DropTable(
                name: "TagProducts");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
