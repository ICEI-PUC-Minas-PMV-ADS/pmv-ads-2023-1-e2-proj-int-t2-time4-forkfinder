using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class newtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Agendas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Restaurantes",
                newName: "RestauranteId");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Mesas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgendaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horarios_Agendas_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_AgendaId",
                table: "Horarios",
                column: "AgendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Mesas");

            migrationBuilder.RenameColumn(
                name: "RestauranteId",
                table: "Restaurantes",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "Agendas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
