using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fork_finder.Migrations
{
    public partial class NovoDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Restaurantes_RestauranteId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Restaurantes_RestauranteId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_ClientePerfils_ClientePerfilId",
                table: "Especialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionamentos_Restaurantes_RestauranteId",
                table: "Funcionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_ProdutoCategorias_ProdutoCategoriaId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Restaurantes_RestauranteId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurantes_ClienteComentarios_ClienteComentarioId",
                table: "Restaurantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurantes_Especialidades_EspecialidadeId",
                table: "Restaurantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurantes_ProdutoCategorias_ProdutoCategoriaId",
                table: "Restaurantes");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClienteAvaliacoes");

            migrationBuilder.DropTable(
                name: "ClienteComentarios");

            migrationBuilder.DropTable(
                name: "ClientePerfils");

            migrationBuilder.DropTable(
                name: "ProdutoCategorias");

            migrationBuilder.DropTable(
                name: "RestauranteMesas");

            migrationBuilder.DropTable(
                name: "RestauranteRestauranteFoto");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RestauranteReservas");

            migrationBuilder.DropTable(
                name: "RestauranteFotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurantes",
                table: "Restaurantes");

            migrationBuilder.DropIndex(
                name: "IX_Restaurantes_ClienteComentarioId",
                table: "Restaurantes");

            migrationBuilder.DropIndex(
                name: "IX_Restaurantes_EspecialidadeId",
                table: "Restaurantes");

            migrationBuilder.DropIndex(
                name: "IX_Restaurantes_ProdutoCategoriaId",
                table: "Restaurantes");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_RestauranteId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionamentos",
                table: "Funcionamentos");

            migrationBuilder.DropIndex(
                name: "IX_Funcionamentos_RestauranteId",
                table: "Funcionamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_RestauranteId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "RestauranteId",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "ClienteComentarioId",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "ProdutoCategoriaId",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "RestauranteId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "RestauranteFuncionamentoId",
                table: "Funcionamentos");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeId",
                table: "Restaurantes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClientePerfilId",
                table: "Especialidades",
                newName: "PerfilClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Especialidades_ClientePerfilId",
                table: "Especialidades",
                newName: "IX_Especialidades_PerfilClienteId");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurantes",
                table: "Restaurantes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionamentos",
                table: "Funcionamentos",
                column: "RestauranteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "RestauranteId");

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estrela = table.Column<int>(type: "int", nullable: false),
                    ClienteId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestauranteId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.ClienteId);
                    table.UniqueConstraint("AK_Avaliacoes_RestauranteId", x => x.RestauranteId);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Clientes_ClienteId1",
                        column: x => x.ClienteId1,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Restaurantes_RestauranteId1",
                        column: x => x.RestauranteId1,
                        principalTable: "Restaurantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ProdutoCategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.ProdutoCategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConteudoComentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestauranteId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.ClienteId);
                    table.UniqueConstraint("AK_Comentarios_RestauranteId", x => x.RestauranteId);
                    table.ForeignKey(
                        name: "FK_Comentarios_Clientes_ClienteId1",
                        column: x => x.ClienteId1,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_Restaurantes_RestauranteId1",
                        column: x => x.RestauranteId1,
                        principalTable: "Restaurantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadeRestaurante",
                columns: table => new
                {
                    EspecialidadesEspecialidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadeRestaurante", x => new { x.EspecialidadesEspecialidadeId, x.RestaurantesId });
                    table.ForeignKey(
                        name: "FK_EspecialidadeRestaurante_Especialidades_EspecialidadesEspecialidadeId",
                        column: x => x.EspecialidadesEspecialidadeId,
                        principalTable: "Especialidades",
                        principalColumn: "EspecialidadeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadeRestaurante_Restaurantes_RestaurantesId",
                        column: x => x.RestaurantesId,
                        principalTable: "Restaurantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    RestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FotosRestaurante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestauranteId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.RestauranteId);
                    table.ForeignKey(
                        name: "FK_Fotos_Restaurantes_RestauranteId1",
                        column: x => x.RestauranteId1,
                        principalTable: "Restaurantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuantidadeMesa = table.Column<int>(type: "int", nullable: false),
                    TamanhoMesa = table.Column<int>(type: "int", nullable: false),
                    RestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mesas_Restaurantes_RestauranteId",
                        column: x => x.RestauranteId,
                        principalTable: "Restaurantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perfils",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FotoCliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfils", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Perfils_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataHoraCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacao = table.Column<bool>(type: "bit", nullable: false),
                    MesaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Mesas_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Restaurantes_RestauranteId",
                        column: x => x.RestauranteId,
                        principalTable: "Restaurantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_ClienteId1",
                table: "Avaliacoes",
                column: "ClienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_RestauranteId1",
                table: "Avaliacoes",
                column: "RestauranteId1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaRestaurante_RestaurantesId",
                table: "CategoriaRestaurante",
                column: "RestaurantesId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_ClienteId1",
                table: "Comentarios",
                column: "ClienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_RestauranteId1",
                table: "Comentarios",
                column: "RestauranteId1");

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeRestaurante_RestaurantesId",
                table: "EspecialidadeRestaurante",
                column: "RestaurantesId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_RestauranteId1",
                table: "Fotos",
                column: "RestauranteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_RestauranteId",
                table: "Mesas",
                column: "RestauranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_MesaId",
                table: "Reservas",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_RestauranteId",
                table: "Reservas",
                column: "RestauranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Restaurantes_RestauranteId",
                table: "Clientes",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Restaurantes_RestauranteId",
                table: "Enderecos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Perfils_PerfilClienteId",
                table: "Especialidades",
                column: "PerfilClienteId",
                principalTable: "Perfils",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionamentos_Restaurantes_RestauranteId",
                table: "Funcionamentos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_ProdutoCategoriaId",
                table: "Produtos",
                column: "ProdutoCategoriaId",
                principalTable: "Categorias",
                principalColumn: "ProdutoCategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Restaurantes_RestauranteId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Restaurantes_RestauranteId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Perfils_PerfilClienteId",
                table: "Especialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionamentos_Restaurantes_RestauranteId",
                table: "Funcionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_ProdutoCategoriaId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "CategoriaRestaurante");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "EspecialidadeRestaurante");

            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "Perfils");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurantes",
                table: "Restaurantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionamentos",
                table: "Funcionamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Restaurantes",
                newName: "EspecialidadeId");

            migrationBuilder.RenameColumn(
                name: "PerfilClienteId",
                table: "Especialidades",
                newName: "ClientePerfilId");

            migrationBuilder.RenameIndex(
                name: "IX_Especialidades_PerfilClienteId",
                table: "Especialidades",
                newName: "IX_Especialidades_ClientePerfilId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.AddColumn<Guid>(
                name: "RestauranteId",
                table: "Restaurantes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteComentarioId",
                table: "Restaurantes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoCategoriaId",
                table: "Restaurantes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RestauranteId",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RestauranteFuncionamentoId",
                table: "Funcionamentos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoId",
                table: "Enderecos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurantes",
                table: "Restaurantes",
                column: "RestauranteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionamentos",
                table: "Funcionamentos",
                column: "RestauranteFuncionamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "EnderecoId");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClienteAvaliacoes",
                columns: table => new
                {
                    ClienteAvaliacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estrela = table.Column<int>(type: "int", nullable: false),
                    RestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteAvaliacoes", x => x.ClienteAvaliacaoId);
                    table.ForeignKey(
                        name: "FK_ClienteAvaliacoes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteAvaliacoes_Restaurantes_RestauranteId",
                        column: x => x.RestauranteId,
                        principalTable: "Restaurantes",
                        principalColumn: "RestauranteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteComentarios",
                columns: table => new
                {
                    ClienteComentarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConteudoComentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteComentarios", x => x.ClienteComentarioId);
                    table.ForeignKey(
                        name: "FK_ClienteComentarios_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientePerfils",
                columns: table => new
                {
                    ClientePerfilId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FotoCliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientePerfils", x => x.ClientePerfilId);
                    table.ForeignKey(
                        name: "FK_ClientePerfils_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoCategorias",
                columns: table => new
                {
                    ProdutoCategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCategorias", x => x.ProdutoCategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "RestauranteFotos",
                columns: table => new
                {
                    RestauranteFotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FotosRestaurante = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestauranteFotos", x => x.RestauranteFotoId);
                });

            migrationBuilder.CreateTable(
                name: "RestauranteReservas",
                columns: table => new
                {
                    RestauranteReservaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataHoraCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Situacao = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestauranteReservas", x => x.RestauranteReservaId);
                    table.ForeignKey(
                        name: "FK_RestauranteReservas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestauranteReservas_Restaurantes_RestauranteId",
                        column: x => x.RestauranteId,
                        principalTable: "Restaurantes",
                        principalColumn: "RestauranteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestauranteRestauranteFoto",
                columns: table => new
                {
                    RestauranteFotosRestauranteFotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantesRestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestauranteRestauranteFoto", x => new { x.RestauranteFotosRestauranteFotoId, x.RestaurantesRestauranteId });
                    table.ForeignKey(
                        name: "FK_RestauranteRestauranteFoto_RestauranteFotos_RestauranteFotosRestauranteFotoId",
                        column: x => x.RestauranteFotosRestauranteFotoId,
                        principalTable: "RestauranteFotos",
                        principalColumn: "RestauranteFotoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestauranteRestauranteFoto_Restaurantes_RestaurantesRestauranteId",
                        column: x => x.RestaurantesRestauranteId,
                        principalTable: "Restaurantes",
                        principalColumn: "RestauranteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestauranteMesas",
                columns: table => new
                {
                    RestauranteMesaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuantidadeMesa = table.Column<int>(type: "int", nullable: false),
                    RestauranteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RestauranteReservaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TamanhoMesa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestauranteMesas", x => x.RestauranteMesaId);
                    table.ForeignKey(
                        name: "FK_RestauranteMesas_RestauranteReservas_RestauranteReservaId",
                        column: x => x.RestauranteReservaId,
                        principalTable: "RestauranteReservas",
                        principalColumn: "RestauranteReservaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestauranteMesas_Restaurantes_RestauranteId",
                        column: x => x.RestauranteId,
                        principalTable: "Restaurantes",
                        principalColumn: "RestauranteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurantes_ClienteComentarioId",
                table: "Restaurantes",
                column: "ClienteComentarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurantes_EspecialidadeId",
                table: "Restaurantes",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurantes_ProdutoCategoriaId",
                table: "Restaurantes",
                column: "ProdutoCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_RestauranteId",
                table: "Produtos",
                column: "RestauranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionamentos_RestauranteId",
                table: "Funcionamentos",
                column: "RestauranteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_RestauranteId",
                table: "Enderecos",
                column: "RestauranteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteAvaliacoes_ClienteId",
                table: "ClienteAvaliacoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteAvaliacoes_RestauranteId",
                table: "ClienteAvaliacoes",
                column: "RestauranteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteComentarios_ClienteId",
                table: "ClienteComentarios",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientePerfils_ClienteId",
                table: "ClientePerfils",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestauranteMesas_RestauranteId",
                table: "RestauranteMesas",
                column: "RestauranteId");

            migrationBuilder.CreateIndex(
                name: "IX_RestauranteMesas_RestauranteReservaId",
                table: "RestauranteMesas",
                column: "RestauranteReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_RestauranteReservas_ClienteId",
                table: "RestauranteReservas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_RestauranteReservas_RestauranteId",
                table: "RestauranteReservas",
                column: "RestauranteId");

            migrationBuilder.CreateIndex(
                name: "IX_RestauranteRestauranteFoto_RestaurantesRestauranteId",
                table: "RestauranteRestauranteFoto",
                column: "RestaurantesRestauranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Restaurantes_RestauranteId",
                table: "Clientes",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Restaurantes_RestauranteId",
                table: "Enderecos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_ClientePerfils_ClientePerfilId",
                table: "Especialidades",
                column: "ClientePerfilId",
                principalTable: "ClientePerfils",
                principalColumn: "ClientePerfilId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionamentos_Restaurantes_RestauranteId",
                table: "Funcionamentos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_ProdutoCategorias_ProdutoCategoriaId",
                table: "Produtos",
                column: "ProdutoCategoriaId",
                principalTable: "ProdutoCategorias",
                principalColumn: "ProdutoCategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Restaurantes_RestauranteId",
                table: "Produtos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "RestauranteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurantes_ClienteComentarios_ClienteComentarioId",
                table: "Restaurantes",
                column: "ClienteComentarioId",
                principalTable: "ClienteComentarios",
                principalColumn: "ClienteComentarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurantes_Especialidades_EspecialidadeId",
                table: "Restaurantes",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "EspecialidadeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurantes_ProdutoCategorias_ProdutoCategoriaId",
                table: "Restaurantes",
                column: "ProdutoCategoriaId",
                principalTable: "ProdutoCategorias",
                principalColumn: "ProdutoCategoriaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
