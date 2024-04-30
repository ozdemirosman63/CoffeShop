using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Migrations
{
    public partial class migfull1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoffeeMenus",
                columns: table => new
                {
                    CoffeeMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoffeeMenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoffeeMenuPrice = table.Column<double>(type: "float", nullable: false),
                    CoffeeMenuDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoffeeMenuUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoffeeMenuCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeMenus", x => x.CoffeeMenuId);
                });

            migrationBuilder.CreateTable(
                name: "Coffees",
                columns: table => new
                {
                    CoffeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CoffeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffees", x => x.CoffeeId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderPrice = table.Column<double>(type: "float", nullable: false),
                    OrderUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.InsertData(
                table: "CoffeeMenus",
                columns: new[] { "CoffeeMenuId", "CoffeeMenuCount", "CoffeeMenuDescription", "CoffeeMenuName", "CoffeeMenuPrice", "CoffeeMenuUrl" },
                values: new object[,]
                {
                    { 1, 0, "Espresso with lots of steamed milk and a light foam.", "LATTE", 17.5, "/image/latte.jpg" },
                    { 2, 0, "Intense and quickly brewed concentrated coffee", "ESPRESSO", 15.99, "/image/espresso.jpg" },
                    { 3, 0, "Espresso with steamed milk and a frothy layer.", "CAPPUCINO", 9.9900000000000002, "/image/cappucino.jpg" },
                    { 4, 0, "Espresso combined with steamed milk and chocolate.", "MOCHA", 10.75, "/image/mocha.jpg" },
                    { 5, 0, "Espresso stained with a dollop of frothy milk.", "MACCHIATO", 11.99, "/image/macchiato.jpg" },
                    { 6, 0, "A strong espresso diluted with hot water.", "AMERICANO", 12.5, "/image/americano.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoffeeMenus");

            migrationBuilder.DropTable(
                name: "Coffees");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
