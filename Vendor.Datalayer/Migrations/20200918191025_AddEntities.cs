using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendor.Datalayer.Migrations
{
    public partial class AddEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchInfrastructures",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Area = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchInfrastructures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BranchStaffs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchStaffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BranchTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorroborantTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorroborantTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exports",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    Employer = table.Column<string>(nullable: true),
                    ContractNumber = table.Column<string>(nullable: true),
                    WeightNumber = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LicenseTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnershipType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnershipType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(nullable: false),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    ManufactuCapacityreDate = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UploadQc = table.Column<string>(nullable: true),
                    CarTypeId = table.Column<long>(nullable: false),
                    ContryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Contries_ContryId",
                        column: x => x.ContryId,
                        principalTable: "Contries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corroborants",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    UploadLinces = table.Column<string>(nullable: true),
                    LicenseTypeId = table.Column<long>(nullable: false),
                    CorroborantTypeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corroborants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corroborants_CorroborantTypes_CorroborantTypeId",
                        column: x => x.CorroborantTypeId,
                        principalTable: "CorroborantTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    IDNumber = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    DegreeEducation = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    WorkExperience = table.Column<int>(nullable: false),
                    TheSignatory = table.Column<bool>(nullable: false),
                    CustomerTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerTypes_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    UploadLinces = table.Column<string>(nullable: true),
                    LicenseTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenses_LicenseTypes_LicenseTypeId",
                        column: x => x.LicenseTypeId,
                        principalTable: "LicenseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ContractingParty = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    WeightNumber = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DeliveryTime = table.Column<DateTime>(nullable: false),
                    Progress = table.Column<decimal>(nullable: false),
                    ContractTypeId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_ContractTypes_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Guarantee = table.Column<bool>(nullable: false),
                    Environment = table.Column<bool>(nullable: false),
                    UploadControlForm = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<long>(nullable: false),
                    CorroborantId = table.Column<long>(nullable: false),
                    LicenseTypeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Corroborants_CorroborantId",
                        column: x => x.CorroborantId,
                        principalTable: "Corroborants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_LicenseTypes_LicenseTypeId",
                        column: x => x.LicenseTypeId,
                        principalTable: "LicenseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RecordNumber = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    RecordPlace = table.Column<string>(nullable: true),
                    CompanyStartDate = table.Column<DateTime>(nullable: false),
                    FactoryStartDate = table.Column<DateTime>(nullable: false),
                    FactoryUseDate = table.Column<DateTime>(nullable: false),
                    NationalId = table.Column<long>(nullable: false),
                    EconomicCode = table.Column<string>(nullable: true),
                    UseLicenseNumber = table.Column<string>(nullable: true),
                    UseLicenseDate = table.Column<DateTime>(nullable: false),
                    ActivityDescription = table.Column<string>(nullable: true),
                    MaterialList = table.Column<string>(nullable: true),
                    Randd = table.Column<string>(nullable: true),
                    ConstructionMetod = table.Column<string>(nullable: true),
                    QcProgram = table.Column<string>(nullable: true),
                    ResearchMember = table.Column<string>(nullable: true),
                    UploadUseLicensePic = table.Column<string>(nullable: true),
                    UploadStatutePic = table.Column<string>(nullable: true),
                    UploadOfficialnewspapers = table.Column<string>(nullable: true),
                    UploadProductCatalog = table.Column<string>(nullable: true),
                    UploadDocuments = table.Column<string>(nullable: true),
                    UploadMemberOfTheInstitute = table.Column<string>(nullable: true),
                    CompanyTypeId = table.Column<long>(nullable: false),
                    OwnershipTypeId = table.Column<long>(nullable: false),
                    CarId = table.Column<long>(nullable: false),
                    LicenseId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_OwnershipType_OwnershipTypeId",
                        column: x => x.OwnershipTypeId,
                        principalTable: "OwnershipType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExportProduct",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExportId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExportProduct_Exports_ExportId",
                        column: x => x.ExportId,
                        principalTable: "Exports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExportProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionRates",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    ProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionRates_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    BranchTypeId = table.Column<long>(nullable: false),
                    BranchStaffId = table.Column<long>(nullable: false),
                    BranchInfrastructureId = table.Column<long>(nullable: false),
                    CompanyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchAddresses_BranchInfrastructures_BranchInfrastructureId",
                        column: x => x.BranchInfrastructureId,
                        principalTable: "BranchInfrastructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchAddresses_BranchStaffs_BranchStaffId",
                        column: x => x.BranchStaffId,
                        principalTable: "BranchStaffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchAddresses_BranchTypes_BranchTypeId",
                        column: x => x.BranchTypeId,
                        principalTable: "BranchTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchAddresses_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCompany",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCompany_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCompany_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchAddresses_BranchInfrastructureId",
                table: "BranchAddresses",
                column: "BranchInfrastructureId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchAddresses_BranchStaffId",
                table: "BranchAddresses",
                column: "BranchStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchAddresses_BranchTypeId",
                table: "BranchAddresses",
                column: "BranchTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchAddresses_CompanyId",
                table: "BranchAddresses",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeId",
                table: "Cars",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ContryId",
                table: "Cars",
                column: "ContryId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CarId",
                table: "Companies",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LicenseId",
                table: "Companies",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_OwnershipTypeId",
                table: "Companies",
                column: "OwnershipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductId",
                table: "Companies",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_UnitId",
                table: "Contracts",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Corroborants_CorroborantTypeId",
                table: "Corroborants",
                column: "CorroborantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerTypeId",
                table: "Customers",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_ExportId",
                table: "ExportProduct",
                column: "ExportId");

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_ProductId",
                table: "ExportProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_LicenseTypeId",
                table: "Licenses",
                column: "LicenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCompany_CompanyId",
                table: "ProductCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCompany_ProductId",
                table: "ProductCompany",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionRates_ProductId",
                table: "ProductionRates",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CorroborantId",
                table: "Products",
                column: "CorroborantId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LicenseTypeId",
                table: "Products",
                column: "LicenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchAddresses");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ExportProduct");

            migrationBuilder.DropTable(
                name: "ProductCompany");

            migrationBuilder.DropTable(
                name: "ProductionRates");

            migrationBuilder.DropTable(
                name: "BranchInfrastructures");

            migrationBuilder.DropTable(
                name: "BranchStaffs");

            migrationBuilder.DropTable(
                name: "BranchTypes");

            migrationBuilder.DropTable(
                name: "ContractTypes");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "Exports");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "OwnershipType");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "Contries");

            migrationBuilder.DropTable(
                name: "Corroborants");

            migrationBuilder.DropTable(
                name: "LicenseTypes");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "CorroborantTypes");
        }
    }
}
