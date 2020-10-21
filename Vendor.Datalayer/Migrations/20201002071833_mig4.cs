using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Products_ProductId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "ProductCompany");

            migrationBuilder.DropIndex(
                name: "IX_Companies_ProductId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Companies");

            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
                table: "Products",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Companies_CompanyId",
                table: "Products",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Companies_CompanyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CompanyId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Products");

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "Companies",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductCompany",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCompany_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCompany_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductId",
                table: "Companies",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCompany_CompanyId",
                table: "ProductCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCompany_ProductId",
                table: "ProductCompany",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Products_ProductId",
                table: "Companies",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
