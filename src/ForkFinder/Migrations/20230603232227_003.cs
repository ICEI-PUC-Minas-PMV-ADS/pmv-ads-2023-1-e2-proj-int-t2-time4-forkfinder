using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class _003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HorarioId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_HorarioId",
                table: "Reservas",
                column: "HorarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Horarios_HorarioId",
                table: "Reservas",
                column: "HorarioId",
                principalTable: "Horarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Horarios_HorarioId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_HorarioId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "HorarioId",
                table: "Reservas");
        }
    }
}
