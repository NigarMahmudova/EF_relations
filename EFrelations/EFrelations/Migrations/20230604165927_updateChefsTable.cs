using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFrelations.Migrations
{
    public partial class updateChefsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Chefs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Chefs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Chefs");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Chefs");
        }
    }
}
