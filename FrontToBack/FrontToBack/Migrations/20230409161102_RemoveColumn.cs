using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack.Migrations
{
    public partial class RemoveColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountUsers",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Sources",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "SpaceStorage",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "Support",
                table: "Offers",
                newName: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Offers",
                newName: "Support");

            migrationBuilder.AddColumn<string>(
                name: "CountUsers",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sources",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpaceStorage",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
