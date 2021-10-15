using Microsoft.EntityFrameworkCore.Migrations;

namespace Mintic.App.Persistencia.Migrations
{
    public partial class ModificacionCicloYGrupo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Ciclo_CicloGrupoId",
                table: "Grupos");

            migrationBuilder.DropTable(
                name: "Ciclo");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_CicloGrupoId",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "CicloGrupoId",
                table: "Grupos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_CicloGrupoId",
                table: "Grupos",
                column: "CicloGrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Ciclo_CicloGrupoId",
                table: "Grupos",
                column: "CicloGrupoId",
                principalTable: "Ciclo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
