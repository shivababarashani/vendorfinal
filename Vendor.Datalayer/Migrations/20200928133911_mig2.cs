using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Cars_CarId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CarId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Companies");

            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CompanyId",
                table: "Cars",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Companies_CompanyId",
                table: "Cars",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Companies_CompanyId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CompanyId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Cars");

            migrationBuilder.AddColumn<long>(
                name: "CarId",
                table: "Companies",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CarId",
                table: "Companies",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Cars_CarId",
                table: "Companies",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
