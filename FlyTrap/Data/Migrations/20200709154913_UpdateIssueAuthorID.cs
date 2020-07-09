using Microsoft.EntityFrameworkCore.Migrations;

namespace FlyTrap.Data.Migrations
{
    public partial class UpdateIssueAuthorID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Issues",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Issues");
        }
    }
}
