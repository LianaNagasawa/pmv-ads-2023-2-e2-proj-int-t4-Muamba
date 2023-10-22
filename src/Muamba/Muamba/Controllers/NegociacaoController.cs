using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muamba.Models;
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
            avaliacoesViewModel.NegociacoesViajantes = avaliacoesPendentesViajante;

            return View(avaliacoesViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ChamarNegociacao(Negociacao negociacao)
        {
            _context.Negociacoes.Add(negociacao); //adicionar banco de dados
            await _context.SaveChangesAsync(); //salvar no banco de dados
            return RedirectToAction("Negociacoes");
        }


        public IActionResult Negociacoes()
        {
            return View();
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
    }
}
