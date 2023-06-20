using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForkFinder.Migrations
{
    public partial class AjusteNomeColunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "DataMesas");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataMesas",
                table: "DataMesas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataMesas",
                table: "DataMesas");

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "DataMesas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
