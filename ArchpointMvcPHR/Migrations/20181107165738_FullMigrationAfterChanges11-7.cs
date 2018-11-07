using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArchpointMvcPHR.Migrations
{
    public partial class FullMigrationAfterChanges117 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "A1CTestRisk",
                columns: table => new
                {
                    A1cTestRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateEntered = table.Column<DateTime>(nullable: false),
                    DateTested = table.Column<DateTime>(nullable: false),
                    A1cTestResults = table.Column<string>(maxLength: 60, nullable: true),
                    A1cTargetRangeGoal = table.Column<string>(maxLength: 60, nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A1CTestRisk", x => x.A1cTestRiskId);
                });

            migrationBuilder.CreateTable(
                name: "AlcoholRisk",
                columns: table => new
                {
                    AlcoholRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DrinkAlc = table.Column<string>(maxLength: 40, nullable: false),
                    DailyDrinkCount = table.Column<string>(nullable: true),
                    WeekendDrinkCount = table.Column<string>(nullable: true),
                    SocialDrinkCount = table.Column<string>(nullable: true),
                    YearsQuitDrinking = table.Column<string>(nullable: true),
                    TreatedForAlcAbuse = table.Column<string>(nullable: true),
                    YearTreated = table.Column<DateTime>(nullable: false),
                    LengthOfTreatment = table.Column<string>(nullable: true),
                    TypeOfTreatment = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlcoholRisk", x => x.AlcoholRiskId);
                });

            migrationBuilder.CreateTable(
                name: "AllergyHistory",
                columns: table => new
                {
                    AllergyHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DrugAllergen = table.Column<string>(maxLength: 80, nullable: false),
                    ContactAllergen = table.Column<string>(maxLength: 80, nullable: false),
                    InsectStingBites = table.Column<string>(maxLength: 80, nullable: false),
                    AirborneInhaledAllergen = table.Column<string>(maxLength: 80, nullable: false),
                    TypeOfReaction = table.Column<string>(maxLength: 80, nullable: false),
                    Severity = table.Column<string>(maxLength: 80, nullable: false),
                    Symptoms = table.Column<string>(maxLength: 80, nullable: false),
                    MedTreatmentRequired = table.Column<string>(maxLength: 80, nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyHistory", x => x.AllergyHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "AsthmaRisk",
                columns: table => new
                {
                    AsthmaRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AsthmaHospitalization = table.Column<string>(maxLength: 60, nullable: false),
                    AsthmaHospitalizationDate = table.Column<DateTime>(nullable: false),
                    AsthmaIcu = table.Column<string>(maxLength: 60, nullable: false),
                    IcuAdmitDate = table.Column<DateTime>(nullable: false),
                    AsthmaTriggers = table.Column<string>(maxLength: 60, nullable: false),
                    AsthmaSymptoms = table.Column<string>(maxLength: 60, nullable: false),
                    AsthmaSeverity = table.Column<string>(maxLength: 60, nullable: false),
                    MedicationForAsthma = table.Column<string>(maxLength: 60, nullable: false),
                    MedicationName = table.Column<string>(maxLength: 60, nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsthmaRisk", x => x.AsthmaRiskId);
                });

            migrationBuilder.CreateTable(
                name: "BloodPressureRisk",
                columns: table => new
                {
                    BloodPressureRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateDateEntered = table.Column<DateTime>(nullable: false),
                    SystolicPressure = table.Column<string>(maxLength: 80, nullable: false),
                    DiastolicPressure = table.Column<string>(maxLength: 80, nullable: false),
                    PulseRate = table.Column<string>(maxLength: 80, nullable: false),
                    DateTaken = table.Column<DateTime>(nullable: false),
                    TimeTaken = table.Column<TimeSpan>(nullable: false),
                    SystolicBpgoal = table.Column<string>(maxLength: 80, nullable: false),
                    DiastolicBpgoal = table.Column<string>(maxLength: 80, nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodPressureRisk", x => x.BloodPressureRiskId);
                });

            migrationBuilder.CreateTable(
                name: "CholesterolRisk",
                columns: table => new
                {
                    CholesterolRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCholTaken = table.Column<DateTime>(nullable: false),
                    TotalCholesterol = table.Column<string>(maxLength: 80, nullable: false),
                    LdlCholesterol = table.Column<string>(maxLength: 80, nullable: false),
                    HdlCholesterol = table.Column<string>(maxLength: 80, nullable: false),
                    Triglycerides = table.Column<string>(maxLength: 80, nullable: false),
                    TakenAfterFasting = table.Column<string>(maxLength: 80, nullable: false),
                    TotalCholGoal = table.Column<string>(nullable: true),
                    LdlCholGoal = table.Column<int>(nullable: false),
                    HdlCholGoal = table.Column<string>(nullable: true),
                    TriglycerideGoal = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CholesterolRisk", x => x.CholesterolRiskId);
                });

            migrationBuilder.CreateTable(
                name: "DiabetesRisk",
                columns: table => new
                {
                    DiabetesRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateTaken = table.Column<DateTime>(nullable: false),
                    LevelBeforeBreakfast = table.Column<string>(maxLength: 100, nullable: true),
                    LevelAfterBreakfast = table.Column<string>(maxLength: 100, nullable: true),
                    LeverlBeforeLunch = table.Column<string>(maxLength: 100, nullable: true),
                    LevelAfterLunch = table.Column<string>(maxLength: 100, nullable: true),
                    LevelBeforeDinner = table.Column<string>(maxLength: 100, nullable: true),
                    LevelAfterDinner = table.Column<string>(maxLength: 100, nullable: true),
                    LevelAtBedtime = table.Column<string>(maxLength: 100, nullable: true),
                    Medications = table.Column<string>(maxLength: 100, nullable: true),
                    TargertGlucoseBeforeMealLow = table.Column<string>(maxLength: 100, nullable: true),
                    TargetGlucoseAfterMealHigh = table.Column<string>(maxLength: 100, nullable: true),
                    TargetGlucoseRangeAfterMealLow = table.Column<string>(maxLength: 100, nullable: true),
                    TargetGlucoseRangeAfterMealHigh = table.Column<string>(maxLength: 100, nullable: true),
                    DateSpan = table.Column<string>(maxLength: 100, nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesRisk", x => x.DiabetesRiskId);
                });

            migrationBuilder.CreateTable(
                name: "DrugUseRisk",
                columns: table => new
                {
                    DrugUseRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecreationalDrugUser = table.Column<string>(maxLength: 60, nullable: false),
                    FrequencyUsed = table.Column<string>(nullable: true),
                    YearsUsed = table.Column<string>(nullable: true),
                    YearsQuit = table.Column<string>(nullable: true),
                    DrugsCausedLifeProblems = table.Column<string>(nullable: true),
                    DrugsCausedProblemsExpl = table.Column<string>(nullable: true),
                    TreatedForDrugAbuse = table.Column<string>(nullable: true),
                    YearTreated = table.Column<DateTime>(nullable: false),
                    TreatmentLength = table.Column<string>(nullable: true),
                    TypeOfTreatment = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugUseRisk", x => x.DrugUseRiskId);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseActivityRisk",
                columns: table => new
                {
                    ExerciseActivityRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnyExercise = table.Column<string>(maxLength: 80, nullable: false),
                    TypeOfExercise = table.Column<string>(nullable: true),
                    FrequencyOfExercise = table.Column<string>(nullable: true),
                    DurationOfExercise = table.Column<string>(nullable: true),
                    IntensityLevel = table.Column<string>(nullable: true),
                    DurationGoal = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseActivityRisk", x => x.ExerciseActivityRiskId);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HowArchpointWasFound = table.Column<string>(nullable: true),
                    EasyToUnderstand = table.Column<string>(nullable: true),
                    SuggestionsForImprovements = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackId);
                });

            migrationBuilder.CreateTable(
                name: "Immunizations",
                columns: table => new
                {
                    ImmunizationsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImmunizationType = table.Column<string>(nullable: true),
                    DateReceived = table.Column<DateTime>(nullable: false),
                    AdministeredBy = table.Column<string>(nullable: true),
                    DateLastTetanus = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immunizations", x => x.ImmunizationsId);
                });

            migrationBuilder.CreateTable(
                name: "MedCareLocation",
                columns: table => new
                {
                    MedCareLocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationStreetAddress = table.Column<string>(nullable: true),
                    LocationCity = table.Column<string>(nullable: true),
                    LocationStateProvince = table.Column<string>(nullable: true),
                    LocationZipCode = table.Column<string>(nullable: true),
                    LocationCountry = table.Column<string>(nullable: true),
                    LocationPhoneNum = table.Column<string>(nullable: true),
                    LocationFax = table.Column<string>(nullable: true),
                    LocationEmail = table.Column<string>(nullable: true),
                    LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedCareLocation", x => x.MedCareLocationId);
                });

            migrationBuilder.CreateTable(
                name: "SmokingHistoryRisk",
                columns: table => new
                {
                    SmokingHistoryRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Smoker = table.Column<string>(maxLength: 20, nullable: false),
                    AgeStarted = table.Column<string>(nullable: true),
                    AgeQuit = table.Column<string>(nullable: true),
                    ChewingSmokelessTobacco = table.Column<string>(nullable: true),
                    QuittingGoal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmokingHistoryRisk", x => x.SmokingHistoryRiskId);
                });

            migrationBuilder.CreateTable(
                name: "StdHistory",
                columns: table => new
                {
                    StdHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StdType = table.Column<string>(nullable: true),
                    StdDateOfDiagnosis = table.Column<DateTime>(nullable: false),
                    StdStatus = table.Column<string>(nullable: true),
                    StdDateResolved = table.Column<DateTime>(nullable: false),
                    StdMedication = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StdHistory", x => x.StdHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "SurgicalHistory",
                columns: table => new
                {
                    SurgicalHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurgeryProcedure = table.Column<string>(maxLength: 80, nullable: false),
                    DateOfSurgeryProcedure = table.Column<DateTime>(nullable: false),
                    MedProviderId = table.Column<string>(maxLength: 80, nullable: false),
                    MedCareLocationId = table.Column<string>(maxLength: 80, nullable: false),
                    ProblemWithAnesthesia = table.Column<string>(maxLength: 80, nullable: false),
                    AnesthesiaProblemExplanation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgicalHistory", x => x.SurgicalHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "TestsExams",
                columns: table => new
                {
                    TestsExamsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestExamType = table.Column<string>(maxLength: 80, nullable: false),
                    TestExamResult = table.Column<string>(maxLength: 80, nullable: false),
                    DateOfTestExam = table.Column<DateTime>(nullable: false),
                    ReaonForTestExam = table.Column<string>(maxLength: 80, nullable: false),
                    MedCareLocationId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestsExams", x => x.TestsExamsId);
                });

            migrationBuilder.CreateTable(
                name: "TravelHealth",
                columns: table => new
                {
                    TravelHealthId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryVisited = table.Column<string>(maxLength: 80, nullable: false),
                    DateVisited = table.Column<DateTime>(nullable: false),
                    DiseaseIllnessContracted = table.Column<string>(maxLength: 80, nullable: false),
                    DateContracted = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelHealth", x => x.TravelHealthId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserFirstName = table.Column<string>(maxLength: 80, nullable: false),
                    UserLastName = table.Column<string>(maxLength: 80, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 80, nullable: false),
                    RelationshipToPatient = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WeightAndMeasurementRisk",
                columns: table => new
                {
                    WeightAndMeasurementRiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Weight = table.Column<string>(nullable: true),
                    DateTaken = table.Column<DateTime>(nullable: false),
                    WeightGoal = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    Bmi = table.Column<string>(nullable: true),
                    CurrentWaistSize = table.Column<string>(nullable: true),
                    WaistSizeGoal = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightAndMeasurementRisk", x => x.WeightAndMeasurementRiskId);
                });

            migrationBuilder.CreateTable(
                name: "WomensHealthHistory",
                columns: table => new
                {
                    WomensHealthHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedCareProviderId = table.Column<int>(nullable: false),
                    DateLastClinicialBreastExam = table.Column<DateTime>(nullable: false),
                    ResultsLastBreastExam = table.Column<string>(nullable: true),
                    DateNextBreastExam = table.Column<DateTime>(nullable: false),
                    DateLastMammogram = table.Column<DateTime>(nullable: false),
                    ResultsLastMammogram = table.Column<string>(nullable: true),
                    DateNextMammogram = table.Column<DateTime>(nullable: false),
                    DateLastPapExam = table.Column<DateTime>(nullable: false),
                    ResultsLastPapExam = table.Column<string>(nullable: true),
                    DateNextPapExam = table.Column<DateTime>(nullable: false),
                    WomensDiseaseDisorder = table.Column<string>(nullable: true),
                    DateOfDiagnosis = table.Column<DateTime>(nullable: false),
                    WomensDiseaseDisorderStatus = table.Column<string>(nullable: true),
                    DateResolved = table.Column<DateTime>(nullable: false),
                    WomensHealthSurgeryProcedure = table.Column<string>(nullable: true),
                    DateOfSurgeryProcedure = table.Column<DateTime>(nullable: false),
                    AgePeriodsStarted = table.Column<int>(nullable: false),
                    PeriodsRegular = table.Column<string>(nullable: true),
                    PeriodProblems = table.Column<string>(nullable: true),
                    PeriodFlow = table.Column<string>(nullable: true),
                    StillHavingPeriods = table.Column<string>(nullable: true),
                    BirthControlMethod = table.Column<string>(nullable: true),
                    HormoneReplacementTherapy = table.Column<string>(nullable: true),
                    HrtDateStarted = table.Column<DateTime>(nullable: false),
                    HrtDateStopped = table.Column<DateTime>(nullable: false),
                    NumOfPregnancies = table.Column<string>(nullable: true),
                    NumOfLiveBirths = table.Column<string>(nullable: true),
                    NumOfPrematureBirths = table.Column<string>(nullable: true),
                    NumOfStillBirths = table.Column<string>(nullable: true),
                    NumOfMiscarriages = table.Column<string>(nullable: true),
                    NumOfCsections = table.Column<string>(nullable: true),
                    NumOfElectiveAbortions = table.Column<string>(nullable: true),
                    PregnancyComplications = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WomensHealthHistory", x => x.WomensHealthHistoryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A1CTestRisk");

            migrationBuilder.DropTable(
                name: "AlcoholRisk");

            migrationBuilder.DropTable(
                name: "AllergyHistory");

            migrationBuilder.DropTable(
                name: "AsthmaRisk");

            migrationBuilder.DropTable(
                name: "BloodPressureRisk");

            migrationBuilder.DropTable(
                name: "CholesterolRisk");

            migrationBuilder.DropTable(
                name: "DiabetesRisk");

            migrationBuilder.DropTable(
                name: "DrugUseRisk");

            migrationBuilder.DropTable(
                name: "ExerciseActivityRisk");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Immunizations");

            migrationBuilder.DropTable(
                name: "MedCareLocation");

            migrationBuilder.DropTable(
                name: "SmokingHistoryRisk");

            migrationBuilder.DropTable(
                name: "StdHistory");

            migrationBuilder.DropTable(
                name: "SurgicalHistory");

            migrationBuilder.DropTable(
                name: "TestsExams");

            migrationBuilder.DropTable(
                name: "TravelHealth");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WeightAndMeasurementRisk");

            migrationBuilder.DropTable(
                name: "WomensHealthHistory");
        }
    }
}
