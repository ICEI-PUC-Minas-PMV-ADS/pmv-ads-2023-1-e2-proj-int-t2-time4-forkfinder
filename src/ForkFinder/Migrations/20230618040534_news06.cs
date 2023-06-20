using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class news06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Funcionamentos_RestauranteId",
                table: "Funcionamentos");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionamentos_RestauranteId",
                table: "Funcionamentos",
                column: "RestauranteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Funcionamentos_RestauranteId",
                table: "Funcionamentos");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionamentos_RestauranteId",
                table: "Funcionamentos",
                column: "RestauranteId",
                unique: true);
        }
    }
}
