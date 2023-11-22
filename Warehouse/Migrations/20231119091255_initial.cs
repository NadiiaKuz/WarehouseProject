using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Warehouse.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PricePerItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Portable computers", "Laptops" },
                    { 2, "Desktop computers", "Desktops" },
                    { 3, "Handheld computers", "Tablets" },
                    { 4, "Display screens", "Monitors" },
                    { 5, "Document printers", "Printers" },
                    { 6, "Storage devices", "Storage" },
                    { 7, "Networking equipment", "Networking" },
                    { 8, "Computer accessories", "Accessories" },
                    { 9, "Computer software", "Software" },
                    { 10, "Computer games", "Games" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "ContactInfo", "Name" },
                values: new object[,]
                {
                    { 1, "Address 1", "contact1@example.com", "Customer 1" },
                    { 2, "Address 2", "contact2@example.com", "Customer 2" },
                    { 3, "Address 3", "contact3@example.com", "Customer 3" },
                    { 4, "Address 4", "contact4@example.com", "Customer 4" },
                    { 5, "Address 5", "contact5@example.com", "Customer 5" },
                    { 6, "Address 6", "contact6@example.com", "Customer 6" },
                    { 7, "Address 7", "contact7@example.com", "Customer 7" },
                    { 8, "Address 8", "contact8@example.com", "Customer 8" },
                    { 9, "Address 9", "contact9@example.com", "Customer 9" },
                    { 10, "Address 10", "contact10@example.com", "Customer 10" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CustomerID", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 2, 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, 2, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 3, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, 4, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, 4, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, 5, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, 6, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, 7, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, 8, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "Description", "Name", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { 1, 1, "Description 1", "Laptop 1", 1000.00m, 10 },
                    { 2, 1, "Description 2", "Laptop 2", 1500.00m, 5 },
                    { 3, 2, "Description 3", "Desktop 1", 1200.00m, 7 },
                    { 4, 2, "Description 4", "Desktop 2", 2000.00m, 6 },
                    { 5, 3, "Description 5", "Tablet 1", 500.00m, 15 },
                    { 6, 3, "Description 6", "Tablet 2", 750.00m, 8 },
                    { 7, 4, "Description 7", "Monitor 1", 300.00m, 12 },
                    { 8, 5, "Description 8", "Printer 1", 200.00m, 10 },
                    { 9, 6, "Description 9", "External Hard Drive", 100.00m, 20 },
                    { 10, 7, "Description 10", "Wireless Router", 150.00m, 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailID", "OrderID", "PricePerItem", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1000.00m, 1, 1 },
                    { 2, 1, 1500.00m, 2, 2 },
                    { 3, 2, 1200.00m, 3, 1 },
                    { 4, 3, 2000.00m, 4, 1 },
                    { 5, 3, 500.00m, 5, 3 },
                    { 6, 4, 750.00m, 6, 2 },
                    { 7, 5, 300.00m, 7, 1 },
                    { 8, 5, 200.00m, 8, 2 },
                    { 9, 6, 100.00m, 9, 1 },
                    { 10, 7, 150.00m, 10, 1 },
                    { 11, 7, 1000.00m, 1, 1 },
                    { 12, 8, 1500.00m, 2, 1 },
                    { 13, 8, 1200.00m, 3, 2 },
                    { 14, 9, 2000.00m, 4, 1 },
                    { 15, 9, 500.00m, 5, 2 },
                    { 16, 10, 750.00m, 6, 1 },
                    { 17, 10, 300.00m, 7, 2 },
                    { 18, 3, 750.00m, 6, 2 },
                    { 19, 3, 300.00m, 7, 1 },
                    { 20, 7, 1500.00m, 2, 1 },
                    { 21, 7, 1200.00m, 3, 1 },
                    { 22, 8, 2000.00m, 4, 1 },
                    { 23, 9, 750.00m, 6, 1 },
                    { 24, 9, 300.00m, 7, 1 },
                    { 25, 10, 200.00m, 8, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
