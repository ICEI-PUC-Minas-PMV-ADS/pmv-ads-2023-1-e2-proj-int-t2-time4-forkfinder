using ForkFinder.Data;
using ForkFinder.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ForkFinder.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Identity;
using System.Dynamic;

namespace ForkFinder.Controllers
{
    public class RestaurantesController : Controller
    {
        private readonly AppDbContext _context;
        public RestaurantesController(AppDbContext context)
        {
            _context = context;
        }
        /* public async Task<IActionResult> Index()
         {
             var data = await _context.Restaurantes
                 .Include(a => a.Avaliacoes)
                 .Include(e => e.Endereco)
                 .Include(er => er.Especialidades_Restaurantes).ThenInclude(es => es.Especialidade)
                 .ToListAsync();

             return View(data);
         }*/

        public async Task<IActionResult> Index(string especialidade, int? disponibilidade, bool? acessibilidade, int? avaliacao)
        {
            var especialidades = _context.Especialidades.ToList();
            var horarios = _context.Horarios.ToList();
            dynamic context = new ExpandoObject();
            context.Especialidades = especialidades;
            context.Horarios = horarios;
            ViewBag.Context = context;


            var query = _context.Restaurantes
                .Include(a => a.Avaliacoes)
                .Include(e => e.Endereco)
                .Include(er => er.Especialidades_Restaurantes).ThenInclude(es => es.Especialidade)
                .AsEnumerable(); // Alterado para AsEnumerable()

            if (!string.IsNullOrEmpty(especialidade))
            {
                query = query.Where(e => e.Especialidades_Restaurantes
                    .Any(r => r.Especialidade.NomeEspecialidade.ToLower().Contains(especialidade.ToLower())));
            }

            if (disponibilidade.HasValue)
            {

                var horarioSelecionado = await _context.Horarios.FirstOrDefaultAsync(h => h.Id == disponibilidade.Value);
                if (horarioSelecionado != null)
                {
                    var horariosDistintos = await _context.Horarios
                        .Where(h => h.Hora != horarioSelecionado.Hora)
                        .ToListAsync();

                    query = query.Where(e => e.Especialidades_Restaurantes
                    .Any(r => r.Restaurante.Mesas != null && r.Restaurante.Mesas
                        .Any(m => m.Horarios != null && m.Horarios.Any(h => horariosDistintos.Any(d => d.Id == h.Id)))));

                }
            }

            if (acessibilidade.HasValue)
            {
                query = query.Where(e => e.Especialidades_Restaurantes
                    .Any(r => r.Restaurante.Acessibilidade == acessibilidade.Value));
            }

            if (avaliacao.HasValue)
            {
                query = query.Where(e => e.Especialidades_Restaurantes
                 .Any(r => r.Restaurante.Avaliacoes.Any() && r.Restaurante.Avaliacoes.Average(a => a.Estrela) >= avaliacao.Value));

            }

            var data = query.ToList(); // Alterado para ToList()

            return View(data);
        }



        [Authorize(Roles = "Cliente")]
        public async Task<IActionResult> Agenda(int id)
        {
            var restaurante = await _context.Restaurantes
                .Include(r => r.Agendas)
                .FirstOrDefaultAsync(n => n.RestauranteId == id);

            if (restaurante == null)
            {
                return NotFound();
            }

            var viewModel = new AgendaViewModel
            {

            };

            return View(viewModel);
        }


