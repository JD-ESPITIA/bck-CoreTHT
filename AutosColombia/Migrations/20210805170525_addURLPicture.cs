using Microsoft.EntityFrameworkCore.Migrations;

namespace AutosColombia.Migrations
{
    public partial class addURLPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlPicture",
                table: "Autos",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlPicture",
                table: "Autos");
        }
    }
}
