using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArchpointMvcPHR.Migrations
{
    public partial class SecondManualMigrationscottsFirstBranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorAppointment",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ApptDate = table.Column<DateTime>(maxLength: 80, nullable: false),
                    MedicalProviderId = table.Column<int>(maxLength: 80, nullable: false),
                    ReasonForVisit = table.Column<string>(maxLength: 80, nullable: false),
                    SymptomComplaint = table.Column<string>(maxLength: 80, nullable: false),
                    FacilityName = table.Column<string>(maxLength: 80, nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: false),
                    Fax = table.Column<string>(maxLength: 40, nullable: true),
                    Email = table.Column<string>(maxLength: 80, nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    RemindMe = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorAppointment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 60, nullable: false),
                    LastName = table.Column<string>(maxLength: 60, nullable: false),
                    RelationshipToPatient = table.Column<string>(maxLength: 60, nullable: false),
                    HomePhone = table.Column<string>(maxLength: 20, nullable: true),
                    EveningPhone = table.Column<string>(maxLength: 20, nullable: true),
                    CellPhone = table.Column<string>(maxLength: 20, nullable: false),
                    EmerContactEmail = table.Column<string>(maxLength: 80, nullable: true),
                    EmerContactStreetAddress = table.Column<string>(maxLength: 60, nullable: false),
                    EmerContactCity = table.Column<string>(maxLength: 60, nullable: false),
                    EmerContactStateProvince = table.Column<string>(maxLength: 60, nullable: false),
                    EmerContactZip = table.Column<string>(maxLength: 20, nullable: false),
                    EmerContactCountry = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployerName = table.Column<string>(maxLength: 60, nullable: false),
                    Address = table.Column<string>(maxLength: 60, nullable: false),
                    City = table.Column<string>(maxLength: 60, nullable: false),
                    State = table.Column<string>(maxLength: 60, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 15, nullable: false),
                    PhoneNum = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrimaryOrSecondary = table.Column<string>(maxLength: 20, nullable: false),
                    InsuranceName = table.Column<string>(maxLength: 60, nullable: false),
                    InsurancePhoneNum = table.Column<string>(maxLength: 20, nullable: false),
                    InsuranceStreetAddress = table.Column<string>(maxLength: 60, nullable: false),
                    InsuranceCity = table.Column<string>(maxLength: 60, nullable: false),
                    InsuranceState = table.Column<string>(maxLength: 60, nullable: false),
                    InsuranceCountry = table.Column<string>(maxLength: 60, nullable: false),
                    PolicyIdNo = table.Column<string>(maxLength: 20, nullable: false),
                    GroupNo = table.Column<string>(maxLength: 20, nullable: false),
                    PlanEffectiveDate = table.Column<DateTime>(maxLength: 20, nullable: false),
                    AuthorizationPhoneNum = table.Column<string>(maxLength: 20, nullable: false),
                    MedicareClaimNum = table.Column<string>(nullable: true),
                    MedicaidClaimNum = table.Column<string>(nullable: true),
                    MedicareMedicaidEffectiveDate = table.Column<DateTime>(maxLength: 20, nullable: false),
                    PolicyHolderFirstName = table.Column<string>(maxLength: 60, nullable: false),
                    PolicyHolderMidInit = table.Column<string>(maxLength: 1, nullable: false),
                    PolicyHolderLastName = table.Column<string>(maxLength: 60, nullable: false),
                    RelationshipToPolicyHolder = table.Column<string>(maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(maxLength: 20, nullable: false),
                    SocialSecurityNo = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiseaseDisorder = table.Column<string>(maxLength: 80, nullable: false),
                    DateOfDiagnosis = table.Column<DateTime>(maxLength: 80, nullable: false),
                    AgeAtOnset = table.Column<string>(maxLength: 10, nullable: false),
                    Status = table.Column<string>(maxLength: 80, nullable: false),
                    DateResolved = table.Column<DateTime>(maxLength: 80, nullable: false),
                    MedicalProviderId = table.Column<string>(maxLength: 80, nullable: false),
                    Comments = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProvider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrimaryOrNot = table.Column<string>(maxLength: 20, nullable: false),
                    ActiveOrInactive = table.Column<string>(maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(maxLength: 60, nullable: false),
                    LastName = table.Column<string>(maxLength: 60, nullable: false),
                    TypeOfSpecialty = table.Column<string>(maxLength: 60, nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 80, nullable: false),
                    City = table.Column<string>(maxLength: 80, nullable: false),
                    State = table.Column<string>(maxLength: 60, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 20, nullable: false),
                    Country = table.Column<string>(maxLength: 60, nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: false),
                    Fax = table.Column<string>(maxLength: 40, nullable: true),
                    Email = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProvider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 60, nullable: false),
                    MiddleInitial = table.Column<string>(maxLength: 1, nullable: false),
                    LastName = table.Column<string>(maxLength: 60, nullable: false),
                    Sex = table.Column<string>(maxLength: 20, nullable: false),
                    BloodType = table.Column<string>(maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    SocialSecurityNum = table.Column<string>(maxLength: 11, nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 80, nullable: false),
                    City = table.Column<string>(maxLength: 80, nullable: false),
                    State = table.Column<string>(maxLength: 60, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 20, nullable: false),
                    Country = table.Column<string>(maxLength: 60, nullable: false),
                    HomePhone = table.Column<string>(maxLength: 20, nullable: true),
                    CellPhone = table.Column<string>(maxLength: 20, nullable: false),
                    Race = table.Column<string>(maxLength: 60, nullable: false),
                    MaritalStatus = table.Column<string>(maxLength: 60, nullable: false),
                    Religion = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorAppointment");

            migrationBuilder.DropTable(
                name: "EmergencyContact");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "MedicalHistory");

            migrationBuilder.DropTable(
                name: "MedicalProvider");

            migrationBuilder.DropTable(
                name: "PersonalInfo");
        }
    }
}
