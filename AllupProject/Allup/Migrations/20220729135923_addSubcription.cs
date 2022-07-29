using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class addSubcription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 381, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 381, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 381, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 381, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 372, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 376, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 376, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 376, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 377, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 377, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 377, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 377, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 377, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 377, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 378, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 379, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 379, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 379, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 379, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 379, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 379, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 379, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 379, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 382, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 382, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 382, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 382, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 382, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 383, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 383, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 383, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 383, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 59, 22, 383, DateTimeKind.Local).AddTicks(345));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 877, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 877, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 877, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 877, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 872, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 875, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 876, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 17, 30, 20, 878, DateTimeKind.Local).AddTicks(5917));
        }
    }
}
