using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class mesasativa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Restaurantes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "FotoPerfil",
                table: "Restaurantes",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestauranteId",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativa",
                table: "Mesas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_RestauranteId",
                table: "Reservas",
                column: "RestauranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Restaurantes_RestauranteId",
                table: "Reservas",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Restaurantes_RestauranteId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_RestauranteId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "RestauranteId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Ativa",
                table: "Mesas");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Restaurantes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FotoPerfil",
                table: "Restaurantes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
