using Microsoft.EntityFrameworkCore.Migrations;

namespace PJ_webservice_CRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<string>(type: "varchar(10)", nullable: false),
                    ProductName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CatID = table.Column<string>(type: "varchar(10)", nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
