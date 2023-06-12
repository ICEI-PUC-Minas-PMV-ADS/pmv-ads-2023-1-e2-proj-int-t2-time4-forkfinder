﻿// <auto-generated />
using System;
using ForkFinder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForkFinder.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230612062659_atualização-coluna-situação-reserva")]
    partial class atualizaçãocolunasituaçãoreserva
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForkFinder.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.Property<int?>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MesaId");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("ForkFinder.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

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
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Papel")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

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

                    b.Property<string>("DiaDaSemana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioFim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioInicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteId")
                        .IsUnique();

                    b.ToTable("Funcionamentos");
                });

            modelBuilder.Entity("ForkFinder.Models.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgendaId")
                        .HasColumnType("int");

                    b.Property<bool>("Agendado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("MesaId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("ForkFinder.Models.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Agendada")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("AgendaId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraReserva")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HorarioId")
                        .HasColumnType("int");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.Property<int>("RestauranteId")
                        .HasColumnType("int");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("HorarioId");

                    b.HasIndex("MesaId");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("ForkFinder.Models.Restaurante", b =>
                {
                    b.Property<int>("RestauranteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Acessibilidade")
                        .HasColumnType("bit");

                    b.Property<float>("Avaliacao")
                        .HasColumnType("real");

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoRestaurante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FotoPerfil")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Papel")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestauranteId");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("ForkFinder.Models.Agenda", b =>
                {
                    b.HasOne("ForkFinder.Models.Mesa", "Mesa")
                        .WithMany("Agendas")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Restaurante", null)
                        .WithMany("Agendas")
                        .HasForeignKey("RestauranteId");

                    b.Navigation("Mesa");
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

            modelBuilder.Entity("ForkFinder.Models.Horario", b =>
                {
                    b.HasOne("ForkFinder.Models.Agenda", null)
                        .WithMany("Horarios")
                        .HasForeignKey("AgendaId");

                    b.HasOne("ForkFinder.Models.Mesa", "Mesas")
                        .WithMany("Horarios")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mesas");
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
                    b.HasOne("ForkFinder.Models.Agenda", "Agenda")
                        .WithMany()
                        .HasForeignKey("AgendaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Mesa", "Mesa")
                        .WithMany("Reservas")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ForkFinder.Models.Restaurante", "Restaurante")
                        .WithMany("Reservas")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Agenda");

                    b.Navigation("Cliente");

                    b.Navigation("Horario");

                    b.Navigation("Mesa");

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("ForkFinder.Models.Agenda", b =>
                {
                    b.Navigation("Horarios");
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
                    b.Navigation("Agendas");

                    b.Navigation("Horarios");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("ForkFinder.Models.Restaurante", b =>
                {
                    b.Navigation("Agendas");

                    b.Navigation("Avaliacoes");

                    b.Navigation("Categorias");

                    b.Navigation("Comentarios");

                    b.Navigation("Endereco");

                    b.Navigation("Especialidades_Restaurantes");

                    b.Navigation("Fotos");

                    b.Navigation("Funcionamento");

                    b.Navigation("Mesas");

                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
