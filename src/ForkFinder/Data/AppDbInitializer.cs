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
                        }, new Restaurante()
                        {
                            Nome = "Aladdin's Palace",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "45.678.901/0001-04",
                            FotoPerfil = https://img.freepik.com/vetores-premium/logotipo-do-cafe-e-restaurante-de-comida-arabe_18099-3719.jpg?w=2000,
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Mangai Comida Regional"
                        },

                              {
                            Nome = "Falafel Oasis",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "12.345.678/0001-01",
                            FotoPerfil  "https://th.bing.com/th/id/R.395f8b006a3bd0d07131fa7e99db8d45?rik=NzmyyrNQipPDKg&riu=http%3A%2F%2F50graphics.com%2Fwp-content%2Fuploads%2F2019%2F04%2FDifferent-logo-designs-for-Arabian-restaurant.jpg&ehk=XRlSiJsTVyKPAKtMMggXKOQGNLgKEJSVQpib3tJKWaw%3D&risl=&pid=ImgRaw&r=2000",,
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Mangai Comida Regional"
                        },
                             {
                            Nome = "Arabian Delights",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "34.567.890/0001-03",
                            FotoPerfil =https://marketing.dcassetcdn.com/blog/2018/August/62-arabic-logos/Brown-Cup.jpg,
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Mangai Comida Regional"
                        },

                            Nome = "Shawarma Heaven",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "12.345.678/0001-01",
                            FotoPerfil = "https://th.bing.com/th/id/R.5ee1ee3f5c2bd3e475c9307a65cf1383?rik=%2BSMjp1%2BPDvr7WA&riu=http%3A%2F%2Fruidosonoro.com%2Fwp-content%2Fuploads%2F2015%2F12%2F12265705_920887074627899_2005055234051443471_o.jpg&ehk=hLkZKbpJvTINnqYJxTIa7xNpushjRp9KQy7HgrJzj9Y%3D&risl=&pid=ImgRaw&r=0",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Mangai Comida Regional"
                        },
                           
                            Nome = "La Belle Époque",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "90.123.456 / 0001 - 09",
                            FotoPerfil = "https://th.bing.com/th/id/R.5ee1ee3f5c2bd3e475c9307a65cf1383?rik=%2BSMjp1%2BPDvr7WA&riu=http%3A%2F%2Fruidosonoro.com%2Fwp-content%2Fuploads%2F2015%2F12%2F12265705_920887074627899_2005055234051443471_o.jpg&ehk=hLkZKbpJvTINnqYJxTIa7xNpushjRp9KQy7HgrJzj9Y%3D&risl=&pid=ImgRaw&r=0",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Mangai Comida Regional"
                        },

            },
                            Nome = "La Petite Boulangerie",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = ". 78.901.234/0001-07",
                            FotoPerfil = "https://th.bing.com/th/id/R.5ee1ee3f5c2bd3e475c9307a65cf1383?rik=%2BSMjp1%2BPDvr7WA&riu=http%3A%2F%2Fruidosonoro.com%2Fwp-content%2Fuploads%2F2015%2F12%2F12265705_920887074627899_2005055234051443471_o.jpg&ehk=hLkZKbpJvTINnqYJxTIa7xNpushjRp9KQy7HgrJzj9Y%3D&risl=&pid=ImgRaw&r=0",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Mangai Comida Regional"
                        },
                        
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
                        },
                        new Endereco()
                        {
                        Logradouro ="Rua dos Sabores",
                        Numero = "959",
                        Complemento = "Loja 12",
                        CEP ="98765-432",
                        Bairro ="Gastronômico",
                        Cidade = "São paulo",
                        Estado = "SP",
                        RestauranteId = 7

                        },

                          new Endereco()
                        {
                        Logradouro ="Rua das Estrelas,",
                        Numero = "959",
                        Complemento = "Loja 56",
                        CEP =", 98765-321",
                        Bairro ="Novo Horizonte",
                        Cidade = "Sertãozinho",
                        Estado = "AM",
                        RestauranteId = 8

                        },
                           new Endereco()
                        {
                        Logradouro ="Avenida Central",
                        Numero = "1045",
                        Complemento = "Loja 45",
                        CEP = " 10987-654",
                        Bairro ="Vila dos Pássaros",
                        Cidade = "Sertãozinho",
                        Estado = "SP",
                        RestauranteId = 9

                        },
                            new Endereco()
                        {
                        Logradouro ="Rua das Andorinhas",
                        Numero = "1300",
                        Complemento = "Loja 34",
                        CEP ="14164-025",
                        Bairro ="Loteamento Bela Vista",
                        Cidade = "Santa Cruz",
                        Estado = "GO",
                        RestauranteId = 10

                        },

                        new Endereco()
                        {
                        Logradouro ="Rua das andorinhas",
                        Numero = "045",
                        Complemento = "Loja 9",
                        CEP = " 104567-654",
                        Bairro ="Vila dos chines",
                        Cidade = "Selina",
                        Estado = "SP",
                        RestauranteId = 11

                        },
                         new Endereco()
                        {
                        Logradouro ="Rua das Andorinhas",
                        Numero = "1300",
                        Complemento = "Loja 34",
                        CEP ="141447-025",
                        Bairro ="Loteamento Bela Vista",
                        Cidade = "Matuzinho ",
                        Estado = "MG",
                        RestauranteId = 12

                        },

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
                        }
                    });
                    context.SaveChanges();
                }
/*                //Reservas
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

