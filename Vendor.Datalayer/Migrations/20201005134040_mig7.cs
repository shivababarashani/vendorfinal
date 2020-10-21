using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExportProduct");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Exports");

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "Exports",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Exports_ProductId",
                table: "Exports",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exports_Products_ProductId",
                table: "Exports",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exports_Products_ProductId",
                table: "Exports");

            migrationBuilder.DropIndex(
                name: "IX_Exports_ProductId",
                table: "Exports");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Exports");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Exports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExportProduct",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExportId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExportProduct_Exports_ExportId",
                        column: x => x.ExportId,
                        principalTable: "Exports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExportProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_ExportId",
                table: "ExportProduct",
                column: "ExportId");

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_ProductId",
                table: "ExportProduct",
                column: "ProductId");
        }
    }
}
