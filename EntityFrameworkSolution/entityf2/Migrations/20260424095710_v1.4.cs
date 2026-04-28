using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityf2.Migrations
{
    /// <inheritdoc />
    public partial class v14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Students_Studentid",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_Studentid",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Studentid",
                table: "Course");

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    Coursesid = table.Column<int>(type: "INTEGER", nullable: false),
                    Studentsid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.Coursesid, x.Studentsid });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Course_Coursesid",
                        column: x => x.Coursesid,
                        principalTable: "Course",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_Studentsid",
                        column: x => x.Studentsid,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_Studentsid",
                table: "CourseStudent",
                column: "Studentsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

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

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "id",
                keyValue: 1,
                column: "Studentid",
                value: null);

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
    }
}
