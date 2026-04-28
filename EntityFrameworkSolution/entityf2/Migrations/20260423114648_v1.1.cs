using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityf2.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "age", "name" },
                values: new object[] { 1, 20, "Tony" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
