using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalGroup.Migrations
{
    public partial class someChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.AddColumn<string>(
                name: "Info_Az",
                table: "WhyChooseUsItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info_Ru",
                table: "WhyChooseUsItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info_Az",
                table: "WhyChooseUsItems");

            migrationBuilder.DropColumn(
                name: "Info_Ru",
                table: "WhyChooseUsItems");

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberFullname = table.Column<string>(nullable: true),
                    MemberInfo = table.Column<string>(nullable: false),
                    MemberInfo_Az = table.Column<string>(nullable: true),
                    MemberInfo_Ru = table.Column<string>(nullable: true),
                    MemberPhoto = table.Column<string>(nullable: true),
                    MemberPosition = table.Column<string>(nullable: false),
                    MemberPosition_Az = table.Column<string>(nullable: true),
                    MemberPosition_Ru = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });
        }
    }
}
