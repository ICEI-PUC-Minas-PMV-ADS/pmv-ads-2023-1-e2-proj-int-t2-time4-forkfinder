using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class reservacomnovosatributos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Mesas_MesaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Restaurantes_RestauranteId",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "RestauranteId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_AgendaId",
                table: "Reservas",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Agendas_AgendaId",
                table: "Reservas",
                column: "AgendaId",
                principalTable: "Agendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Mesas_MesaId",
                table: "Reservas",
                column: "MesaId",
                principalTable: "Mesas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Restaurantes_RestauranteId",
                table: "Reservas",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Agendas_AgendaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Mesas_MesaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Restaurantes_RestauranteId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_AgendaId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "RestauranteId",
                table: "Reservas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Mesas_MesaId",
                table: "Reservas",
                column: "MesaId",
                principalTable: "Mesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Restaurantes_RestauranteId",
                table: "Reservas",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
