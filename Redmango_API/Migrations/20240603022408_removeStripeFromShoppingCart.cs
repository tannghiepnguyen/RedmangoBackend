using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Redmango_API.Migrations
{
    /// <inheritdoc />
    public partial class removeStripeFromShoppingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("1d402a09-80a2-4624-a25e-bebb2ff7da86"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("28ee8102-b213-410c-ae43-1d1e58d587a1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("51eaec96-8117-4211-9d79-18ee49fdd85b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("70960413-044f-40b0-9be1-98e5575afadd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("894971f3-0ca6-4c73-8657-fbcf115e92a4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("90368b9c-70e9-480b-b523-1775b03f5c55"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("940ae943-7d07-4df4-8fd7-837851154b9a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("9af60cb2-0f32-47ac-a800-fcfe35225923"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("ab390049-37a6-4247-85f7-1da494845382"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("ca0e2b94-060a-4a65-9467-7da58930caaf"));

            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "ShoppingCarts");

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { new Guid("0499f82e-f217-46e3-ae95-c4241dc35e35"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/idli.jpg", "Idli", 8.9900000000000002, "" },
                    { new Guid("07a11d18-5e3d-4fc1-9036-1dd898f6c51b"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/hakka noodles.jpg", "Hakka Noodles", 10.99, "" },
                    { new Guid("2c255899-8765-4672-a2d3-afc136c6fc8c"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/rasmalai.jpg", "Rasmalai", 4.9900000000000002, "Chef's Special" },
                    { new Guid("4e598189-8678-4925-bbaf-39222dd73245"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/malai kofta.jpg", "Malai Kofta", 12.99, "Top Rated" },
                    { new Guid("53f918f9-711c-4ca2-83db-efcafe914056"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/paneer pizza.jpg", "Paneer Pizza", 11.99, "" },
                    { new Guid("6d904b78-d203-4708-83a2-f3eefc273d77"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/pani puri.jpg", "Panu Puri", 8.9900000000000002, "Best Seller" },
                    { new Guid("bb4dd9ae-5f00-4582-87bc-65a6cae72449"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/sweet rolls.jpg", "Sweet Rolls", 3.9900000000000002, "Top Rated" },
                    { new Guid("d1859af3-53d8-438f-9cf5-0955810ed4ed"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/carrot love.jpg", "Carrot Love", 4.9900000000000002, "" },
                    { new Guid("db80b729-ad6d-4a9d-85ab-1e0f8ceeb91f"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/paneer tikka.jpg", "Paneer Tikka", 13.99, "Chef's Special" },
                    { new Guid("f8d6e835-7ec1-4852-befd-97a1470665df"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/spring roll.jpg", "Spring Roll", 7.9900000000000002, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("0499f82e-f217-46e3-ae95-c4241dc35e35"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("07a11d18-5e3d-4fc1-9036-1dd898f6c51b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("2c255899-8765-4672-a2d3-afc136c6fc8c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("4e598189-8678-4925-bbaf-39222dd73245"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("53f918f9-711c-4ca2-83db-efcafe914056"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("6d904b78-d203-4708-83a2-f3eefc273d77"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("bb4dd9ae-5f00-4582-87bc-65a6cae72449"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("d1859af3-53d8-438f-9cf5-0955810ed4ed"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("db80b729-ad6d-4a9d-85ab-1e0f8ceeb91f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("f8d6e835-7ec1-4852-befd-97a1470665df"));

            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "ShoppingCarts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "ShoppingCarts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { new Guid("1d402a09-80a2-4624-a25e-bebb2ff7da86"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/paneer pizza.jpg", "Paneer Pizza", 11.99, "" },
                    { new Guid("28ee8102-b213-410c-ae43-1d1e58d587a1"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/spring roll.jpg", "Spring Roll", 7.9900000000000002, "" },
                    { new Guid("51eaec96-8117-4211-9d79-18ee49fdd85b"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/paneer tikka.jpg", "Paneer Tikka", 13.99, "Chef's Special" },
                    { new Guid("70960413-044f-40b0-9be1-98e5575afadd"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/hakka noodles.jpg", "Hakka Noodles", 10.99, "" },
                    { new Guid("894971f3-0ca6-4c73-8657-fbcf115e92a4"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/malai kofta.jpg", "Malai Kofta", 12.99, "Top Rated" },
                    { new Guid("90368b9c-70e9-480b-b523-1775b03f5c55"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/rasmalai.jpg", "Rasmalai", 4.9900000000000002, "Chef's Special" },
                    { new Guid("940ae943-7d07-4df4-8fd7-837851154b9a"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/idli.jpg", "Idli", 8.9900000000000002, "" },
                    { new Guid("9af60cb2-0f32-47ac-a800-fcfe35225923"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/carrot love.jpg", "Carrot Love", 4.9900000000000002, "" },
                    { new Guid("ab390049-37a6-4247-85f7-1da494845382"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/sweet rolls.jpg", "Sweet Rolls", 3.9900000000000002, "Top Rated" },
                    { new Guid("ca0e2b94-060a-4a65-9467-7da58930caaf"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/pani puri.jpg", "Panu Puri", 8.9900000000000002, "Best Seller" }
                });
        }
    }
}
