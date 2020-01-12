using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalGroup.Migrations
{
    public partial class anotherChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Admin");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Admin",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Admin",
                newName: "Roles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Admin",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Roles",
                table: "Admin",
                newName: "Fullname");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Admin",
                nullable: false,
                defaultValue: false);
        }
    }
}
