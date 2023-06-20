using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class _004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Horarios_HorarioId",
                table: "Reservas");

            migrationBuilder.DropTable(
                name: "DataMesas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_HorarioId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "HorarioId",
                table: "Reservas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Hora",
                table: "Horarios",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HorarioId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Hora",
                table: "Horarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "DataMesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgendaId = table.Column<int>(type: "int", nullable: false),
                    DataMesas = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataMesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataMesas_Agendas_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_HorarioId",
                table: "Reservas",
                column: "HorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DataMesas_AgendaId",
                table: "DataMesas",
                column: "AgendaId");

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
