using Microsoft.EntityFrameworkCore.Migrations;

namespace KlinikaProjekt.Migrations
{
    public partial class newPharm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Pharmacy");
        }
    }
}
