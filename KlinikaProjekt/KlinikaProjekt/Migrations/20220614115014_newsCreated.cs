using Microsoft.EntityFrameworkCore.Migrations;

namespace KlinikaProjekt.Migrations
{
    public partial class newsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "message",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "createdDate",
                table: "News",
                newName: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "desc",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "desc",
                table: "News");

            migrationBuilder.DropColumn(
                name: "title",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "datetime",
                table: "News",
                newName: "createdDate");

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "message",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
