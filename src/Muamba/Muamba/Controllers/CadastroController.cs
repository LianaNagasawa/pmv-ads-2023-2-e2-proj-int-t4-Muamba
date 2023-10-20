using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muamba.Models;

namespace Muamba.Controllers
{
    public class CadastroController : Controller
    {
        private readonly AppDbContext _context;
        public CadastroController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult CadastroPessoa()
        {
            return View();
        }

        public async Task<IActionResult> BuscarViajante(string palavrachave, string localidade, string categoria)
        {

            return View();
        }
    }
}
