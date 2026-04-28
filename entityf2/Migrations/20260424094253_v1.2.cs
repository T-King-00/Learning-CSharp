using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityf2.Migrations
{
    /// <inheritdoc />
    public partial class v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Course",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Course",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Studentid",
                table: "Course",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "id", "Name", "Studentid" },
                values: new object[] { 1, "C#", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 1,
                column: "CourseId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Course_Studentid",
                table: "Course",
                column: "Studentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Students_Studentid",
                table: "Course",
                column: "Studentid",
                principalTable: "Students",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Students_Studentid",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_Studentid",
                table: "Course");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Studentid",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Course",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Course",
                newName: "CourseName");
        }
    }
}
