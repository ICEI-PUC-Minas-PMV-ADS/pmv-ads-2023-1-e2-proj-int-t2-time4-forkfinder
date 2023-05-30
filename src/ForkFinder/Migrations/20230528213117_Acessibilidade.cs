using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class Acessibilidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Acessibilidade",
                table: "Restaurantes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Avaliacao",
                table: "Restaurantes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Comentario",
                table: "Avaliacoes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acessibilidade",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "Avaliacao",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "Avaliacoes");
        }
    }
}
