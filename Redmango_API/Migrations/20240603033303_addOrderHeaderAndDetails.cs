using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Redmango_API.Migrations
{
    /// <inheritdoc />
    public partial class addOrderHeaderAndDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    OrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickupPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickupEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StripePaymentIntentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalItems = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.OrderHeaderId);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "OrderHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { new Guid("0b698991-31e0-411f-a0f4-19ac13afe1ae"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/hakka noodles.jpg", "Hakka Noodles", 10.99, "" },
                    { new Guid("0e1f8705-15bd-4276-975a-bd8d4d363001"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/malai kofta.jpg", "Malai Kofta", 12.99, "Top Rated" },
                    { new Guid("1742b85a-d53c-40db-b6a7-d6836bc3e76b"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/carrot love.jpg", "Carrot Love", 4.9900000000000002, "" },
                    { new Guid("1ac8dad9-186d-4268-8a8d-878f09ceaf8b"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/rasmalai.jpg", "Rasmalai", 4.9900000000000002, "Chef's Special" },
                    { new Guid("3adc1583-8db2-4c71-bc17-86efc18b8b9a"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/pani puri.jpg", "Panu Puri", 8.9900000000000002, "Best Seller" },
                    { new Guid("c2e79e45-26c9-4381-9b86-6ae07d9d8cfe"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/paneer pizza.jpg", "Paneer Pizza", 11.99, "" },
                    { new Guid("c581ff9e-0a3c-40e6-8e8e-52fb1896bb00"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/idli.jpg", "Idli", 8.9900000000000002, "" },
                    { new Guid("cd81db0e-cf74-4ca5-8619-e32097eb827d"), "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/spring roll.jpg", "Spring Roll", 7.9900000000000002, "" },
                    { new Guid("f031bd6d-f3be-4d69-88c4-c0de97e77625"), "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/paneer tikka.jpg", "Paneer Tikka", 13.99, "Chef's Special" },
                    { new Guid("fd471325-cfb8-4980-882a-5196a090a1eb"), "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://myredmango.blob.core.windows.net/redmango/sweet rolls.jpg", "Sweet Rolls", 3.9900000000000002, "Top Rated" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MenuItemId",
                table: "OrderDetails",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("0b698991-31e0-411f-a0f4-19ac13afe1ae"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("0e1f8705-15bd-4276-975a-bd8d4d363001"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("1742b85a-d53c-40db-b6a7-d6836bc3e76b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac8dad9-186d-4268-8a8d-878f09ceaf8b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("3adc1583-8db2-4c71-bc17-86efc18b8b9a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("c2e79e45-26c9-4381-9b86-6ae07d9d8cfe"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("c581ff9e-0a3c-40e6-8e8e-52fb1896bb00"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("cd81db0e-cf74-4ca5-8619-e32097eb827d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("f031bd6d-f3be-4d69-88c4-c0de97e77625"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: new Guid("fd471325-cfb8-4980-882a-5196a090a1eb"));

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
    }
}
