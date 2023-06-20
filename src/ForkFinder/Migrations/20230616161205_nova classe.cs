using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class novaclasse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EspecialidadeId",
                table: "Reservas",
                column: "EspecialidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Especialidades_EspecialidadeId",
                table: "Reservas",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Especialidades_EspecialidadeId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EspecialidadeId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                table: "Reservas");
        }
    }
}
