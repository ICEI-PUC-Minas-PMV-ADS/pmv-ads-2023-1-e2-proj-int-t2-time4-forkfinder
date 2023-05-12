using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fork_finder.Migrations
{
    public partial class NovoDbContext002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_ProdutoCategoriaId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "CategoriaRestaurante");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "ProdutoCategoriaId",
                table: "Produtos",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_ProdutoCategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.RenameColumn(
                name: "ProdutoCategoriaId",
                table: "Categorias",
                newName: "RestauranteId");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Categorias",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_RestauranteId",
                table: "Categorias",
                column: "RestauranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Restaurantes_RestauranteId",
                table: "Categorias",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Restaurantes_RestauranteId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_RestauranteId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Produtos",
                newName: "ProdutoCategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_ProdutoCategoriaId");

            migrationBuilder.RenameColumn(
                name: "RestauranteId",
                table: "Categorias",
                newName: "ProdutoCategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "ProdutoCategoriaId");

            migrationBuilder.CreateTable(
                name: "CategoriaRestaurante",
                columns: table => new
                {
                    CategoriasProdutoCategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaRestaurante", x => new { x.CategoriasProdutoCategoriaId, x.RestaurantesId });
                    table.ForeignKey(
                        name: "FK_CategoriaRestaurante_Categorias_CategoriasProdutoCategoriaId",
                        column: x => x.CategoriasProdutoCategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "ProdutoCategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaRestaurante_Restaurantes_RestaurantesId",
                        column: x => x.RestaurantesId,
                        principalTable: "Restaurantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaRestaurante_RestaurantesId",
                table: "CategoriaRestaurante",
                column: "RestaurantesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_ProdutoCategoriaId",
                table: "Produtos",
                column: "ProdutoCategoriaId",
                principalTable: "Categorias",
                principalColumn: "ProdutoCategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
