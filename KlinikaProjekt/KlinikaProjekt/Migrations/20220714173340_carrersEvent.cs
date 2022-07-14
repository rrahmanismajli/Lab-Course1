using Microsoft.EntityFrameworkCore.Migrations;

namespace KlinikaProjekt.Migrations
{
    public partial class carrersEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Careers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "image",
                table: "Careers");
        }
    }
}
