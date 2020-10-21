using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class ContractTypesEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ContractTypeId",
                table: "Contracts");

            migrationBuilder.AddColumn<string>(
                name: "UploadDocuments",
                table: "Customers",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContractTypeId",
                table: "Contracts",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ContractTypeId1",
                table: "Contracts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractTypeId1",
                table: "Contracts",
                column: "ContractTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId1",
                table: "Contracts",
                column: "ContractTypeId1",
                principalTable: "ContractTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId1",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ContractTypeId1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "UploadDocuments",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContractTypeId1",
                table: "Contracts");

            migrationBuilder.AlterColumn<long>(
                name: "ContractTypeId",
                table: "Contracts",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId",
                principalTable: "ContractTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
