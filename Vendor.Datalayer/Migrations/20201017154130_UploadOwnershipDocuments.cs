using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class UploadOwnershipDocuments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UploadOwnershipDocuments",
                table: "BranchInfrastructures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UploadOwnershipDocuments",
                table: "BranchInfrastructures");
        }
    }
}
