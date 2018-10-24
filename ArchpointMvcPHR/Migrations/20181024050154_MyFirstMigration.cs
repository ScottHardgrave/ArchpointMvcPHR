using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArchpointMvcPHR.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LegalDocument",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Will = table.Column<string>(maxLength: 3, nullable: false),
                    WillDateSigned = table.Column<DateTime>(maxLength: 60, nullable: false),
                    WillLastUpdated = table.Column<DateTime>(maxLength: 60, nullable: false),
                    WillCopy = table.Column<string>(maxLength: 3, nullable: true),
                    FamilyAware = table.Column<string>(maxLength: 3, nullable: true),
                    MedPowerOfAttorney = table.Column<string>(maxLength: 3, nullable: false),
                    MedPowerOfAttorneyName = table.Column<string>(maxLength: 100, nullable: true),
                    DateMedPowerOfAttorney = table.Column<DateTime>(maxLength: 60, nullable: false),
                    DateUpdatedMedPowerOfAttorney = table.Column<DateTime>(maxLength: 60, nullable: false),
                    MedPowerOfAttorneyCopyOnFile = table.Column<string>(maxLength: 3, nullable: true),
                    HealthCareProxy = table.Column<string>(maxLength: 3, nullable: false),
                    HealthCareProxyName = table.Column<string>(maxLength: 60, nullable: true),
                    HealthCareProxyDateSign = table.Column<DateTime>(maxLength: 60, nullable: false),
                    HealthCareProxyLastUpdate = table.Column<DateTime>(maxLength: 60, nullable: false),
                    DoNotResuscitate = table.Column<string>(maxLength: 3, nullable: false),
                    DnrDateSign = table.Column<DateTime>(maxLength: 60, nullable: false),
                    DnrDateUpdate = table.Column<DateTime>(maxLength: 60, nullable: false),
                    OrganDonorDocument = table.Column<string>(maxLength: 3, nullable: false),
                    OrganDonorDocumentDateSign = table.Column<DateTime>(maxLength: 60, nullable: false),
                    OrganDonorDocumentLastUpdate = table.Column<DateTime>(maxLength: 60, nullable: false),
                    DocumentLocation = table.Column<string>(maxLength: 60, nullable: false),
                    DocumentContactFirstName = table.Column<string>(maxLength: 60, nullable: false),
                    DocumentContactLastName = table.Column<string>(maxLength: 60, nullable: false),
                    DocumentContactPhone = table.Column<string>(maxLength: 60, nullable: false),
                    AttorneyFirstName = table.Column<string>(maxLength: 60, nullable: false),
                    AttorneyLastName = table.Column<string>(maxLength: 60, nullable: false),
                    AttorneyPhone = table.Column<string>(maxLength: 60, nullable: false),
                    Comments = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalDocument", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medication",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Physician = table.Column<string>(maxLength: 70, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Dosage = table.Column<string>(maxLength: 30, nullable: true),
                    Reason = table.Column<string>(maxLength: 200, nullable: false),
                    Type = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medication", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LegalDocument");

            migrationBuilder.DropTable(
                name: "Medication");
        }
    }
}
