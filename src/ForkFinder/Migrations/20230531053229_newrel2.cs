using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class newrel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Restaurantes_Avaliacoes_AvaliacaoId",
                table: "Especialidades_Restaurantes");

            migrationBuilder.DropIndex(
                name: "IX_Especialidades_Restaurantes_AvaliacaoId",
                table: "Especialidades_Restaurantes");

            migrationBuilder.DropColumn(
                name: "AvaliacaoId",
                table: "Especialidades_Restaurantes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvaliacaoId",
                table: "Especialidades_Restaurantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_Restaurantes_AvaliacaoId",
                table: "Especialidades_Restaurantes",
                column: "AvaliacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Restaurantes_Avaliacoes_AvaliacaoId",
                table: "Especialidades_Restaurantes",
                column: "AvaliacaoId",
                principalTable: "Avaliacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
