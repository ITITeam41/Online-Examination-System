using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamination.Data.Migrations
{
    public partial class addquestionAtrributeToQuestionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "question",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "question",
                table: "Questions");
        }
    }
}
