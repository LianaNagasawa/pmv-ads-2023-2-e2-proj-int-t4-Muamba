using Microsoft.AspNetCore.Mvc;
using Muamba.Models;
using System.Diagnostics;

namespace Muamba.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();


            var negociacoes = _context.Negociacoes.OrderByDescending(o => o.Id).Take(4).ToList();
            var avaliacoesViajante = _context.Avaliacoes.OrderByDescending(o => o.NotaViajante).Take(2).ToList();
            var avaliacoesComprador = (_context.Avaliacoes.OrderByDescending(o => o.NotaComprador).Take(2).ToList());


            model.AvaliacoesComprador = avaliacoesComprador;
            model.AvaliacoesViajante = avaliacoesViajante;
            model.Negociacoes = negociacoes;

            return View(model);
        }
        public IActionResult QuemSomos()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}