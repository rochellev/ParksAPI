using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class addURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "parks",
                newName: "URL");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "parks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "parks");

            migrationBuilder.RenameColumn(
                name: "URL",
                table: "parks",
                newName: "City");
        }
    }
}
