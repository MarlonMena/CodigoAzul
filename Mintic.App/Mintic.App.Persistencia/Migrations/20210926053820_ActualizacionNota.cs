using Microsoft.EntityFrameworkCore.Migrations;

namespace Mintic.App.Persistencia.Migrations
{
    public partial class ActualizacionNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Calificacion",
                table: "Notas",
                newName: "Nota5");

            migrationBuilder.AddColumn<double>(
                name: "Nota1",
                table: "Notas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Nota2",
                table: "Notas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Nota3",
                table: "Notas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Nota4",
                table: "Notas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota1",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "Nota2",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "Nota3",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "Nota4",
                table: "Notas");

            migrationBuilder.RenameColumn(
                name: "Nota5",
                table: "Notas",
                newName: "Calificacion");
        }
    }
}
