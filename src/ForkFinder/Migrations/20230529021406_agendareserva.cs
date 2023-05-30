using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class agendareserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Mesas_MesaId",
                table: "Agendas");

            migrationBuilder.RenameColumn(
                name: "MesaId",
                table: "Agendas",
                newName: "ReservaId");

            migrationBuilder.RenameIndex(
                name: "IX_Agendas_MesaId",
                table: "Agendas",
                newName: "IX_Agendas_ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Reservas_ReservaId",
                table: "Agendas",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Reservas_ReservaId",
                table: "Agendas");

            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "Agendas",
                newName: "MesaId");

            migrationBuilder.RenameIndex(
                name: "IX_Agendas_ReservaId",
                table: "Agendas",
                newName: "IX_Agendas_MesaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Mesas_MesaId",
                table: "Agendas",
                column: "MesaId",
                principalTable: "Mesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
