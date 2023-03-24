using Microsoft.EntityFrameworkCore.Migrations;

namespace GambiarraBrasil.Migrations
{
    public partial class First2Join : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeTrabalho",
                table: "Artigo");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Artigo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Artigo");

            migrationBuilder.AddColumn<int>(
                name: "TypeTrabalho",
                table: "Artigo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
