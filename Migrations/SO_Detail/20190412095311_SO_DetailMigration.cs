using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PJ_webservice_CRUD.Migrations.SO_Detail
{
    public partial class SO_DetailMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "varchar(10)", nullable: false),
                    CategoryName = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "SO_Header",
                columns: table => new
                {
                    SO_CusID = table.Column<string>(type: "varchar(10)", nullable: false),
                    SO_CusName = table.Column<string>(type: "varchar(50)", nullable: false),
                    SO_Address = table.Column<string>(type: "varchar(200)", nullable: false),
                    SO_Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    SO_Phone = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SO_Header", x => x.SO_CusID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<string>(type: "varchar(10)", nullable: false),
                    ProductName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SO_Details",
                columns: table => new
                {
                    SO_DetailID = table.Column<string>(type: "varchar(10)", nullable: false),
                    SO_HeaderSO_CusID = table.Column<string>(nullable: false),
                    ProductID = table.Column<string>(nullable: false),
                    SO_Quantity = table.Column<int>(nullable: false),
                    SO_Date = table.Column<DateTime>(nullable: false),
                    SO_PriceOfUnit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SO_Details", x => x.SO_DetailID);
                    table.ForeignKey(
                        name: "FK_SO_Details_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SO_Details_SO_Header_SO_HeaderSO_CusID",
                        column: x => x.SO_HeaderSO_CusID,
                        principalTable: "SO_Header",
                        principalColumn: "SO_CusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SO_Details_ProductID",
                table: "SO_Details",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SO_Details_SO_HeaderSO_CusID",
                table: "SO_Details",
                column: "SO_HeaderSO_CusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SO_Details");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SO_Header");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
