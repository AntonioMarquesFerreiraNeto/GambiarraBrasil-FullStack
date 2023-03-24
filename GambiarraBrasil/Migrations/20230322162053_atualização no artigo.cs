using Microsoft.EntityFrameworkCore.Migrations;

namespace GambiarraBrasil.Migrations
{
    public partial class atualizaçãonoartigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeTrabalho",
                table: "Artigos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeTrabalho",
                table: "Artigos");
        }
    }
}
