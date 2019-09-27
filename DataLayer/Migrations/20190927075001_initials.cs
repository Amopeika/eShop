using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Fornavn = table.Column<string>(nullable: true),
                    Efternavn = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(nullable: false),
                    PhoneName = table.Column<string>(maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(30,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneID);
                    table.ForeignKey(
                        name: "FK_Phones_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 9, 27, 9, 50, 1, 542, DateTimeKind.Local).AddTicks(708)),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneID = table.Column<int>(nullable: false),
                    PhonePhoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoID);
                    table.ForeignKey(
                        name: "FK_Photos_Phones_PhoneID",
                        column: x => x.PhoneID,
                        principalTable: "Phones",
                        principalColumn: "PhoneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    PhoneID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => new { x.PhoneID, x.OrderID });
                    table.ForeignKey(
                        name: "FK_OrderLines_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLines_Phones_PhoneID",
                        column: x => x.PhoneID,
                        principalTable: "Phones",
                        principalColumn: "PhoneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "CompanyName" },
                values: new object[] { 1, "OnePlus" });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneID", "CompanyID", "PhoneName", "Price" },
                values: new object[,]
                {
                    { 1, 1, "One", 399.99m },
                    { 2, 1, "2", 499.99m },
                    { 3, 1, "X", 599.99m },
                    { 4, 1, "3", 699.99m },
                    { 5, 1, "3T", 799.99m },
                    { 6, 1, "5", 899.99m },
                    { 7, 1, "5T", 999.99m },
                    { 8, 1, "6", 1299.99m },
                    { 9, 1, "6T", 1399.99m },
                    { 10, 1, "7", 1899.99m },
                    { 11, 1, "7 Pro", 1999.99m }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoID", "PhoneID", "PhonePhoto" },
                values: new object[,]
                {
                    { 1, 1, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-one.jpg" },
                    { 2, 2, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-two.jpg" },
                    { 3, 3, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-x.jpg" },
                    { 4, 4, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-3-.jpg" },
                    { 5, 5, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-3t-.jpg" },
                    { 6, 6, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-5.jpg" },
                    { 7, 7, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-5t.jpg" },
                    { 8, 8, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-6-red.jpg" },
                    { 9, 9, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-6t-thunder-purple.jpg" },
                    { 10, 10, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-7--.jpg" },
                    { 11, 11, "https://fdn2.gsmarena.com/vv/bigpic/oneplus-7-pro-r1.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderID",
                table: "OrderLines",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CompanyID",
                table: "Phones",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PhoneID",
                table: "Photos",
                column: "PhoneID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
