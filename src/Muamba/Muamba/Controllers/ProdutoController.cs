using Microsoft.AspNetCore.Mvc;

namespace Muamba.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuscarProduto()
        {
            return View();
        }

        public IActionResult CadastrarProduto()
        {
            return View();
        }
        public IActionResult AnunciarViagem()
        {
            return View();
        }
    }
}
