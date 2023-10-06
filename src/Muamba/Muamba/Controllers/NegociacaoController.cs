using Microsoft.AspNetCore.Mvc;

namespace Muamba.Controllers
{
    public class NegociacaoController : Controller
    {
        public IActionResult Avaliacoes()
        {
            return View();
        }
        public IActionResult IniciarNegociacao()
        {
            return View();
        }
        public IActionResult Negociacoes()
        {
            return View();
        }
    }
}
