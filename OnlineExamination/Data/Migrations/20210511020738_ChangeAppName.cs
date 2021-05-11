using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamination.Data.Migrations
{
    public partial class ChangeAppName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "AspNetUsers",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "NAME");
        }
    }
}
