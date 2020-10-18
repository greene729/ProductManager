using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductManager.Migrations
{
    public partial class AddMaterials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    Units = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Supplier = table.Column<string>(nullable: true),
                    OrderableQuantity = table.Column<double>(nullable: true),
                    SupplierItemNumber = table.Column<string>(nullable: true),
                    ReorderLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[] { 1001, "This is a best gaming laptop", "Laptop", 20.02, 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[] { 1002, "This is a Office Application", "Microsoft Office", 20.989999999999998, 50 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[] { 1003, "The mouse that works on all surface", "Lazer Mouse", 12.02, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[] { 1004, "To store 256GB of data", "USB Storage", 5.0, 20 });
        }
    }
}
