using ForkFinder.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

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
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "58.337.334/0001-35",
                            FotoPerfil = "https://img.freepik.com/vetores-premium/logotipo-do-restaurante-retro_23-2148474404.jpg?w=2000",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Churros Gourmet"
                        },
                        new Restaurante()
                        {
                            Nome = "Romeu & Juliet Bistrô",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "89.743.180/0001-05",
                            FotoPerfil = "https://img.freepik.com/vetores-premium/modelo-de-design-de-logotipo-de-restaurante_79169-56.jpg",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Romeu & Juliet Bistrô"
                        },
                            new Restaurante()
                        {
                            Nome = "Gosto Verde",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "95.943.397/0001-61",
                            FotoPerfil = "https://elements-cover-images-0.imgix.net/65db9b50-ecda-464e-aa91-a8196a4352be?auto=compress%2Cformat&fit=max&w=900&s=c1b54c18723a51bc1b2fc5823cca4d45",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Gosto Verde"
                        },
                            new Restaurante()
                        {
                            Nome = "Porco na Brasa",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "62.771.119/0001-15",
                            FotoPerfil = "https://blog.agenciadosite.com.br/wp-content/uploads/2017/01/logo-para-restaurante.jpg",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Porco na Brasa"
                        },
                            new Restaurante()
                        {
                            Nome = "Nau Frutos do Mar",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "09.509.467/0001-36",
                            FotoPerfil = "https://static.ifood-static.com.br/image/upload/t_medium/logosgde/06788a08-428b-4130-9d2c-b9e79725708e/202005281440_bTNt_.jpeg",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Nau Frutos do Mar"
                        },
                            new Restaurante()
                        {
                            Nome = "Mangai Comida Regional",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "49.040.769/0001-22",
                            FotoPerfil = "https://scontent.fjpa11-1.fna.fbcdn.net/v/t1.6435-9/60343892_2160827287327350_7286930952792571904_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=174925&_nc_ohc=zsMwXpUuvd4AX_tOPnY&_nc_ht=scontent.fjpa11-1.fna&oh=00_AfAdl2fABphiFftPkxLUw4f4IX_NX66sdmR-rQym-6qWCQ&oe=648AE71B",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Mangai Comida Regional"
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
                        Foto = "#",
                        Email = "#",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Natan Fonseca",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "772.521.180-29",
                        Foto = "#",
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Wellington Andrade",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "002.289.440-31",
                        Foto = "#",
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Neemias Junio",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "587.558.230-84",
                        Foto = "#",
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Aabrão da Silva",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "577.613.270-33",
                        Foto = "#",
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Pedro Ferreira",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "139.956.700-40",
                        Foto = "#",
                        Papel = 0
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
                            RestauranteId = 1
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
                        RestauranteId = 1

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
                        RestauranteId = 2
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
                        RestauranteId = 3
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
                        RestauranteId = 4
                        },
                        new Endereco()
                        {
                        Logradouro ="Rua Wagner Melo Mendes",
                        Numero = "532",
                        Complemento = "",
                        CEP ="31620-265",
                        Bairro ="Europa",
                        Cidade = "Belo Horizonte",
                        Estado = "MG",
                        RestauranteId = 5
                        },
                        new Endereco()
                        {
                        Logradouro ="Travessa Odilon Cristaldo",
                        Numero = "934",
                        Complemento = "",
                        CEP ="38303-235",
                        Bairro ="Residencial Portal dos Ipês",
                        Cidade = "Ituiutaba",
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
                        ImagemUpload = "./img/especialidade/Brasileira.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },
                        new Especialidade()
                        {
                        NomeEspecialidade = "Francesa",
                        ImagemUpload = "./img/especialidade/Francesa.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Japonesa",
                        ImagemUpload = "./img/especialidade/Japonesa.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },
                        new Especialidade()
                        {
                        NomeEspecialidade = "Árabe",
                        ImagemUpload = "./img/especialidade/Arabe.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Vegetariana",
                        ImagemUpload = "./img/especialidade/Vegetariana.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Mexicana",
                        ImagemUpload = "./img/especialidade/Mexicana.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Indiana",
                        ImagemUpload = "./img/especialidade/Indiana.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Sobremesa",
                        ImagemUpload = "./img/especialidade/Sobremesa.png",
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
                        }
                    });
                    context.SaveChanges();
                }

                //Especialidades_Restaurantes
                if (!context.Especialidades_Restaurantes.Any())
                {
                    context.Especialidades_Restaurantes.AddRange(new List<Especialidade_Restaurante>()
                    {
                        new Especialidade_Restaurante ()
                        {
                            RestauranteId= 1,
                            EspecialidadeId= 6
                        },
                         new Especialidade_Restaurante ()
                        {
                            RestauranteId= 2,
                            EspecialidadeId= 6
                        },
                          new Especialidade_Restaurante ()
                        {
                            RestauranteId= 3,
                            EspecialidadeId= 5
                        },
                           new Especialidade_Restaurante ()
                        {
                            RestauranteId= 4,
                            EspecialidadeId= 4
                        },
                            new Especialidade_Restaurante ()
                        {
                            RestauranteId= 5,
                            EspecialidadeId= 3
                        },
                             new Especialidade_Restaurante ()
                        {
                            RestauranteId= 6,
                            EspecialidadeId= 4
                        }
                    });
                    context.SaveChanges();
                }
                //Fotos
                if (!context.Fotos.Any())
                {
                    context.Fotos.AddRange(new List<Foto>()
                    {
                        new Foto ()
                        {
                            FotosRestaurante="https://cozil.com.br/wp-content/uploads/2019/05/restaurant-237060_1920-1920x960.jpg",
                            RestauranteId= 1
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://casamadeira.com.br/wp-content/uploads/2019/11/restaurante-interno.jpg",
                            RestauranteId= 1
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://thumbs.dreamstime.com/z/restaurante-moderno-44120392.jpg",
                            RestauranteId= 2
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSaG3qrtk62_8O49RB4gV0H6Wn-P5SEa4CU9w&usqp=CAU",
                            RestauranteId= 2
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgwKEKwWYmWmawJgiR-fwFZkDX_teisTcU3Q&usqp=CAU",
                            RestauranteId= 3
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCBOA8nLIUTkIUgsdDEJS94jIcXNgYGHaRbg&usqp=CAU",
                            RestauranteId= 3
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYISfUnpEw948HYm0oEOxeWJNvzbnxz0gzzQ&usqp=CAU",
                            RestauranteId= 4
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQN1_UgkzKax9FKe7qS1Jc5VDoFmqKh6jKNPQ&usqp=CAU",
                            RestauranteId= 4
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTD4ia9WPK2g-IQolxHZ1VSpXMaTcQYPZCPsQ&usqp=CAU",
                            RestauranteId= 5
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeQT8uQFgJENQeOqCuKtPEWAZvhamFHVTHDg&usqp=CAU",
                            RestauranteId= 5
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvOZb9VWK1UAInokxAJKzkm_7UOBy2rmsBpw&usqp=CAU",
                            RestauranteId= 6
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2Z03FK_JJ3b34AV6bngt5blnxFVdW7RTCZA&usqp=CAU",
                            RestauranteId= 6
                        }
                    });
                    context.SaveChanges();
                }
                //Funcionamentos
                if (!context.Funcionamentos.Any())
                {
                    context.Funcionamentos.AddRange(new List<Funcionamento>()
                    { 
                        //restaurante 1//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 1
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 1
                        },
                       
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 1
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 1
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 1
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 1
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 1
                        },
                        //restaurante 2//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 2
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 2
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 2
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 2
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 2
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 2
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 2
                        },

                        //restaurante 3//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 3
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 3
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 3
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 3
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 3
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 3
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 3
                        },

                         //restaurante 4//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 4
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 4
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 4
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 4
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 4
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 4
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 4
                        },

                        //restaurante 5//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 5
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 5
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 5
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 5
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 5
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 5
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 5
                        },

                        //restaurante 6//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 6
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 6
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 6
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 6
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 6
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 6
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 6
                        }
                    });
                    context.SaveChanges();
                }
                //Mesas
                if (!context.Mesas.Any())
                {
                    context.Mesas.AddRange(new List<Mesa>()
                    {
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 4,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 6,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 8,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 7,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 5,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 15,
                            TamanhoMesa= 8,
                            RestauranteId= 2
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 20,
                            TamanhoMesa= 4,
                            RestauranteId= 3
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 18,
                            TamanhoMesa= 6,
                            RestauranteId= 4
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 30,
                            TamanhoMesa= 4,
                            RestauranteId= 5
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 18,
                            TamanhoMesa= 4,
                            RestauranteId= 6
                        }
                    });
                    context.SaveChanges();
                }
                //Categorias
                if (!context.Categorias.Any())
                {
                    context.Categorias.AddRange(new List<Categoria>()
                    {
                       new Categoria ()
                       {
                           Nome= "Carnes",
                           Descricao= "Lorem",
                           Imagem="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHuo1uPfHiVfXuFYi7ae4SAFBy7N3EtBE6Gg&usqp=CAU",
                           RestauranteId= 6
                       },
                       new Categoria ()
                       {
                           Nome= "Frango",
                           Descricao= "Lorem",
                           Imagem="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDqnOUQ4wl8VajsPGN_kudMlVbkIK-RCTlJQ&usqp=CAU",
                           RestauranteId= 6
                       }
                    });
                    context.SaveChanges();
                }
                //Produtos
                if (!context.Produtos.Any())
                {
                    context.Produtos.AddRange(new List<Produto>()
                    {
                        new Produto ()
                        {
                            NomeProduto="Filé ao Molho Madeira",
                            Descricao="Arroz branco, filé mignon de 120g, molho madeira a base de vinho madeira e fritas",
                            Imagem="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvmpTEuV1BwiYkzFYG5H6TZNF43165l7HUig&usqp=CAU",
                            Preco= 60,
                            CategoriaId= 1
                        },
                         new Produto ()
                        {
                            NomeProduto="Boeuf Bourguignon",
                            Descricao="Receita clássica francesa, a carne é cortada em cubos marinada e cozida com vegetais e vinho tinto",
                            Imagem="http://winechef.com.br/wp-content/uploads/2014/06/Boeuf-Bourguignon.jpg",
                            Preco= 62,
                            CategoriaId= 1
                        },
                          new Produto ()
                        {
                            NomeProduto="Tournedo ao vinho Tinto",
                            Descricao="Tournedo de filé mignon, sobre cebolas caramelizadas em mel e ao vinho tinto Syrah.",
                            Imagem="http://winechef.com.br/wp-content/uploads/2014/06/Tournedo-com-Caramelo-de-Syrah1-1030x696.jpg",
                            Preco= 63,
                            CategoriaId= 1
                        },
                          new Produto ()
                        {
                            NomeProduto="Frango Mole Poblano",
                            Descricao="Prato tradicional do México, com molho feito com pimentas, ervas, oleaginosas e o docinho do chocolate",
                            Imagem="https://www.lechef.com.br/wp-content/uploads/2022/04/mole-poblano.jpg",
                            Preco= 55,
                            CategoriaId= 2
                        },
                          new Produto ()
                        {
                            NomeProduto="Frango Kiev",
                            Descricao="Prato típico da Ucrânia, peito de frango desossado que é recheado, tradicionalmente, com manteiga e ervas",
                            Imagem="https://www.hojetemfrango.com.br/wp-content/uploads/2019/03/shutterstock_1032711094.jpg",
                            Preco= 53,
                            CategoriaId= 2
                        },
                          new Produto ()
                        {
                            NomeProduto="Frango Tikka Masala",
                            Descricao="Prato típico da Índia, pedaços de frango servidos com um molho à base de curry que é cremoso, temperado e avermelhado",
                            Imagem="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQaN3eX3C1UgTegM3ZPeWH23ShRA65PhC0UA&usqp=CAU",
                            Preco= 50,
                            CategoriaId= 2
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de Doce de Leite",
                            Descricao="Churros crocante com muito doce de leite",
                            Imagem="https://www.kitano.com.br/wp-content/uploads/2019/07/SSP_2398-Churros-de-doce-de-leite-e-canela-1.jpg",
                            Preco= 7,
                            CategoriaId= 3
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de Chocolate",
                            Descricao="Churros crocante com muito chocolate",
                            Imagem="https://cdn0.tudoreceitas.com/pt/posts/9/0/2/churros_recheados_com_brigadeiro_6209_600.webp",
                            Preco= 7,
                            CategoriaId= 3
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de Chocolate",
                            Descricao="Churros crocante com muito chocolate",
                            Imagem="https://cdn0.tudoreceitas.com/pt/posts/9/0/2/churros_recheados_com_brigadeiro_6209_600.webp",
                            Preco= 7,
                            CategoriaId= 3
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de goiabada",
                            Descricao="Churros crocante com muita goiabada",
                            Imagem="https://static.ifood-static.com.br/image/upload/t_medium/pratos/c6e457eb-94f7-48b5-9902-ab7b9e771199/202003301851_rMxB_g.jpg",
                            Preco= 7,
                            CategoriaId= 3
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de nutella",
                            Descricao="Churros crocante com muita nutella",
                            Imagem="https://receitinhas.com.br/wp-content/uploads/2022/09/13962742_1662642220724015_7605727635270355408_n-730x365.jpg",
                            Preco= 10,
                            CategoriaId= 3
                        },
                           new Produto ()
                        {
                            NomeProduto="Café com leite",
                            Descricao="quente e cremoso",
                            Imagem="https://tudodereceitas.com.br/wp-content/uploads/2022/08/Cafe-com-leite-cremoso.jpg",
                            Preco= 10,
                            CategoriaId= 4
                        },
                           new Produto ()
                        {
                            NomeProduto="Capuccino",
                            Descricao="muito cremoso",
                            Imagem="https://images.tcdn.com.br/img/img_prod/832328/essencia_capuccino_express_2059_1_a11a826a0e884836ac931260a0a6885a.jpg",
                            Preco= 10,
                            CategoriaId= 4
                        },
                           new Produto ()
                        {
                            NomeProduto="Café expresso",
                            Descricao="tradicional",
                            Imagem="https://loucodocafe.com.br/wp-content/uploads/2019/09/cafe-expresso-02-e1568084083582-810x456.jpg",
                            Preco= 5,
                            CategoriaId= 4
                        },
                            new Produto ()
                        {
                            NomeProduto="Café com nutella",
                            Descricao="café com deliciosa cobertura de nutella",
                            Imagem="https://www.rbsdirect.com.br/imagesrc/23490969.jpg?w=600",
                            Preco= 15,
                            CategoriaId= 4
                        },
                            new Produto ()
                        {
                            NomeProduto="Café com chantilly",
                            Descricao="café com deliciosa cobertura de chantilly",
                            Imagem="https://cafemorrogrande.com.br/img/noticias/g_cafe-vienense.jpeg",
                            Preco= 15,
                            CategoriaId= 4
                        },
                            new Produto ()
                        {
                            NomeProduto="Croissantt",
                            Descricao="Delicioso Croissantt",
                            Imagem="https://images.tcdn.com.br/img/img_prod/795791/croissant_artesanal_desfrute_do_sabor_frances_autentico_com_o_caminho_da_fazenda_347_1_d5980fbd4efb6408726616175b2e7731.jpg",
                            Preco= 15,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Coxinha",
                            Descricao="Deliciosa Coxinha de frango com requeijão",
                            Imagem="https://p2.trrsf.com/image/fget/cf/774/0/images.terra.com/2021/04/13/555044719-passo-a-passo-delicioso-de-como-fazer-massa-de-coxinha-fonte-pixabay-800x800.jpg",
                            Preco= 10,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Pão de Queijo",
                            Descricao="Delicioso Pão de Queijo",
                            Imagem="https://vovopalmirinha.com.br/wp-content/uploads/2019/06/pao-de-queijo-702x336.jpg",
                            Preco= 8,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Misto Quente",
                            Descricao="Delicioso Misto Quente",
                            Imagem="https://2.bp.blogspot.com/-n0BRuB8rVnM/Wwv2pb63PcI/AAAAAAAAM_E/gYTFlGH39zg95nDYtdwPteKhFc8vocccgCLcBGAs/s640/misto-quente-receita-1.jpeg",
                            Preco= 18,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Pastel de Forno",
                            Descricao="Delicioso Pastel de Forno de frango",
                            Imagem="https://www.sabornamesa.com.br/media/k2/items/cache/73cfa97422fce7916e3facf08ef108b3_XL.jpg",
                            Preco= 17,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Salada de Legumes",
                            Descricao="Deliciosa Salada de Legumes fresco",
                            Imagem="https://img.cybercook.com.br/receitas/960/salada-colorida-de-legumes-2-840x480.jpeg?q=75",
                            Preco= 30,
                            CategoriaId= 6
                        },
                            new Produto ()
                        {
                            NomeProduto="Salada de Frango",
                            Descricao="Deliciosa Salada de frango com legumes",
                            Imagem="https://receitanatureba.com/wp-content/uploads/2020/09/Salada-com-Frango-Desfiado.jpg.webp",
                            Preco= 38,
                            CategoriaId= 6
                        },
                            new Produto ()
                        {
                            NomeProduto="Salada de Rucula com manga",
                            Descricao="Deliciosa Salada de Rucula com manga",
                            Imagem="https://img.cybercook.com.br/receitas/725/salada-tropical-com-rucula-840x480.jpeg?q=75",
                            Preco= 36,
                            CategoriaId= 6
                        },
                            new Produto ()
                        {
                            NomeProduto="Salada de Palmito",
                            Descricao="Deliciosa Salada de palmito",
                            Imagem="https://img-global.cpcdn.com/recipes/b675290f0bd9d0f5/680x482cq70/foto-principal-da-receita-queen-and-slim-salada-mix-de-folhas-tomate-e-palmito.jpg",
                            Preco= 32,
                            CategoriaId= 6
                        },
                            new Produto ()
                        {
                            NomeProduto="Pernil de porco",
                            Descricao="Delicioso Pernil de porco assado na brasa com farofa",
                            Imagem="https://www.engeplus.com.br/cache/noticia/gastronomia/2012/sugestao-para-a-ceia-de-reveillon-pernil-suino-assado-na-brasa/sugestao-para-a-ceia-de-reveillon-pernil-suino-assado-na-brasa.jpg?t=20130924140648",
                            Preco= 45,
                            CategoriaId= 7
                        },
                            new Produto ()
                        {
                            NomeProduto="Costela de porco",
                            Descricao="Delicioso Costela de porco assado na brasa com farofa",
                            Imagem="https://img.freepik.com/fotos-premium/costelinha-de-porco-na-brasa-para-cozinhar-carvoes-carne-fresca-de-porco-cozida-no-carvao-refeicao-caseira-de-verao-costelas-grelhadas_548821-10948.jpg?w=2000",
                            Preco= 42,
                            CategoriaId= 7
                        },
                            new Produto ()
                        {
                            NomeProduto="Linguiça de porco",
                            Descricao="Deliciosa Linguiça de porco assado na brasa com farofa",
                            Imagem="https://conteudo.imguol.com.br/c/entretenimento/a5/2020/11/23/linguica-inteira-mantem-a-suculencia-mas-na-pressa-pode-ser-cortada-na-metade-1606137185589_v2_1170x540.jpg",
                            Preco= 30,
                            CategoriaId= 7
                        },
                            new Produto ()
                        {
                            NomeProduto="Moqueca de Camarão",
                            Descricao="Deliciosa moqueca de camarão",
                            Imagem="https://p2.trrsf.com/image/fget/cf/774/0/images.terra.com/2020/11/02/caldeirada-frutos-do-mar-1-768x512.jpg",
                            Preco= 55,
                            CategoriaId= 8
                        },
                            new Produto ()
                        {
                            NomeProduto="Risoto de Camarão",
                            Descricao="Delicioso Risoto de camarão",
                            Imagem="https://www.guiadasemana.com.br/contentFiles/image/opt_w768h768/2018/09/FEA/57977_shutterstock-1026870838.jpg",
                            Preco= 55,
                            CategoriaId= 8
                        },
                            new Produto ()
                        {
                            NomeProduto="Risoto de Mexilhão",
                            Descricao="Delicioso Risoto de Mexilhão",
                            Imagem="https://marettimo.com.br/blog/wp-content/uploads/2019/05/frutos-do-mar-1.jpg",
                            Preco= 55,
                            CategoriaId= 8
                        },
                            new Produto ()
                        {
                            NomeProduto="Lula grelhada",
                            Descricao="Deliciosa Lula Grelhada",
                            Imagem="https://www.anchieta.es.gov.br/uploads/filemanager/Festival%20Capixaba%20de%20Frutos%20do%20Mar/6a180a0c-dd87-499e-a5d8-3ce95c5216fe.jpg?1538741404970",
                            Preco= 62,
                            CategoriaId= 8
                        },
                            new Produto ()
                        {
                            NomeProduto="Lagosta na brasa",
                            Descricao="Deliciosa Lagosta na Brasa",
                            Imagem="http://imgsapp.df.divirtasemais.com.br/app/noticia_133890394703/2019/02/01/161056/20190131094838276825a.JPG",
                            Preco= 100,
                            CategoriaId= 8
                        },
                           
                    });
                    context.SaveChanges();
                }
                //Reservas
                if (!context.Reservas.Any())
                {
                    context.Reservas.AddRange(new List<Reserva> ()
                    {
                        new Reserva()
                        {
                        DataHoraCriacao = DateTime.Now.AddDays(-10),
                        DataHoraReserva = DateTime.Now.AddDays(-10),
                        Descricao = "",
                        Situacao = true,
                        ClienteId = 1,
                        MesaId = 1
                        },
                        new Reserva()
                        {
                        DataHoraCriacao = DateTime.Now.AddDays(-10),
                        DataHoraReserva = DateTime.Now.AddDays(-10),
                        Descricao = "",
                        Situacao = true,
                        ClienteId = 1,
                        MesaId = 1
                        },
                        new Reserva()
                        {
                        DataHoraCriacao = DateTime.Now.AddDays(-10),
                        DataHoraReserva = DateTime.Now.AddDays(-10),
                        Descricao = "",
                        Situacao = true,
                        ClienteId = 1,
                        MesaId = 1
                        },
                        new Reserva()
                        {
                        DataHoraCriacao = DateTime.Now.AddDays(-10),
                        DataHoraReserva = DateTime.Now.AddDays(-10),
                        Descricao = "",
                        Situacao = true,
                        ClienteId = 1,
                        MesaId = 1
                        },
                    });
                    context.SaveChanges();
                }
                //Agenda
                if (!context.Agendas.Any())
                {
                    context.Agendas.AddRange(new List<Agenda>()
                    {
                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "13:00",
                            MesaId = 1
                        },
                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "18:00",
                            MesaId = 1
                        },
                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "20:00",
                            MesaId = 1
                        },
                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "15:00",
                            MesaId = 1
                        },

                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "12:00",
                            MesaId = 2                            
                        },

                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "08:00",
                            MesaId = 3
                        },
                    });
                    context.SaveChanges();                
                }
                                
                                //Avaliacoes
                               /* if (!context.Restaurantes.Any())
                                {
                                    context.Clientes.AddRange(new List<Cliente>()
                                    {

                                    });

                                }*/
            }
        }
    }
}

