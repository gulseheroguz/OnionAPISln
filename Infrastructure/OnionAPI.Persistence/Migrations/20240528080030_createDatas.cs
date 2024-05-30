using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class createDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 0, 30, 436, DateTimeKind.Local).AddTicks(5135), "Books" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 0, 30, 436, DateTimeKind.Local).AddTicks(5799), "Grocery & Industrial" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 0, 30, 436, DateTimeKind.Local).AddTicks(5820), "Music & Baby" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 11, 0, 30, 436, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 11, 0, 30, 436, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 11, 0, 30, 436, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 11, 0, 30, 436, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 0, 30, 439, DateTimeKind.Local).AddTicks(5311), "Değirmeni gazete nihil eve göze.", "Doğru." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 0, 30, 439, DateTimeKind.Local).AddTicks(5341), "Labore autem çarpan velit amet.", "Patlıcan." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 0, 30, 439, DateTimeKind.Local).AddTicks(5407), "Dolore masaya sevindi bundan vitae.", "Sıradanlıktan." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 28, 11, 0, 30, 442, DateTimeKind.Local).AddTicks(3292), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4.976317921850m, false, 829.50m, "Incredible Steel Shirt" },
                    { 2, 2, new DateTime(2024, 5, 28, 11, 0, 30, 442, DateTimeKind.Local).AddTicks(3318), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2.071263317834580m, false, 383.21m, "Refined Concrete Soap" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(308), "Grocery & Games" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(346), "Tools, Music & Clothing" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(357), "Books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 57, 37, 149, DateTimeKind.Local).AddTicks(7832), "Kalemi quasi numquam consectetur cezbelendi.", "Gitti." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 57, 37, 149, DateTimeKind.Local).AddTicks(7924), "Amet aliquam nostrum qui velit.", "Sarmal." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 57, 37, 149, DateTimeKind.Local).AddTicks(7966), "Sayfası gördüm vitae sarmal oldular.", "Ama." });
        }
    }
}
