using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class IsEquipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEquipment",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UploadCalibrationMachine",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEquipment",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "UploadCalibrationMachine",
                table: "Cars");
        }
    }
}
