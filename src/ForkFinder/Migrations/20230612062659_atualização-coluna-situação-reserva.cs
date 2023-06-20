using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class atualizaçãocolunasituaçãoreserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Agendas_AgendaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Horarios_HorarioId",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "Situacao",
                table: "Reservas",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Agendas_AgendaId",
                table: "Reservas",
                column: "AgendaId",
                principalTable: "Agendas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Horarios_HorarioId",
                table: "Reservas",
                column: "HorarioId",
                principalTable: "Horarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Agendas_AgendaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Horarios_HorarioId",
                table: "Reservas");

            migrationBuilder.AlterColumn<bool>(
                name: "Situacao",
                table: "Reservas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Agendas_AgendaId",
                table: "Reservas",
                column: "AgendaId",
                principalTable: "Agendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Horarios_HorarioId",
                table: "Reservas",
                column: "HorarioId",
                principalTable: "Horarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
