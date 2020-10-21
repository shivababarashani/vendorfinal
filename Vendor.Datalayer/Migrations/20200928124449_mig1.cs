using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufactuCapacityreDate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "UploadQc",
                table: "Cars");

            migrationBuilder.AddColumn<decimal>(
                name: "Capacity",
                table: "Cars",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Cars");

            migrationBuilder.AddColumn<decimal>(
                name: "ManufactuCapacityreDate",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "UploadQc",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
