using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    /// <inheritdoc />
    public partial class ini5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_DoctorUsername",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "DoctorUsername",
                table: "Tasks",
                newName: "UserUsername");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_DoctorUsername",
                table: "Tasks",
                newName: "IX_Tasks_UserUsername");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserUsername",
                table: "Tasks",
                column: "UserUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserUsername",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "UserUsername",
                table: "Tasks",
                newName: "DoctorUsername");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserUsername",
                table: "Tasks",
                newName: "IX_Tasks_DoctorUsername");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_DoctorUsername",
                table: "Tasks",
                column: "DoctorUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
