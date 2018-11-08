using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArchpointMvcPHR.Migrations
{
    public partial class AllClassesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CancerHistory",
                columns: table => new
                {
                    CancerHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedProviderId = table.Column<string>(nullable: false),
                    TypeOfCancerTumor = table.Column<string>(maxLength: 60, nullable: false),
                    DiagnosisDate = table.Column<DateTime>(nullable: false),
                    AgeAtDiagnosis = table.Column<string>(maxLength: 3, nullable: false),
                    StageOfCancerTumor = table.Column<string>(maxLength: 20, nullable: false),
                    MedCareLocationId = table.Column<string>(nullable: false),
                    TreatmentReceived = table.Column<string>(maxLength: 255, nullable: false),
                    TreatmentDate = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancerHistory", x => x.CancerHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "Caregivers",
                columns: table => new
                {
                    CaregiversId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PatientFirstName = table.Column<string>(maxLength: 100, nullable: false),
                    PatientMiddleInitial = table.Column<string>(maxLength: 1, nullable: false),
                    patientLastName = table.Column<string>(maxLength: 100, nullable: false),
                    RelationshipToPatient = table.Column<string>(maxLength: 60, nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    StateProvince = table.Column<string>(maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 25, nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    EveningPhone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    PatientCurrentlyInNursingFacility = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caregivers", x => x.CaregiversId);
                });

            migrationBuilder.CreateTable(
                name: "EarNoseThroatHistory",
                columns: table => new
                {
                    EarNoseThroatHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiseaseDisorder = table.Column<string>(maxLength: 60, nullable: false),
                    DiagnosisDate = table.Column<DateTime>(nullable: false),
                    CurrentStatus = table.Column<string>(maxLength: 60, nullable: false),
                    DateResolved = table.Column<DateTime>(nullable: false),
                    MedicalProviderId = table.Column<int>(nullable: false),
                    MedCareLocationId = table.Column<int>(nullable: false),
                    Surgery = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EarNoseThroatHistory", x => x.EarNoseThroatHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "EyeHistory",
                columns: table => new
                {
                    EyeHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateLastEyeExam = table.Column<DateTime>(nullable: false),
                    DateNextEyeExam = table.Column<DateTime>(nullable: false),
                    DateLastGlaucomaExam = table.Column<DateTime>(nullable: false),
                    DateNextGlaucomaExam = table.Column<DateTime>(nullable: false),
                    MedicalProviderId = table.Column<int>(nullable: false),
                    Eyeglasses = table.Column<string>(maxLength: 60, nullable: false),
                    ContactLenses = table.Column<string>(maxLength: 60, nullable: false),
                    PrescriptionDate = table.Column<DateTime>(nullable: false),
                    ContactBrandName = table.Column<string>(maxLength: 60, nullable: true),
                    EyeDiseaseDisorder = table.Column<string>(maxLength: 60, nullable: false),
                    EyeDiseaseDisorderDiagnosisDate = table.Column<DateTime>(nullable: false),
                    EyeDiseaseDisorderStatus = table.Column<string>(maxLength: 60, nullable: false),
                    EyeDiseaseDisorderResolveDate = table.Column<DateTime>(nullable: false),
                    PreviousEyeSurgery = table.Column<string>(maxLength: 60, nullable: false),
                    EyeSurgeryProcedure = table.Column<string>(maxLength: 100, nullable: true),
                    EyeSurgeryProcedureDate = table.Column<DateTime>(nullable: false),
                    MedCareLocationId = table.Column<string>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EyeHistory", x => x.EyeHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "HeartHistory",
                columns: table => new
                {
                    HeartHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedicalProviderId = table.Column<int>(nullable: false),
                    HeartDiseaseDisorder = table.Column<string>(maxLength: 100, nullable: false),
                    DiagnosisDate = table.Column<DateTime>(nullable: false),
                    DiagnosisStatus = table.Column<string>(maxLength: 80, nullable: false),
                    DateResolved = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartHistory", x => x.HeartHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "MensHealth",
                columns: table => new
                {
                    MensHealthId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateLastAnnualPhysical = table.Column<DateTime>(nullable: false),
                    DateNextAnnualPhysical = table.Column<DateTime>(nullable: false),
                    FamilyHistoryProstateCancer = table.Column<string>(nullable: true),
                    DateLastProstateExam = table.Column<DateTime>(nullable: false),
                    LastProstateExamResults = table.Column<string>(nullable: true),
                    DateNextProstateExam = table.Column<DateTime>(nullable: false),
                    DateLastPsa = table.Column<DateTime>(nullable: false),
                    LastPsaresults = table.Column<string>(nullable: true),
                    PsaLevelTestNumber = table.Column<int>(nullable: false),
                    DateNextPsatest = table.Column<DateTime>(nullable: false),
                    DateLastFecalOccultTest = table.Column<DateTime>(nullable: false),
                    FecalOccultResults = table.Column<string>(nullable: true),
                    DateNextFecalOccultTest = table.Column<DateTime>(nullable: false),
                    DateLastSigmoidColonoscopyExam = table.Column<DateTime>(nullable: false),
                    SigmoidColonoscopyResults = table.Column<string>(nullable: true),
                    DateNextSigmoidColonoscopy = table.Column<DateTime>(nullable: false),
                    MensHealthIssues = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MensHealth", x => x.MensHealthId);
                });

            migrationBuilder.CreateTable(
                name: "MentalHealthHistory",
                columns: table => new
                {
                    MentalHealthHistoryid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentTreatmentForMentalDisorder = table.Column<string>(maxLength: 100, nullable: false),
                    MedCareLocationId = table.Column<int>(nullable: false),
                    TypeOfTreatment = table.Column<string>(maxLength: 100, nullable: false),
                    TreatedInPast = table.Column<string>(maxLength: 20, nullable: false),
                    MentalConditionDisorder = table.Column<string>(maxLength: 100, nullable: false),
                    CurrentMedication = table.Column<string>(maxLength: 100, nullable: false),
                    MedicalProviderId = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentalHealthHistory", x => x.MentalHealthHistoryid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CancerHistory");

            migrationBuilder.DropTable(
                name: "Caregivers");

            migrationBuilder.DropTable(
                name: "EarNoseThroatHistory");

            migrationBuilder.DropTable(
                name: "EyeHistory");

            migrationBuilder.DropTable(
                name: "HeartHistory");

            migrationBuilder.DropTable(
                name: "MensHealth");

            migrationBuilder.DropTable(
                name: "MentalHealthHistory");
        }
    }
}
