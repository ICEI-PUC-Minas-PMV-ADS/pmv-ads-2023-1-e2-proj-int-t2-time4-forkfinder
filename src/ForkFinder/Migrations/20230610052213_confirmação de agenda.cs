using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class confirmaçãodeagenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ativa",
                table: "Mesas",
                newName: "Agendada");

            migrationBuilder.AddColumn<int>(
                name: "HorarioId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Agendado",
                table: "Horarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.DropColumn(
                name: "Agendado",
                table: "Horarios");

            migrationBuilder.RenameColumn(
                name: "Agendada",
                table: "Mesas",
                newName: "Ativa");
        }
    }
}
