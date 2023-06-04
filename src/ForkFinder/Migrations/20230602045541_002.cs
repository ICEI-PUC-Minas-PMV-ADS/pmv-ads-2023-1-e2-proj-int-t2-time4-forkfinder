using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Agendas_AgendaId",
                table: "Horarios");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaId",
                table: "Horarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MesaId",
                table: "Horarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_MesaId",
                table: "Horarios",
                column: "MesaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Agendas_AgendaId",
                table: "Horarios",
                column: "AgendaId",
                principalTable: "Agendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Mesas_MesaId",
                table: "Horarios",
                column: "MesaId",
                principalTable: "Mesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Agendas_AgendaId",
                table: "Horarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Mesas_MesaId",
                table: "Horarios");

            migrationBuilder.DropIndex(
                name: "IX_Horarios_MesaId",
                table: "Horarios");

            migrationBuilder.DropColumn(
                name: "MesaId",
                table: "Horarios");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaId",
                table: "Horarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Agendas_AgendaId",
                table: "Horarios",
                column: "AgendaId",
                principalTable: "Agendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
