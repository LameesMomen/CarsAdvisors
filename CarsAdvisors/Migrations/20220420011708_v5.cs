using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsAdvisors.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "News_Reviews");

            migrationBuilder.DropColumn(
                name: "Poster",
                table: "News_Reviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "News_Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "News_Reviews",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
