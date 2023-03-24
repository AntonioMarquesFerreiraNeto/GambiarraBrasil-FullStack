using Microsoft.EntityFrameworkCore.Migrations;

namespace GambiarraBrasil.Migrations
{
    public partial class FirstJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conteúdo",
                table: "Artigos");

            migrationBuilder.AddColumn<string>(
                name: "Conteudo",
                table: "Artigos",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Artigos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_UsuarioId",
                table: "Artigos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Usuarios_UsuarioId",
                table: "Artigos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Usuarios_UsuarioId",
                table: "Artigos");

            migrationBuilder.DropIndex(
                name: "IX_Artigos_UsuarioId",
                table: "Artigos");

            migrationBuilder.DropColumn(
                name: "Conteudo",
                table: "Artigos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Artigos");

            migrationBuilder.AddColumn<string>(
                name: "Conteúdo",
                table: "Artigos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}
