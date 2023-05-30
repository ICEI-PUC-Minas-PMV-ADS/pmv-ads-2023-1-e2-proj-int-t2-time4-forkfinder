using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fork_finder.Migrations
{
    public partial class M002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Restaurantes_RestauranteId",
                table: "Produtos");

            migrationBuilder.AlterColumn<Guid>(
                name: "RestauranteId",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Restaurantes_RestauranteId",
                table: "Produtos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Restaurantes_RestauranteId",
                table: "Produtos");

            migrationBuilder.AlterColumn<Guid>(
                name: "RestauranteId",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Restaurantes_RestauranteId",
                table: "Produtos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
