using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class CorroborantTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corroborants_CorroborantTypes_CorroborantTypeId",
                table: "Corroborants");

            migrationBuilder.DropColumn(
                name: "LicenseTypeId",
                table: "Corroborants");

            migrationBuilder.AlterColumn<long>(
                name: "CorroborantTypeId",
                table: "Corroborants",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Corroborants_CorroborantTypes_CorroborantTypeId",
                table: "Corroborants",
                column: "CorroborantTypeId",
                principalTable: "CorroborantTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corroborants_CorroborantTypes_CorroborantTypeId",
                table: "Corroborants");

            migrationBuilder.AlterColumn<long>(
                name: "CorroborantTypeId",
                table: "Corroborants",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "LicenseTypeId",
                table: "Corroborants",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_Corroborants_CorroborantTypes_CorroborantTypeId",
                table: "Corroborants",
                column: "CorroborantTypeId",
                principalTable: "CorroborantTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
