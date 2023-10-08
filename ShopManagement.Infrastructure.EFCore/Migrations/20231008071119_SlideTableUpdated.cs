using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopManagement.Infrastructure.EFCore.Migrations
{
    public partial class SlideTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BtnText",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "Heading",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Slides");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BtnText",
                table: "Slides",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "Slides",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Slides",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Slides",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);
        }
    }
}
