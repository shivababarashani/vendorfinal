using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class BranchInfrastructureType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OwnershipType");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LicenseTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CustomerTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CorroborantTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Contries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CompanyTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CarTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BranchTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BranchStaffs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BranchInfrastructures");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BranchInfrastructures");

            migrationBuilder.AddColumn<long>(
                name: "BranchInfrastructureTypeId",
                table: "BranchInfrastructures",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "InfrastructureType",
                table: "BranchInfrastructures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BranchInfrastructureType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchInfrastructureType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchInfrastructures_BranchInfrastructureTypeId",
                table: "BranchInfrastructures",
                column: "BranchInfrastructureTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfrastructures_BranchInfrastructureType_BranchInfrastructureTypeId",
                table: "BranchInfrastructures",
                column: "BranchInfrastructureTypeId",
                principalTable: "BranchInfrastructureType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfrastructures_BranchInfrastructureType_BranchInfrastructureTypeId",
                table: "BranchInfrastructures");

            migrationBuilder.DropTable(
                name: "BranchInfrastructureType");

            migrationBuilder.DropIndex(
                name: "IX_BranchInfrastructures_BranchInfrastructureTypeId",
                table: "BranchInfrastructures");

            migrationBuilder.DropColumn(
                name: "BranchInfrastructureTypeId",
                table: "BranchInfrastructures");

            migrationBuilder.DropColumn(
                name: "InfrastructureType",
                table: "BranchInfrastructures");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ProductTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "OwnershipType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "LicenseTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CustomerTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CorroborantTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Contries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CompanyTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CarTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BranchTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BranchStaffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BranchInfrastructures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BranchInfrastructures",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
