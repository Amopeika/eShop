using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1);
        }
    }
}
