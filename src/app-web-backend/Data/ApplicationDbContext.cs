using fork_finder.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace fork_finder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Restaurante> Restaurantes { get; set; }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Restaurante>()
                .Property(p => p.Nome)
                .HasMaxLength(80);
            modelBuilder.Entity<Restaurante>().HasData(
                new Restaurante
                {
                    RestauranteId = Guid.NewGuid(),
                    CNPJ = "xxxxxxxx",
                    FotoPerfil = "imagem1.jpg",
                    Nome = "Restaurante do João",
                    DescricaoRestaurante = "Restaurante do João descrição",
                    Email = "email@teste.com",
                    Senha = "Senha123@",
                    Telefone = 99999999,
                    Idioma = "Portugues",
                    Papel = 0,
                    CreateDate = DateTime.Now

                });
        }*/
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteAvaliacao> ClienteAvaliacoes { get; set; }
        public DbSet<ClientePerfil> ClientePerfils { get; set; }
        public DbSet<ClienteComentario> ClienteComentarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCategoria> ProdutoCategorias { get; set; }
        public DbSet<RestauranteFoto> RestauranteFotos { get; set; }
        public DbSet<RestauranteFuncionamento> RestauranteFuncionamentos { get; set; }
        public DbSet<RestauranteMesa> RestauranteMesas { get; set; }
        public DbSet<RestauranteReserva> RestauranteReservas { get; set; }
    }
}
