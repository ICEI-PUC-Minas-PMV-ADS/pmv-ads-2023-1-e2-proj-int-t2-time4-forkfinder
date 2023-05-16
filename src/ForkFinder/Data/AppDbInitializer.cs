using ForkFinder.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ForkFinder.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Restaurantes
                if (!context.Restaurantes.Any())
                {
                    context.Restaurantes.AddRange(new List<Restaurante>()
                    {
                        new Restaurante()
                        {
                            Nome = "Churros Gourmet",
                            CNPJ = "58.337.334/0001-35",
                            FotoPerfil = "https://img.freepik.com/vetores-premium/logotipo-do-restaurante-retro_23-2148474404.jpg?w=2000",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Churros Gourmet"
                        },
                        new Restaurante()
                        {
                            Nome = "Romeu & Juliet Bistrô",
                            CNPJ = "89.743.180/0001-05",
                            FotoPerfil = "https://img.freepik.com/vetores-premium/modelo-de-design-de-logotipo-de-restaurante_79169-56.jpg",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Romeu & Juliet Bistrô"
                        },
                            new Restaurante()
                        {
                            Nome = "Gosto Verde",
                            CNPJ = "95.943.397/0001-61",
                            FotoPerfil = "https://elements-cover-images-0.imgix.net/65db9b50-ecda-464e-aa91-a8196a4352be?auto=compress%2Cformat&fit=max&w=900&s=c1b54c18723a51bc1b2fc5823cca4d45",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Gosto Verde"
                        },
                            new Restaurante()
                        {
                            Nome = "Porco na Brasa",
                            CNPJ = "62.771.119/0001-15",
                            FotoPerfil = "https://blog.agenciadosite.com.br/wp-content/uploads/2017/01/logo-para-restaurante.jpg",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Porco na Brasa"
                        }
                    });
                    context.SaveChanges();
                }
                //Clientes
                if (!context.Clientes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {
                        new Cliente() 
                        {
                        Nome = "Jansem Wallemberg",
                        CPF = "100.133.690-91",
                        Foto = "#"
                        },
                        new Cliente()
                        {
                        Nome = "Natan Fonseca",
                        CPF = "772.521.180-29",
                        Foto = "#"
                        },
                        new Cliente()
                        {
                        Nome = "Wellington Andrade",
                        CPF = "002.289.440-31",
                        Foto = "#"
                        },
                        new Cliente()
                        {
                        Nome = "Neemias Junio",
                        CPF = "587.558.230-84",
                        Foto = "#"
                        },
                        new Cliente()
                        {
                        Nome = "Aabrão da Silva",
                        CPF = "577.613.270-33",
                        Foto = "#"
                        },
                        new Cliente()
                        {
                        Nome = "Pedro Ferreira",
                        CPF = "139.956.700-40",
                        Foto = "#"
                        }
                    });
                    context.SaveChanges();
                }
                //Comentarios
                if (!context.Comentarios.Any())
                {
                    context.Comentarios.AddRange(new List<Comentario>()
                    {
                        new Comentario()
                        {
                            DataCriacao = DateTime.Now.AddDays(-10),
                            ConteudoComentario = "Lorem ipsum volutpat dolor amet purus nibh rutrum phasellus tortor, suspendisse nam suspendisse etiam integer velit luctus. porta inceptos sit aliquet nullam nulla aliquam habitasse, porttitor felis diam dapibus et dictumst turpis, ornare sociosqu integer quis vulputate ut. nunc dolor facilisis vulputate risus cursus in adipiscing nunc donec nulla, tincidunt dui gravida fringilla turpis posuere curabitur mauris hac, augue curabitur quisque vulputate cras sit eu velit praesent. augue risus porttitor netus quisque arcu porta tempus condimentum accumsan sociosqu, tempus donec nunc tortor varius consequat id egestas dolor. sapien habitasse mollis auctor viverra sagittis nisl pulvinar, luctus bibendum nullam volutpat leo. ",
                            ClienteId = 1,
                            RestauranteId = 4
                        },
                        new Comentario()
                        {
                            DataCriacao = DateTime.Now.AddDays(-30),
                            ConteudoComentario = "Lorem ipsum volutpat dolor amet purus nibh rutrum phasellus tortor, suspendisse nam suspendisse etiam integer velit luctus. porta inceptos sit aliquet nullam nulla aliquam habitasse, porttitor felis diam dapibus et dictumst turpis, ornare sociosqu integer quis vulputate ut. nunc dolor facilisis vulputate risus cursus in adipiscing nunc donec nulla, tincidunt dui gravida fringilla turpis posuere curabitur mauris hac, augue curabitur quisque vulputate cras sit eu velit praesent. augue risus porttitor netus quisque arcu porta tempus condimentum accumsan sociosqu, tempus donec nunc tortor varius consequat id egestas dolor. sapien habitasse mollis auctor viverra sagittis nisl pulvinar, luctus bibendum nullam volutpat leo. ",
                            ClienteId = 2,
                            RestauranteId = 3
                        },
                        new Comentario()
                        {
                            DataCriacao = DateTime.Now.AddDays(-2),
                            ConteudoComentario = "Lorem ipsum volutpat dolor amet purus nibh rutrum phasellus tortor, suspendisse nam suspendisse etiam integer velit luctus. porta inceptos sit aliquet nullam nulla aliquam habitasse, porttitor felis diam dapibus et dictumst turpis, ornare sociosqu integer quis vulputate ut. nunc dolor facilisis vulputate risus cursus in adipiscing nunc donec nulla, tincidunt dui gravida fringilla turpis posuere curabitur mauris hac, augue curabitur quisque vulputate cras sit eu velit praesent. augue risus porttitor netus quisque arcu porta tempus condimentum accumsan sociosqu, tempus donec nunc tortor varius consequat id egestas dolor. sapien habitasse mollis auctor viverra sagittis nisl pulvinar, luctus bibendum nullam volutpat leo. ",
                            ClienteId = 3,
                            RestauranteId = 5
                        },
                        new Comentario()
                        {
                            DataCriacao = DateTime.Now.AddDays(-5),
                            ConteudoComentario = "Lorem ipsum volutpat dolor amet purus nibh rutrum phasellus tortor, suspendisse nam suspendisse etiam integer velit luctus. porta inceptos sit aliquet nullam nulla aliquam habitasse, porttitor felis diam dapibus et dictumst turpis, ornare sociosqu integer quis vulputate ut. nunc dolor facilisis vulputate risus cursus in adipiscing nunc donec nulla, tincidunt dui gravida fringilla turpis posuere curabitur mauris hac, augue curabitur quisque vulputate cras sit eu velit praesent. augue risus porttitor netus quisque arcu porta tempus condimentum accumsan sociosqu, tempus donec nunc tortor varius consequat id egestas dolor. sapien habitasse mollis auctor viverra sagittis nisl pulvinar, luctus bibendum nullam volutpat leo. ",
                            ClienteId = 4,
                            RestauranteId = 3
                        }

                    });
                    context.SaveChanges();
                }
                //Enderecos
                if (!context.Enderecos.Any())
                {
                    context.Enderecos.AddRange(new List<Endereco>()
                    {
                        new Endereco() 
                        {
                        Logradouro ="Rua Roberto Paschoal Borgatto",
                        Numero = "959",
                        Complemento = "Loja 2",
                        CEP ="14164-025",
                        Bairro ="Jardim Liberdade",
                        Cidade = "Sertãozinho",
                        Estado = "SP",
                        RestauranteId = 3

                        },
                        new Endereco()
                        {
                        Logradouro ="Rua Maria de Sousa Soares",
                        Numero = "126",
                        Complemento = "Loja 1",
                        CEP ="36300-338",
                        Bairro ="Santa Maria",
                        Cidade = "Sete Lagoas",
                        Estado = "MG",
                        RestauranteId = 4
                        },
                        new Endereco()
                        {
                        Logradouro ="Rua Margem da Ferrovia",
                        Numero = "720",
                        Complemento = "",
                        CEP ="33045-155",
                        Bairro ="Frimisa",
                        Cidade = "Santa Luzia",
                        Estado = "MG",
                        RestauranteId = 5
                        },
                        new Endereco()
                        {
                        Logradouro ="Rua H-1",
                        Numero = "751",
                        Complemento = "20 Andar",
                        CEP ="35024-840",
                        Bairro ="Sir",
                        Cidade = "Governador Valadares",
                        Estado = "MG",
                        RestauranteId = 6
                        }

                    });
                    context.SaveChanges();
                }
                //Especialidades
                if (!context.Especialidades.Any())
                {
                    context.Especialidades.AddRange(new List<Especialidade>()
                    {
                        new Especialidade() 
                        { 
                        NomeEspecialidade = "Brasileira",
                        ImagemUpload = "",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },
                        new Especialidade()
                        {
                        NomeEspecialidade = "Francesa",
                        ImagemUpload = "",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Japonesa",
                        ImagemUpload = "",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },
                        new Especialidade()
                        {
                        NomeEspecialidade = "Árabe",
                        ImagemUpload = "",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Vegana",
                        ImagemUpload = "",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Sobremesa",
                        ImagemUpload = "",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        }

                    });
                    context.SaveChanges();
                }
                //Especialidades_Clientes
                if (!context.Especialidades_Clientes.Any())
                {
                    context.Especialidades_Clientes.AddRange(new List<Especialidade_Cliente>()
                    {
                        new Especialidade_Cliente()
                        {
                            ClienteId = 1,
                            EspecialidadeId = 1
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 1,
                            EspecialidadeId = 2
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 2,
                            EspecialidadeId= 3
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 2,
                            EspecialidadeId = 4
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 3,
                            EspecialidadeId = 5
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 4,
                            EspecialidadeId = 4
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 6,
                            EspecialidadeId = 6
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 5,
                            EspecialidadeId = 6
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 5,
                            EspecialidadeId = 4
                        },
                    });
                    context.SaveChanges();
                }

                /*//Especialidades_Restaurantes
                if (!context.Restaurantes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {

                    });
                }
                //Fotos
                if (!context.Restaurantes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {

                    });

                }
                //Funcionamentos
                if (!context.Restaurantes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {

                    });

                }
                //Mesas
                if (!context.Restaurantes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {

                    });

                }
                //Categorias
                if (!context.Restaurantes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {

                    });

                }
                //Produtos
                if (!context.Restaurantes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {

                    });

                }
                //Reservas
                if (!context.Restaurantes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {

                    });

                }
                //Avaliacoes
                if (!context.Restaurantes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {

                    });

                }*/
            }
        }
    }
}

