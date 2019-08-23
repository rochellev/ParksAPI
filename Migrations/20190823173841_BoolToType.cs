using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class BoolToType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNational",
                table: "parks");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "parks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "parks");

            migrationBuilder.AddColumn<bool>(
                name: "IsNational",
                table: "parks",
                nullable: false,
                defaultValue: false);
        }
    }
}
