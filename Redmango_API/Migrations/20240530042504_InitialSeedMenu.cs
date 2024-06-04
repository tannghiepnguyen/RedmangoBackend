using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Redmango_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "MenuItems",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { new Guid("0c0ae3ef-17cd-4b02-8c25-406012569bfe"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/idli.jpg", "Idli", 8.9900000000000002, "" },
                    { new Guid("24036e9d-d319-4358-ac1f-b17c0169a15f"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/hakka noodles.jpg", "Hakka Noodles", 10.99, "" },
                    { new Guid("2767688e-cac4-45f1-9013-19bc1e7da4c2"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/sweet rolls.jpg", "Sweet Rolls", 3.9900000000000002, "Top Rated" },
                    { new Guid("51281b43-b5e9-4656-adb9-37395d7961e3"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/malai kofta.jpg", "Malai Kofta", 12.99, "Top Rated" },
                    { new Guid("5516fbda-0f73-4bcf-bdc7-9321c9326026"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/paneer tikka.jpg", "Paneer Tikka", 13.99, "Chef's Special" },
                    { new Guid("904f5f19-a58b-4746-9878-81324bde6737"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/paneer pizza.jpg", "Paneer Pizza", 11.99, "" },
                    { new Guid("91786fc2-747b-4a73-9886-6a9041513945"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/carrot love.jpg", "Carrot Love", 4.9900000000000002, "" },
                    { new Guid("cdd34ed9-0da7-46fe-bb72-17d134e966aa"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/rasmalai.jpg", "Rasmalai", 4.9900000000000002, "Chef's Special" },
                    { new Guid("ed41207f-4e71-4da9-a94c-224857ff6c2b"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/pani puri.jpg", "Panu Puri", 8.9900000000000002, "Best Seller" },
                    { new Guid("f03ba0df-8dfd-45f8-914c-460ae1054c59"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/spring roll.jpg", "Spring Roll", 7.9900000000000002, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("0c0ae3ef-17cd-4b02-8c25-406012569bfe"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("24036e9d-d319-4358-ac1f-b17c0169a15f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("2767688e-cac4-45f1-9013-19bc1e7da4c2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("51281b43-b5e9-4656-adb9-37395d7961e3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("5516fbda-0f73-4bcf-bdc7-9321c9326026"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("904f5f19-a58b-4746-9878-81324bde6737"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("91786fc2-747b-4a73-9886-6a9041513945"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("cdd34ed9-0da7-46fe-bb72-17d134e966aa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("ed41207f-4e71-4da9-a94c-224857ff6c2b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("f03ba0df-8dfd-45f8-914c-460ae1054c59"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MenuItems",
                newName: "Guid");
        }
    }
}
