using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalGroup.Migrations
{
    public partial class settingsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutPhoto",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "GITphoto",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "MainBannerDesc",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "MainBannerDesc_Az",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "MainBannerDesc_Ru",
                table: "Settings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutPhoto",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GITphoto",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainBannerDesc",
                table: "Settings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainBannerDesc_Az",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainBannerDesc_Ru",
                table: "Settings",
                nullable: true);
        }
    }
}
