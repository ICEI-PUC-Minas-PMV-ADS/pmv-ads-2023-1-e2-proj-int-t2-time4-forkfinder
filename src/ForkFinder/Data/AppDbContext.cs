using ForkFinder.Models;
using ForkFinder.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ForkFinder.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)        {
            
            modelBuilder.Entity<Especialidade_Restaurante>().HasKey(er => new
            {
                er.EspecialidadeId,
                er.RestauranteId
            });

            modelBuilder.Entity<Especialidade_Restaurante>().HasOne(r => r.Restaurante)
                .WithMany(er => er.Especialidades_Restaurantes).HasForeignKey(r => r.RestauranteId);

            modelBuilder.Entity<Especialidade_Restaurante>().HasOne(e => e.Especialidade)
                .WithMany(er => er.Especialidades_Restaurantes).HasForeignKey(e => e.EspecialidadeId);

            modelBuilder.Entity<Especialidade_Cliente>().HasKey(ec => new
            {
                ec.EspecialidadeId,
                ec.ClienteId
            });

            modelBuilder.Entity<Especialidade_Cliente>().HasOne(c => c.Cliente)
                .WithMany(ec => ec.Especialidades_Clientes).HasForeignKey(c => c.ClienteId);

            modelBuilder.Entity<Especialidade_Cliente>().HasOne(e => e.Especialidade)
                .WithMany(ec => ec.Especialidades_Clientes).HasForeignKey(e => e.EspecialidadeId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Models.Agenda> Agendas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Funcionamento> Funcionamentos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Especialidade_Restaurante> Especialidades_Restaurantes { get; set; }
        public DbSet<Especialidade_Cliente> Especialidades_Clientes { get; set; }
    }
}
