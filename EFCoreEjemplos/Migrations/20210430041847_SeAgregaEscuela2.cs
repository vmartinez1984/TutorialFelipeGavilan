using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreEjemplos.Migrations
{
    public partial class SeAgregaEscuela2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Escuela",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escuela", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_EscuelaId",
                table: "Estudiante",
                column: "EscuelaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Escuela_EscuelaId",
                table: "Estudiante",
                column: "EscuelaId",
                principalTable: "Escuela",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Escuela_EscuelaId",
                table: "Estudiante");

            migrationBuilder.DropTable(
                name: "Escuela");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_EscuelaId",
                table: "Estudiante");
        }
    }
}
