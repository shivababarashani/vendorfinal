using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class changeallRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchAddresses_BranchInfrastructures_BranchInfrastructureId",
                table: "BranchAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchAddresses_BranchStaffs_BranchStaffId",
                table: "BranchAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchAddresses_BranchTypes_BranchTypeId",
                table: "BranchAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Contries_ContryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Units_UnitId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_LicenseTypes_LicenseTypeId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCompany_Companies_CompanyId",
                table: "ProductCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCompany_Products_ProductId",
                table: "ProductCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionRates_Products_ProductId",
                table: "ProductionRates");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Corroborants_CorroborantId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LicenseTypeId",
                table: "Corroborants");

            migrationBuilder.AlterColumn<long>(
                name: "ProductTypeId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CorroborantId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductionRates",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductCompany",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CompanyId",
                table: "ProductCompany",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "LicenseTypeId",
                table: "Licenses",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerTypeId",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "UnitId",
                table: "Contracts",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "ContractTypeId",
                table: "Contracts",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "ContryId",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CarTypeId",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "BranchTypeId",
                table: "BranchAddresses",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "BranchStaffId",
                table: "BranchAddresses",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "BranchInfrastructureId",
                table: "BranchAddresses",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchAddresses_BranchInfrastructures_BranchInfrastructureId",
                table: "BranchAddresses",
                column: "BranchInfrastructureId",
                principalTable: "BranchInfrastructures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchAddresses_BranchStaffs_BranchStaffId",
                table: "BranchAddresses",
                column: "BranchStaffId",
                principalTable: "BranchStaffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchAddresses_BranchTypes_BranchTypeId",
                table: "BranchAddresses",
                column: "BranchTypeId",
                principalTable: "BranchTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars",
                column: "CarTypeId",
                principalTable: "CarTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Contries_ContryId",
                table: "Cars",
                column: "ContryId",
                principalTable: "Contries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId",
                principalTable: "ContractTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Units_UnitId",
                table: "Contracts",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers",
                column: "CustomerTypeId",
                principalTable: "CustomerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_LicenseTypes_LicenseTypeId",
                table: "Licenses",
                column: "LicenseTypeId",
                principalTable: "LicenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCompany_Companies_CompanyId",
                table: "ProductCompany",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCompany_Products_ProductId",
                table: "ProductCompany",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionRates_Products_ProductId",
                table: "ProductionRates",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Corroborants_CorroborantId",
                table: "Products",
                column: "CorroborantId",
                principalTable: "Corroborants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchAddresses_BranchInfrastructures_BranchInfrastructureId",
                table: "BranchAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchAddresses_BranchStaffs_BranchStaffId",
                table: "BranchAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchAddresses_BranchTypes_BranchTypeId",
                table: "BranchAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Contries_ContryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Units_UnitId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_LicenseTypes_LicenseTypeId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCompany_Companies_CompanyId",
                table: "ProductCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCompany_Products_ProductId",
                table: "ProductCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionRates_Products_ProductId",
                table: "ProductionRates");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Corroborants_CorroborantId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.AlterColumn<long>(
                name: "ProductTypeId",
                table: "Products",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CorroborantId",
                table: "Products",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductionRates",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductCompany",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CompanyId",
                table: "ProductCompany",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "LicenseTypeId",
                table: "Licenses",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CustomerTypeId",
                table: "Customers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LicenseTypeId",
                table: "Corroborants",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "UnitId",
                table: "Contracts",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ContractTypeId",
                table: "Contracts",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ContryId",
                table: "Cars",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CarTypeId",
                table: "Cars",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BranchTypeId",
                table: "BranchAddresses",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BranchStaffId",
                table: "BranchAddresses",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BranchInfrastructureId",
                table: "BranchAddresses",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchAddresses_BranchInfrastructures_BranchInfrastructureId",
                table: "BranchAddresses",
                column: "BranchInfrastructureId",
                principalTable: "BranchInfrastructures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchAddresses_BranchStaffs_BranchStaffId",
                table: "BranchAddresses",
                column: "BranchStaffId",
                principalTable: "BranchStaffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchAddresses_BranchTypes_BranchTypeId",
                table: "BranchAddresses",
                column: "BranchTypeId",
                principalTable: "BranchTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars",
                column: "CarTypeId",
                principalTable: "CarTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Contries_ContryId",
                table: "Cars",
                column: "ContryId",
                principalTable: "Contries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId",
                principalTable: "ContractTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Units_UnitId",
                table: "Contracts",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers",
                column: "CustomerTypeId",
                principalTable: "CustomerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_LicenseTypes_LicenseTypeId",
                table: "Licenses",
                column: "LicenseTypeId",
                principalTable: "LicenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCompany_Companies_CompanyId",
                table: "ProductCompany",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCompany_Products_ProductId",
                table: "ProductCompany",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionRates_Products_ProductId",
                table: "ProductionRates",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Corroborants_CorroborantId",
                table: "Products",
                column: "CorroborantId",
                principalTable: "Corroborants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
