using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityf2.Migrations
{
    /// <inheritdoc />
    public partial class v15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseStudent",
                columns: new[] { "Coursesid", "Studentsid" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "Coursesid", "Studentsid" },
                keyValues: new object[] { 1, 1 });
        }
    }
}
