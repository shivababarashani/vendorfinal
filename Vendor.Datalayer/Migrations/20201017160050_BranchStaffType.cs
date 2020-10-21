using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class BranchStaffType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "BranchStaffs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BranchStaffs");

            migrationBuilder.AddColumn<long>(
                name: "BranchStaffTypeId",
                table: "BranchStaffs",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "NonTechnicalCount",
                table: "BranchStaffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechnicalCount",
                table: "BranchStaffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UploadInsurance",
                table: "BranchStaffs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BranchStaffType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchStaffType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchStaffs_BranchStaffTypeId",
                table: "BranchStaffs",
                column: "BranchStaffTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchStaffs_BranchStaffType_BranchStaffTypeId",
                table: "BranchStaffs",
                column: "BranchStaffTypeId",
                principalTable: "BranchStaffType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchStaffs_BranchStaffType_BranchStaffTypeId",
                table: "BranchStaffs");

            migrationBuilder.DropTable(
                name: "BranchStaffType");

            migrationBuilder.DropIndex(
                name: "IX_BranchStaffs_BranchStaffTypeId",
                table: "BranchStaffs");

            migrationBuilder.DropColumn(
                name: "BranchStaffTypeId",
                table: "BranchStaffs");

            migrationBuilder.DropColumn(
                name: "NonTechnicalCount",
                table: "BranchStaffs");

            migrationBuilder.DropColumn(
                name: "TechnicalCount",
                table: "BranchStaffs");

            migrationBuilder.DropColumn(
                name: "UploadInsurance",
                table: "BranchStaffs");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "BranchStaffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BranchStaffs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
