using Microsoft.AspNetCore.Mvc;

namespace Muamba.Controllers
{
    public class ComoFuncionaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ComoFuncionaComprador()
        {
            return View();
        }
        public IActionResult ComoFuncionaViajante()
        {
            return View();
        }

        public IActionResult PoliticaDePrivacidade()
        {
            return View();
        }
        public IActionResult TermosDeUso()
        {
            return View();
        }
        public IActionResult Ajuda()
        {
            return View();
        }
    }
}
