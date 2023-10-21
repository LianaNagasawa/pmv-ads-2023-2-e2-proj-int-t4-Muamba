using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muamba.Models;

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
            return View();
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
            var produto = _context.Produtos.Where(p => p.Id == IdProduto).FirstOrDefault();
            var viagens = new List<Viagem>();

            if (!string.IsNullOrEmpty(localidade))
            {
                viagens = _context.Viagens.Where(p => (p.Pais == localidade || p.Provincia == localidade || p.Regiao == localidade) && p.DataVolta > DateTime.Now.Date).ToList();
            }

            var buscaViajanteViewModel = new BuscaViajanteViewModel() { Produto = produto, Viagens = viagens };

            return View(buscaViajanteViewModel);
        }
    }
}
