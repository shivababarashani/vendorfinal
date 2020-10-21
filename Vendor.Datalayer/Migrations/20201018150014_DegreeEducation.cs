using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class DegreeEducation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DegreeEducation",
                table: "Customers");

            migrationBuilder.AddColumn<long>(
                name: "DegreeEducationId",
                table: "Customers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "DegreeEducation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeEducation", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DegreeEducationId",
                table: "Customers",
                column: "DegreeEducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_DegreeEducation_DegreeEducationId",
                table: "Customers",
                column: "DegreeEducationId",
                principalTable: "DegreeEducation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_DegreeEducation_DegreeEducationId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "DegreeEducation");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DegreeEducationId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DegreeEducationId",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "DegreeEducation",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
