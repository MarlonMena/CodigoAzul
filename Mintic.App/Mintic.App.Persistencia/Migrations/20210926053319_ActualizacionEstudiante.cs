using Microsoft.EntityFrameworkCore.Migrations;

namespace Mintic.App.Persistencia.Migrations
{
    public partial class ActualizacionEstudiante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Personas_estudianteId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Notas_NotaEstudianteId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_NotaEstudianteId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NotaEstudianteId",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "nota",
                table: "Notas",
                newName: "Calificacion");

            migrationBuilder.RenameColumn(
                name: "estudianteId",
                table: "Notas",
                newName: "AlumnoId");

            migrationBuilder.RenameIndex(
                name: "IX_Notas_estudianteId",
                table: "Notas",
                newName: "IX_Notas_AlumnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Personas_AlumnoId",
                table: "Notas",
                column: "AlumnoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Personas_AlumnoId",
                table: "Notas");

            migrationBuilder.RenameColumn(
                name: "Calificacion",
                table: "Notas",
                newName: "nota");

            migrationBuilder.RenameColumn(
                name: "AlumnoId",
                table: "Notas",
                newName: "estudianteId");

            migrationBuilder.RenameIndex(
                name: "IX_Notas_AlumnoId",
                table: "Notas",
                newName: "IX_Notas_estudianteId");

            migrationBuilder.AddColumn<int>(
                name: "NotaEstudianteId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NotaEstudianteId",
                table: "Personas",
                column: "NotaEstudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Personas_estudianteId",
                table: "Notas",
                column: "estudianteId",
                principalTable: "Personas",
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
    }
}
