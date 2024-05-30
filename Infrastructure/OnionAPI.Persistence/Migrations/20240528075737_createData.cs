using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class createData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Categories_CategoryId1",
                table: "Details");

            migrationBuilder.DropIndex(
                name: "IX_Details_CategoryId1",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Details");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Details",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(308), false, "Grocery & Games" },
                    { 2, new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(346), false, "Tools, Music & Clothing" },
                    { 3, new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(357), false, "Books" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(4461), false, "Elektronik", 0, 1 },
                    { 2, new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(4464), false, "Moda", 0, 2 },
                    { 3, new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(4466), false, "Bilgisayar", 1, 1 },
                    { 4, new DateTime(2024, 5, 28, 10, 57, 37, 145, DateTimeKind.Local).AddTicks(4469), false, "Kadın", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 28, 10, 57, 37, 149, DateTimeKind.Local).AddTicks(7832), "Kalemi quasi numquam consectetur cezbelendi.", false, "Gitti." },
                    { 2, 1, new DateTime(2024, 5, 28, 10, 57, 37, 149, DateTimeKind.Local).AddTicks(7924), "Amet aliquam nostrum qui velit.", false, "Sarmal." },
                    { 3, 1, new DateTime(2024, 5, 28, 10, 57, 37, 149, DateTimeKind.Local).AddTicks(7966), "Sayfası gördüm vitae sarmal oldular.", false, "Ama." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Categories_CategoryId",
                table: "Details",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Categories_CategoryId",
                table: "Details");

            migrationBuilder.DropIndex(
                name: "IX_Details_CategoryId",
                table: "Details");

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
                table: "Details",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Details",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId1",
                table: "Details",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Categories_CategoryId1",
                table: "Details",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
