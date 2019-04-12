using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PJ_webservice_CRUD.Migrations
{
    public partial class PO_DetailMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Category",
            //    columns: table => new
            //    {
            //        CategoryID = table.Column<string>(type: "varchar(10)", nullable: false),
            //        CategoryName = table.Column<string>(type: "varchar(50)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Category", x => x.CategoryID);
            //    });

            migrationBuilder.CreateTable(
                name: "PO_Header",
                columns: table => new
                {
                    PO_SupplyID = table.Column<string>(type: "varchar(10)", nullable: false),
                    PO_SupplyName = table.Column<string>(type: "varchar(50)", nullable: false),
                    PO_Adress = table.Column<string>(type: "varchar(200)", nullable: false),
                    PO_Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    PO_Tel = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PO_Header", x => x.PO_SupplyID);
                });

            //migrationBuilder.CreateTable(
            //    name: "Product",
            //    columns: table => new
            //    {
            //        ProductID = table.Column<string>(type: "varchar(10)", nullable: false),
            //        ProductName = table.Column<string>(type: "varchar(50)", nullable: false),
            //        Price = table.Column<int>(nullable: false),
            //        Amount = table.Column<int>(nullable: false),
            //        ImgURL = table.Column<string>(nullable: true),
            //        CategoryID = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Product", x => x.ProductID);
            //        table.ForeignKey(
            //            name: "FK_Product_Category_CategoryID",
            //            column: x => x.CategoryID,
            //            principalTable: "Category",
            //            principalColumn: "CategoryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.CreateTable(
                name: "PO_Details",
                columns: table => new
                {
                    PO_DetailID = table.Column<string>(type: "varchar(10)", nullable: false),
                    PO_HeaderPO_SupplyID = table.Column<string>(nullable: false),
                    ProductID = table.Column<string>(nullable: false),
                    PO_Quantity = table.Column<int>(nullable: false),
                    PO_Date = table.Column<DateTime>(nullable: false),
                    PO_PriceOfUnit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PO_Details", x => x.PO_DetailID);
                    table.ForeignKey(
                        name: "FK_PO_Details_PO_Header_PO_HeaderPO_SupplyID",
                        column: x => x.PO_HeaderPO_SupplyID,
                        principalTable: "PO_Header",
                        principalColumn: "PO_SupplyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PO_Details_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PO_Details_PO_HeaderPO_SupplyID",
                table: "PO_Details",
                column: "PO_HeaderPO_SupplyID");

            migrationBuilder.CreateIndex(
                name: "IX_PO_Details_ProductID",
                table: "PO_Details",
                column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_CategoryID",
            //    table: "Product",
            //    column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PO_Details");

            migrationBuilder.DropTable(
                name: "PO_Header");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
