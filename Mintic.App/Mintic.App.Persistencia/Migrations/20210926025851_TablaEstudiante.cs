using Microsoft.EntityFrameworkCore.Migrations;

namespace Mintic.App.Persistencia.Migrations
{
    public partial class TablaEstudiante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GrupoEstudianteId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotaEstudianteId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_GrupoEstudianteId",
                table: "Personas",
                column: "GrupoEstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NotaEstudianteId",
                table: "Personas",
                column: "NotaEstudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Grupos_GrupoEstudianteId",
                table: "Personas",
                column: "GrupoEstudianteId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Notas_NotaEstudianteId",
                table: "Personas",
                column: "NotaEstudianteId",
                principalTable: "Notas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Grupos_GrupoEstudianteId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Notas_NotaEstudianteId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_GrupoEstudianteId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_NotaEstudianteId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "GrupoEstudianteId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NotaEstudianteId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Personas");
        }
    }
}
