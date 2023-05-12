using fork_finder.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace fork_finder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>()                
         .HasAlternateKey(c => c.RestauranteId);
            modelBuilder.Entity<Comentario>()
         .HasAlternateKey(c => c.RestauranteId);
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
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Funcionamento> Funcionamentos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