        [AllowAnonymous]
        public async Task<IActionResult> Restaurante(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurante = await _context.Restaurantes
                .Include(f => f.Fotos)
                .Include(r => r.Avaliacoes)
                .Include(r => r.Especialidades_Restaurantes)
                .ThenInclude(er => er.Especialidade)
                //.Include(r => r.Agendas)
                .FirstOrDefaultAsync(r => r.RestauranteId == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return View(restaurante);


        }
        [AllowAnonymous]
        public async Task<IActionResult> Mesas(int id)
        {
            var restaurante = await _context.Restaurantes
                .Include(m => m.Mesas).ThenInclude(ho => ho.Horarios)
                .Include(r => r.Agendas).ThenInclude(ho => ho.Horarios)
                .FirstOrDefaultAsync(n => n.RestauranteId == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return View(restaurante);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Register([Bind("Id,Email,Senha,Nome,CNPJ,Papel,CreatedDate")] Restaurante restaurante)
        {
            var checkExistingEmail = _context.Restaurantes.FirstOrDefault(stored => stored.Email == restaurante.Email);
            var validatePasswordLength = restaurante.Senha.Length >= 8;


            if (checkExistingEmail != null)
            {
                ModelState.AddModelError("Email", "E-mai já cadastrado");
            }

            if (!validatePasswordLength)
            {
                ModelState.AddModelError("Senha", "A senha deve ter pelo menos 8 caracteres.");
            }
            if (ModelState.IsValid || (!string.IsNullOrEmpty(restaurante.Senha)))
            {
                string iconPath = "path/do/icone/user.png"; // Caminho do arquivo de imagem do ícone
                byte[] iconBytes = System.IO.File.ReadAllBytes(iconPath);
                restaurante.Senha = BCrypt.Net.BCrypt.HashPassword(restaurante.Senha);
                restaurante.Nome = restaurante.Nome;
                restaurante.Email = restaurante.Email;
                restaurante.CNPJ = restaurante.CNPJ;
                restaurante.FotoPerfil = iconBytes;
                restaurante.Papel = (Papel)1;
                _context.Add(restaurante);
                await _context.SaveChangesAsync();
                return RedirectToAction("Perfil", restaurante);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditarPerfil(Restaurante restaurante, IFormFile fotoPerfil)
        {
            // Recuperar o restaurante do banco de dados
            var restauranteIdClaim = User.FindFirst("RestauranteId")?.Value;
            if (restauranteIdClaim != null && int.TryParse(restauranteIdClaim, out int restauranteId))
            {
                var restauranteExistente = await _context.Restaurantes.FindAsync(restauranteId);

                // Verificar se o restaurante existe
                if (restauranteExistente != null)
                {
                    // Atualizar os campos do restaurante com os dados do formulário
                    restauranteExistente.Nome = restaurante.Nome;
                    restauranteExistente.CNPJ = restaurante.CNPJ;                    
                    restauranteExistente.DescricaoRestaurante = restaurante.DescricaoRestaurante;
                    restauranteExistente.Acessibilidade = restaurante.Acessibilidade;
                    restauranteExistente.Papel = (Papel)1;

                    // Consultar a senha atual do restaurante no banco de dados
                    var senhaAtual = await _context.Restaurantes
                        .Where(r => r.RestauranteId == restauranteId)
                        .Select(r => r.Senha)
                        .FirstOrDefaultAsync();

                    // Atribuir a senha atual ao restaurante sendo atualizado
                    restaurante.Senha = senhaAtual;
                    /*restauranteExistente.Senha = BCrypt.Net.BCrypt.HashPassword(restaurante.Senha);
                    */
                    if (fotoPerfil != null)
                {
                    // Processar e salvar a imagem de perfil
                    restauranteExistente.FotoPerfil = await ProcessarImagemPerfil(fotoPerfil);
                }

                // Verificar a validade do modelo após a atualização dos dados
                if (ModelState.IsValid)
                {
                    _context.Update(restauranteExistente);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Perfil", new { id = restauranteExistente.RestauranteId });
                }
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    var errorMessage = error.ErrorMessage;
                    var exception = error.Exception;
                    // Faça o tratamento adequado das mensagens de erro
                }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Restaurante não encontrado.");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "RestauranteId inválido ou não fornecido.");
            }

            // Se o ModelState não for válido ou o restaurante não existir, retorne a view com os dados do restaurante
            return View(restaurante);
        }


        private async Task<byte[]> ProcessarImagemPerfil(IFormFile fotoPerfil)
        {
            using (var memoryStream = new MemoryStream())
            {
                await fotoPerfil.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }


        [HttpPost]
        public async Task<IActionResult> PreencherPerfil(Restaurante restaurante, IFormFile fotoPerfilFile)
        {
            if (fotoPerfilFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await fotoPerfilFile.CopyToAsync(memoryStream);
                    restaurante.FotoPerfil = memoryStream.ToArray();
                }
            }

            // Salvar o objeto Restaurante no banco de dados
            _context.Restaurantes.Add(restaurante);
            await _context.SaveChangesAsync();

            // Redirecionar para a página de sucesso ou outra página relevante
            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Restaurante restaurante)
        {
            var user = await _context.Restaurantes.FirstOrDefaultAsync(m => m.Email == restaurante.Email);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Usuário e/ou senha inválidos.");
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(restaurante.Senha, user.Senha);

            if (isSenhaOk)
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Nome),
            new Claim(ClaimTypes.NameIdentifier, user.Nome),
            new Claim(ClaimTypes.Role, user.Papel.ToString()),
            new Claim("RestauranteId", user.RestauranteId.ToString()),
        };
                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };
                await HttpContext.SignInAsync(principal, props);
                return Redirect("/");
            }

            ModelState.AddModelError(string.Empty, "Usuário e/ou senha inválidos.");
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Restaurantes");
        }
        [Authorize]
        [HttpPost]
        public IActionResult Reserva(int restauranteId, int mesaId, int horarioId, int agendaId, string descricao)
        {
            // Recupere o nome do cliente logado usando o mecanismo de autenticação do ASP.NET Core
            var nomeCliente = User.Identity.Name;

            // Verifique se os parâmetros são válidos e realize as operações de reserva
            if (!string.IsNullOrEmpty(nomeCliente) && restauranteId > 0 && mesaId > 0 && horarioId > 0 && agendaId > 0)
            {
                // Consultar o banco de dados para obter o ID do cliente com base no nome
                var cliente = _context.Clientes.FirstOrDefault(c => c.Nome == nomeCliente);

                if (cliente != null)
                {
                    // Consultar o banco de dados para obter as entidades relacionadas (restaurante, mesa, horario, agenda)
                    var restaurante = _context.Restaurantes.FirstOrDefault(r => r.RestauranteId == restauranteId);
                    var mesa = _context.Mesas.FirstOrDefault(m => m.Id == mesaId);
                    var horario = _context.Horarios.FirstOrDefault(h => h.Id == horarioId);
                    var agenda = _context.Agendas.FirstOrDefault(a => a.Id == agendaId);

                    if (restaurante != null && mesa != null && horario != null && agenda != null)
                    {
                        // Crie uma nova reserva e atribua as entidades relacionadas
                        var reserva = new Reserva
                        {
                            Restaurante = restaurante,
                            Mesa = mesa,
                            Horario = horario,
                            Agenda = agenda,
                            ClienteId = cliente.ClienteId,
                            Descricao = descricao
                        };
                        horario.Agendado = true;

                        // Salve a nova reserva no banco de dados
                        _context.Reservas.Add(reserva);
                        _context.SaveChanges();

                        // Retorna uma resposta de sucesso para a chamada AJAX
                        return Ok();
                    }
                }
            }

            // Retorna uma resposta de erro para a chamada AJAX
            return BadRequest();
        }


        public IActionResult Perfil(Restaurante restaurante)
        {
            return View(restaurante);
        }
        public async Task<IActionResult> AddMesas()
        {
            var restauranteIdClaim = User.FindFirst("RestauranteId")?.Value;

            if (restauranteIdClaim == null)
            {
                // Lidar com o caso em que o ID do restaurante não está presente no usuário logado
                // Por exemplo, redirecionar para uma página de erro ou retornar uma mensagem de erro
                return RedirectToAction("Error", "Home");
            }

            if (!int.TryParse(restauranteIdClaim, out int restauranteId))
            {
                // Lidar com o caso em que o ID do restaurante não é um valor inteiro válido
                // Por exemplo, redirecionar para uma página de erro ou retornar uma mensagem de erro
                return RedirectToAction("Error", "Home");
            }

            var mesas = await _context.Mesas
                .Where(m => m.RestauranteId == restauranteId)
                .ToListAsync();

            return View(mesas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Mesas/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("TamanhoMesa,QuantidadeMesa")] Mesa mesa)
        {
            if (ModelState.IsValid)
            {
                var restauranteIdClaim = User.FindFirst("RestauranteId")?.Value;
                if (int.TryParse(restauranteIdClaim, out int restauranteId))
                {
                    var restaurante = await _context.Restaurantes.FindAsync(restauranteId);
                    if (restaurante != null)
                    {
                        /*var mesa = new Mesa
                        {*/
                        mesa.TamanhoMesa = mesa.TamanhoMesa;
                        mesa.QuantidadeMesa = mesa.QuantidadeMesa;
                        mesa.Agendada = false;
                        mesa.Descricao = "";
                        mesa.RestauranteId = restaurante.RestauranteId;
                        /*};*/

                        _context.Mesas.Add(mesa);
                        await _context.SaveChangesAsync();

                        return RedirectToAction("Index", "Mesas");
                    }
                }
            }

            return View();
        }
        


    }

}
