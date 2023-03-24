using Microsoft.EntityFrameworkCore.Migrations;

namespace GambiarraBrasil.Migrations
{
    public partial class FirsttoJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Usuarios_UsuarioId",
                table: "Artigos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artigos",
                table: "Artigos");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Artigos",
                newName: "Artigo");

            migrationBuilder.RenameIndex(
                name: "IX_Artigos_UsuarioId",
                table: "Artigo",
                newName: "IX_Artigo_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artigo",
                table: "Artigo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Artigo_Usuario_UsuarioId",
                table: "Artigo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artigo_Usuario_UsuarioId",
                table: "Artigo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artigo",
                table: "Artigo");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Artigo",
                newName: "Artigos");

            migrationBuilder.RenameIndex(
                name: "IX_Artigo_UsuarioId",
                table: "Artigos",
                newName: "IX_Artigos_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artigos",
                table: "Artigos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Usuarios_UsuarioId",
                table: "Artigos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
