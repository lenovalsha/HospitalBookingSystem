using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    /// <inheritdoc />
    public partial class ini3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_DoctorUsername",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "DoctorUsername",
                table: "Appointments",
                newName: "UserUsername");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorUsername",
                table: "Appointments",
                newName: "IX_Appointments_UserUsername");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_UserUsername",
                table: "Appointments",
                column: "UserUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_UserUsername",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "UserUsername",
                table: "Appointments",
                newName: "DoctorUsername");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_UserUsername",
                table: "Appointments",
                newName: "IX_Appointments_DoctorUsername");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_DoctorUsername",
                table: "Appointments",
                column: "DoctorUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
