using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamination.Data.Migrations
{
    public partial class AddExamStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExamStart",
                table: "Exams",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamStart",
                table: "Exams");
        }
    }
}
