using Microsoft.EntityFrameworkCore.Migrations;

namespace ArchpointMvcPHR.Migrations
{
    public partial class FullMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "PersonalInfo",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "MedicalProvider",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "MedicalHistory",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "FamilyHistory",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "FamilyHistory",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "FamilyHistory",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Employment",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "EmployerName",
                table: "Employment",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Employment",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employment",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "HomePhone",
                table: "EmergencyContact",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EveningPhone",
                table: "EmergencyContact",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactStreetAddress",
                table: "EmergencyContact",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactEmail",
                table: "EmergencyContact",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactCity",
                table: "EmergencyContact",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "CellPhone",
                table: "EmergencyContact",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "DoctorAppointment",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Fax",
                table: "DoctorAppointment",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "DoctorAppointment",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "PersonalInfo",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "MedicalProvider",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "MedicalHistory",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "FamilyHistory",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "FamilyHistory",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "FamilyHistory",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Employment",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "EmployerName",
                table: "Employment",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Employment",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employment",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "HomePhone",
                table: "EmergencyContact",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EveningPhone",
                table: "EmergencyContact",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactStreetAddress",
                table: "EmergencyContact",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactEmail",
                table: "EmergencyContact",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactCity",
                table: "EmergencyContact",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CellPhone",
                table: "EmergencyContact",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "DoctorAppointment",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Fax",
                table: "DoctorAppointment",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "DoctorAppointment",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
