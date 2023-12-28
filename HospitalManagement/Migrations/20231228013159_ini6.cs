using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    /// <inheritdoc />
    public partial class ini6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentTypes_AppointmentTypeId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientHSN",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_UserUsername",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentTypeId1",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientHSN1",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AppointmentTypeId1",
                table: "Appointments",
                column: "AppointmentTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientHSN1",
                table: "Appointments",
                column: "PatientHSN1");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Username",
                table: "Appointments",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentTypes_AppointmentTypeId",
                table: "Appointments",
                column: "AppointmentTypeId",
                principalTable: "AppointmentTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentTypes_AppointmentTypeId1",
                table: "Appointments",
                column: "AppointmentTypeId1",
                principalTable: "AppointmentTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientHSN",
                table: "Appointments",
                column: "PatientHSN",
                principalTable: "Patients",
                principalColumn: "HSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientHSN1",
                table: "Appointments",
                column: "PatientHSN1",
                principalTable: "Patients",
                principalColumn: "HSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_UserUsername",
                table: "Appointments",
                column: "UserUsername",
                principalTable: "Users",
                principalColumn: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_Username",
                table: "Appointments",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentTypes_AppointmentTypeId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentTypes_AppointmentTypeId1",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientHSN",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientHSN1",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_UserUsername",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_Username",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_AppointmentTypeId1",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientHSN1",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_Username",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentTypeId1",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PatientHSN1",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Appointments");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentTypes_AppointmentTypeId",
                table: "Appointments",
                column: "AppointmentTypeId",
                principalTable: "AppointmentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientHSN",
                table: "Appointments",
                column: "PatientHSN",
                principalTable: "Patients",
                principalColumn: "HSN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_UserUsername",
                table: "Appointments",
                column: "UserUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
