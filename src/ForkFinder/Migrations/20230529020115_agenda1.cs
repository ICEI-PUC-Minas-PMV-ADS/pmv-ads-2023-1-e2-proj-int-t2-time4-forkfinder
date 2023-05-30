using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class agenda1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MesaId",
                table: "Agendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_MesaId",
                table: "Agendas",
                column: "MesaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Mesas_MesaId",
                table: "Agendas",
                column: "MesaId",
                principalTable: "Mesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Mesas_MesaId",
                table: "Agendas");

            migrationBuilder.DropIndex(
                name: "IX_Agendas_MesaId",
                table: "Agendas");

            migrationBuilder.DropColumn(
                name: "MesaId",
                table: "Agendas");
        }
    }
}
