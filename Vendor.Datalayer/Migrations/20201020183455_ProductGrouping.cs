using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class ProductGrouping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ContractTypes");

            migrationBuilder.AddColumn<string>(
                name: "IranCode",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ManufacturingGroupId",
                table: "Companies",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ManufacturingGroups",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingGroups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ManufacturingGroupId",
                table: "Companies",
                column: "ManufacturingGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_ManufacturingGroups_ManufacturingGroupId",
                table: "Companies",
                column: "ManufacturingGroupId",
                principalTable: "ManufacturingGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_ManufacturingGroups_ManufacturingGroupId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "ManufacturingGroups");

            migrationBuilder.DropIndex(
                name: "IX_Companies_ManufacturingGroupId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "IranCode",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ManufacturingGroupId",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ContractTypes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
