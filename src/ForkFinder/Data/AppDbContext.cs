using ForkFinder.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ForkFinder.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidade_Restaurante>().HasKey(er => new
            {
                er.EspecialidadeId,
                er.RestauranteId
            });
            modelBuilder.Entity<Especialidade_Restaurante>().HasOne(r => r.Restaurante).WithMany(er => er.Especialidades_Restaurantes).HasForeignKey(r => r.RestauranteId);
            modelBuilder.Entity<Especialidade_Restaurante>().HasOne(e => e.Especialidade).WithMany(er => er.Especialidades_Restaurantes).HasForeignKey(e => e.EspecialidadeId);

            modelBuilder.Entity<Especialidade_Cliente>().HasKey(ec => new
            {
                ec.EspecialidadeId,
                ec.ClienteId
            });
            modelBuilder.Entity<Especialidade_Cliente>().HasOne(c => c.Cliente).WithMany(ec => ec.Especialidades_Clientes).HasForeignKey(c => c.ClienteId);
            modelBuilder.Entity<Especialidade_Cliente>().HasOne(e => e.Especialidade).WithMany(ec => ec.Especialidades_Clientes).HasForeignKey(e => e.EspecialidadeId);



            base.OnModelCreating(modelBuilder);
           
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
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Funcionamento> Funcionamentos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Especialidade_Restaurante> Especialidades_Restaurantes { get; set; }
        public DbSet<Especialidade_Cliente> Especialidades_Clientes { get; set; }
    }
}
