using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektronik ürünler", "Elektronik", null },
                    { 2, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırtasiye işte...", "Kırtasiye", null },
                    { 3, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobilya ürünleri...", "Mobilya", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("17225ee5-4716-4fe8-9462-02f160d24afd"), 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hafif Business", null, "Lenovo X1 Carbon ", 980000m, 100, null },
                    { new Guid("1b79b23e-2df0-477d-b8c0-47e14ecc1388"), 2, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ".....", null, "A4 Defter ", 500m, 100, null },
                    { new Guid("53ad4035-c80c-4595-aae1-c9ce0505bb4b"), 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eski Business", null, "DELL XPS 15 ", 980000m, 100, null },
                    { new Guid("74db89f8-6462-4e9e-9bd4-910833e3f15a"), 2, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ".....", null, "Faber Castell", 500m, 100, null },
                    { new Guid("aeded193-f269-4dc8-a781-3c5712ae7af1"), 3, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ".....", null, "Sehpa", 500m, 100, null },
                    { new Guid("c15a9f7f-7406-4eb5-b46d-600032a5a68e"), 3, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ".....", null, "Koltuk", 500m, 100, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
