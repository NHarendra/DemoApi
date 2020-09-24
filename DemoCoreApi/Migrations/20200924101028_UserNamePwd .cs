using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoCoreApi.Migrations
{
    public partial class UserNamePwd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "authors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "authors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "authors");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "authors");
        }
    }
}
