using Microsoft.EntityFrameworkCore.Migrations;

namespace Mintic.App.Persistencia.Migrations
{
    public partial class TablaNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CicloGrupoId",
                table: "Grupos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ciclo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCiclo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estudianteId = table.Column<int>(type: "int", nullable: true),
                    nota = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Personas_estudianteId",
                        column: x => x.estudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_CicloGrupoId",
                table: "Grupos",
                column: "CicloGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_estudianteId",
                table: "Notas",
                column: "estudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Ciclo_CicloGrupoId",
                table: "Grupos",
                column: "CicloGrupoId",
                principalTable: "Ciclo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Ciclo_CicloGrupoId",
                table: "Grupos");

            migrationBuilder.DropTable(
                name: "Ciclo");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_CicloGrupoId",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "CicloGrupoId",
                table: "Grupos");
        }
    }
}
