﻿// <auto-generated />
using System;
using ForkFinder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForkFinder.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForkFinder.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Estrela")
                        .HasColumnType("int");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("ForkFinder.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ForkFinder.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ForkFinder.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("ConteudoComentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("ForkFinder.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ForkFinder.Models.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagemUpload")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEspecialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("ForkFinder.Models.Especialidade_Cliente", b =>
                {
                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.HasKey("EspecialidadeId", "ClienteId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Especialidades_Clientes");
                });

            modelBuilder.Entity("ForkFinder.Models.Especialidade_Restaurante", b =>
                {
                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("int");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("EspecialidadeId", "RestauranteId");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Especialidades_Restaurantes");
                });

            modelBuilder.Entity("ForkFinder.Models.Foto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FotosRestaurante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("ForkFinder.Models.Funcionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DiaDaSemana")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteId")
                        .IsUnique();

                    b.ToTable("Funcionamentos");
                });

            modelBuilder.Entity("ForkFinder.Models.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuantidadeMesa")
                        .HasColumnType("int");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.Property<int>("TamanhoMesa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("ForkFinder.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ForkFinder.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraReserva")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.Property<bool>("Situacao")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MesaId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("ForkFinder.Models.Restaurante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoRestaurante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("ForkFinder.Models.Avaliacao", b =>
                {
                    b.HasOne("ForkFinder.Models.Cliente", "Cliente")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Categoria", b =>
                {
                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithMany("Categorias")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Comentario", b =>
                {
                    b.HasOne("ForkFinder.Models.Cliente", "Cliente")
                        .WithMany("Comentarios")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithMany("Comentarios")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Endereco", b =>
                {
                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithOne("Endereco")
                        .HasForeignKey("ForkFinder.Models.Endereco", "RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Especialidade_Cliente", b =>
                {
                    b.HasOne("ForkFinder.Models.Cliente", "Cliente")
                        .WithMany("Especialidades_Clientes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Especialidade", "Especialidade")
                        .WithMany("Especialidades_Clientes")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Especialidade");
                });

            modelBuilder.Entity("ForkFinder.Models.Especialidade_Restaurante", b =>
                {
                    b.HasOne("ForkFinder.Models.Especialidade", "Especialidade")
                        .WithMany("Especialidades_Restaurantes")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithMany("Especialidades_Restaurantes")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Foto", b =>
                {
                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithMany("Fotos")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Funcionamento", b =>
                {
                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithOne("Funcionamento")
                        .HasForeignKey("ForkFinder.Models.Funcionamento", "RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Mesa", b =>
                {
                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithMany("Mesas")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Produto", b =>
                {
                    b.HasOne("ForkFinder.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("ForkFinder.Models.Reserva", b =>
                {
                    b.HasOne("ForkFinder.Models.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Mesa", "Mesa")
                        .WithMany("Reservas")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("ForkFinder.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ForkFinder.Models.Cliente", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Comentarios");

                    b.Navigation("Especialidades_Clientes");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("ForkFinder.Models.Especialidade", b =>
                {
                    b.Navigation("Especialidades_Clientes");

                    b.Navigation("Especialidades_Restaurantes");
                });

            modelBuilder.Entity("ForkFinder.Models.Mesa", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("ForkFinder.Models.Restaurante", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Categorias");

                    b.Navigation("Comentarios");

                    b.Navigation("Endereco");

                    b.Navigation("Especialidades_Restaurantes");

                    b.Navigation("Fotos");

                    b.Navigation("Funcionamento");

                    b.Navigation("Mesas");
                });
#pragma warning restore 612, 618
        }
    }
}
