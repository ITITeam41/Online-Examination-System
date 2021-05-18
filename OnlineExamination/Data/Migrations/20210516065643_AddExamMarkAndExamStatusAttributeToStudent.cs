using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamination.Data.Migrations
{
    public partial class AddExamMarkAndExamStatusAttributeToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Student",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "examMark",
                table: "Student",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "examStatus",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "examMark",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "examStatus",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
