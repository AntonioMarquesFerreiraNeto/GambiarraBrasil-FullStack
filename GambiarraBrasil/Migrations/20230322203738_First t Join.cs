using Microsoft.EntityFrameworkCore.Migrations;

namespace GambiarraBrasil.Migrations
{
    public partial class FirsttJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Artigo");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaArtigo",
                table: "Artigo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaArtigo",
                table: "Artigo");

            migrationBuilder.AddColumn<int>(
                name: "Categoria",
                table: "Artigo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
