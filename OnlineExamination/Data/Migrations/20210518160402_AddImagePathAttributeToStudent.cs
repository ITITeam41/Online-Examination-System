using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamination.Data.Migrations
{
    public partial class AddImagePathAttributeToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Student");
        }
    }
}
