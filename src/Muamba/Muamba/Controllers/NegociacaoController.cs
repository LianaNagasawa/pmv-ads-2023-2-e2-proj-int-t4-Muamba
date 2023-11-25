using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muamba.Models;
using SiteMuamba.Models;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Muamba.Controllers
{
    public class NegociacaoController : Controller
    {
        private readonly AppDbContext _context;

        public NegociacaoController(AppDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Avaliacoes()
        {
            var idUsuario = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid) != null ? int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid).Value) : 0;
            var avaliacoesPendentes = _context.Negociacoes.Where(n => n.Status == 0 && n.CompradorId == idUsuario).ToList();
            var avaliacoesPendentesViajante = (from negociacao in _context.Negociacoes
                                               join viagem in _context.Viagens on negociacao.ViagemId equals viagem.Id
                                               join viajante in _context.Usuarios on viagem.UsuarioViajanteId equals viajante.Id
                                               where negociacao.Status == 0 && viajante.Id == idUsuario
                                               select negociacao).ToList();


            var avaliacoesViewModel = new AvaliacoesViewModel();
            avaliacoesViewModel.NegociacoesComprador = avaliacoesPendentes;
            avaliacoesViewModel.NegociacoesViajante = avaliacoesPendentesViajante;




            var avaliacoesEncerradas = (from negociacao in _context.Negociacoes
                                        join avaliacao in _context.Avaliacoes on negociacao.Id equals avaliacao.NegociacaoId
                                        where negociacao.CompradorId == idUsuario && avaliacao.NotaViajante.HasValue
                                        select avaliacao).ToList();

            var avaliacoesEncerradasViajante = (from negociacao in _context.Negociacoes
                                                join avaliacao in _context.Avaliacoes on negociacao.Id equals avaliacao.NegociacaoId
                                                join viagem in _context.Viagens on negociacao.ViagemId equals viagem.Id
                                                join viajante in _context.Usuarios on viagem.UsuarioViajanteId equals viajante.Id
                                                where viajante.Id == idUsuario && avaliacao.NotaComprador.HasValue
                                                select avaliacao).ToList();

            avaliacoesViewModel.AvaliacaoEncerrada = avaliacoesEncerradas;
            avaliacoesViewModel.AvaliacaoEncerradaViajante = avaliacoesEncerradasViajante;

            for (int i = avaliacoesViewModel.NegociacoesComprador.Count - 1; i >= 0; i--)
            {
                if (avaliacoesEncerradas.Where(a => a.NegociacaoId == avaliacoesViewModel.NegociacoesComprador[i].Id).FirstOrDefault() != null)
                {
                    avaliacoesViewModel.NegociacoesComprador.RemoveAt(i);
                }
            }

            for (int i = avaliacoesViewModel.NegociacoesViajante.Count - 1; i >= 0; i--)
            {
                if (avaliacoesEncerradasViajante.Where(a => a.NegociacaoId == avaliacoesViewModel.NegociacoesViajante[i].Id).FirstOrDefault() != null)
                {
                    avaliacoesViewModel.NegociacoesViajante.RemoveAt(i);
                }
            }
            return View(avaliacoesViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChamarNegociacao(Negociacao negociacao)
        {
            _context.Negociacoes.Add(negociacao); //adicionar banco de dados
            await _context.SaveChangesAsync(); //salvar no banco de dados
            return RedirectToAction("Negociacoes");
        }

        [Authorize]
        public IActionResult Negociacoes()
        {
            var idUsuario = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid) != null ? int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid).Value) : 0;
            var negociacoesViajante = _context.Negociacoes.Where(n => n.Viagem.UsuarioViajanteId == idUsuario).ToList();
            var negociacoesComprador = _context.Negociacoes.Where(n => n.CompradorId == idUsuario).ToList();

            var negociacoesViewModel = new NegociacoesViewModel();

            negociacoesViewModel.NegociacoesViajante = negociacoesViajante;
            negociacoesViewModel.NegociacoesComprador = negociacoesComprador;

            return View(negociacoesViewModel);
        }
        public IActionResult BuscarViajante(int IdProduto, string localidade)
        {
            var idUsuario = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid) != null ? int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid).Value) : 0;
            var produto = _context.Produtos.Where(p => p.Id == IdProduto).FirstOrDefault();
            var viagens = new List<Viagem>();

            if (!string.IsNullOrEmpty(localidade))
            {
                viagens = _context.Viagens.Where(p => (p.Pais == localidade || p.Provincia == localidade || p.Regiao == localidade) && p.DataVolta > DateTime.Now.Date).ToList();
            }

            var buscaViajanteViewModel = new BuscaViajanteViewModel() { Produto = produto, Viagens = viagens, UsuarioId = idUsuario };

            return View(buscaViajanteViewModel);
        }

        [Authorize]
        public async Task<IActionResult> EnviarAvaliacaoComprador(Avaliacao avaliacao)
        {
            var notaComprador = _context.Avaliacoes.Where(a => a.NegociacaoId == avaliacao.NegociacaoId).FirstOrDefault();
            if (notaComprador == null)
            {
                _context.Avaliacoes.Add(avaliacao); //adicionar banco de dados
            }
            else if (!notaComprador.NotaComprador.HasValue)
            {
                notaComprador.NotaComprador = avaliacao.NotaComprador;
                _context.Avaliacoes.Update(notaComprador);
            }

            await _context.SaveChangesAsync(); //salvar no banco de dados

            CalcularMediaAvaliacao(avaliacao);
            return RedirectToAction("Avaliacoes");
        }

        [Authorize]
        public async Task<IActionResult> EnviarAvaliacaoViajante(Avaliacao avaliacao)
        {
            var notaViajante = _context.Avaliacoes.Where(a => a.NegociacaoId == avaliacao.NegociacaoId).FirstOrDefault();
            if (notaViajante == null)
            {
                _context.Avaliacoes.Add(avaliacao); //adicionar banco de dados
            }
            else if (!notaViajante.NotaViajante.HasValue)
            {
                notaViajante.NotaViajante = avaliacao.NotaViajante;
                _context.Avaliacoes.Update(notaViajante);
            }

            await _context.SaveChangesAsync(); //salvar no banco de dados
            CalcularMediaAvaliacao(avaliacao);

            return RedirectToAction("Avaliacoes");
        }


        [Authorize]
        public async Task<IActionResult> AnunciarViagem()
        {

            var anuncViagemViewModel = new AnuncViagemViewModel(); //instanciando objeto Cadastro de Produto

            var idUsuario = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid) != null ? int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid).Value) : 0;
            var viagensAnunciadas = _context.Viagens.Where(u => u.UsuarioViajanteId == idUsuario).ToList();

            anuncViagemViewModel.viagens = viagensAnunciadas;

            //listar as categorias cadastradas no banco de dados para seleção

            return View("AnunciarViagem", anuncViagemViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Anunciar(Viagem viagem)
        {
            var idUsuario = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid) != null ? int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.PrimarySid).Value) : 0;
            viagem.UsuarioViajanteId = idUsuario;

            _context.Viagens.Add(viagem); //adicionar banco de dados
            await _context.SaveChangesAsync(); //salvar no banco de dados

            return RedirectToAction("Negociacoes");
        }

        public async Task<IActionResult> AceitarNegociacao(int NegociacaoId)
        {
            var Negociacao = _context.Negociacoes.FirstOrDefault(a => a.Id == NegociacaoId);
            Negociacao.Status = 1;
            _context.Update(Negociacao);
            await _context.SaveChangesAsync();

            return RedirectToAction("Negociacoes");

        }

        public async Task<IActionResult> RecusarNegociacao(int NegociacaoId)
        {
            var Negociacao = _context.Negociacoes.FirstOrDefault(a => a.Id == NegociacaoId);
            Negociacao.Status = 2;
            _context.Update(Negociacao);
            await _context.SaveChangesAsync();

            return RedirectToAction("Negociacoes");

        }

        private async Task CalcularMediaAvaliacao(Avaliacao avaliacao)
        {

            //obter usuario viajante
            var usuarioViajante = _context.Negociacoes.Where(u => u.Id == avaliacao.NegociacaoId).FirstOrDefault().Viagem.UsuarioViajante;
            var usuarioComprador = _context.Negociacoes.Where(u => u.Id == avaliacao.NegociacaoId).FirstOrDefault().Comprador;

            //obter soma das avaliações + quantidade de avaliações e calcular a media
            var somaAvaliacoesViajante = (from negociacao in _context.Negociacoes
                                          join avaliacoes in _context.Avaliacoes on negociacao.Id equals avaliacao.NegociacaoId
                                          join viagem in _context.Viagens on negociacao.ViagemId equals viagem.Id
                                          join viajante in _context.Usuarios on viagem.UsuarioViajanteId equals viajante.Id
                                          where viajante.Id == usuarioViajante.Id && avaliacao.NotaViajante.HasValue
                                          select avaliacao).ToList().Sum(s => Convert.ToInt32(s.NotaViajante));
            var qtdAvaliacoesViajante = (from negociacao in _context.Negociacoes
                                         join avaliacoes in _context.Avaliacoes on negociacao.Id equals avaliacao.NegociacaoId
                                         join viagem in _context.Viagens on negociacao.ViagemId equals viagem.Id
                                         join viajante in _context.Usuarios on viagem.UsuarioViajanteId equals viajante.Id
                                         where viajante.Id == usuarioViajante.Id && avaliacao.NotaViajante.HasValue
                                         select avaliacao).ToList().Count();

            var somaAvaliacoesComprador = (from negociacao in _context.Negociacoes
                                           join avaliacoes in _context.Avaliacoes on negociacao.Id equals avaliacao.NegociacaoId
                                           where negociacao.CompradorId == usuarioComprador.Id && avaliacao.NotaComprador.HasValue
                                           select avaliacao).ToList().Sum(s => Convert.ToInt32(s.NotaComprador));
            var qtdAvaliacoesComprador = (from negociacao in _context.Negociacoes
                                          join avaliacoes in _context.Avaliacoes on negociacao.Id equals avaliacao.NegociacaoId
                                          where negociacao.CompradorId == usuarioComprador.Id && avaliacao.NotaComprador.HasValue
                                          select avaliacao).ToList().Count();

            var somaAvaliacoes = somaAvaliacoesViajante + somaAvaliacoesComprador;
            var qtdAvaliacoes = qtdAvaliacoesViajante + qtdAvaliacoesComprador;
            var mediaAvaliacoes = qtdAvaliacoes > 0 ? somaAvaliacoes / qtdAvaliacoes : 0;

            //atribuir ao objeto usuario o valor da media dele.

            usuarioViajante.MediaAvaliacao = mediaAvaliacoes;
            _context.Usuarios.Update(usuarioViajante);

            await _context.SaveChangesAsync(); //salvar no banco de dados
        }
    }
}
