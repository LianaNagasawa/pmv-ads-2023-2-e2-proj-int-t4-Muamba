using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muamba.Models;
using System.IO;

namespace Muamba.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly string _rootPath;

        public ProdutoController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _rootPath = env.WebRootPath;
        }
        public async Task<IActionResult> Index()
        {
            var buscaProdutoViewModel = new BuscaProdutoViewModel();
            var categorias = await _context.Categorias.ToListAsync();
            var produtos = await _context.Produtos.Where(p => p.Status).Take(5).ToListAsync();

            buscaProdutoViewModel.Categorias = categorias;
            buscaProdutoViewModel.Produtos = produtos;

            return View("BuscarProduto", buscaProdutoViewModel);
        }

        public async Task<IActionResult> BuscarProduto(string palavrachave, string localidade, string categoria)
        {
            var buscaProdutoViewModel = new BuscaProdutoViewModel();

            var categorias = await _context.Categorias.ToListAsync();
            var produtos = await _context.Produtos.Where(p => p.PalavraChave.Contains(palavrachave) && p.Status).ToListAsync();

            buscaProdutoViewModel.Categorias = categorias;
            buscaProdutoViewModel.Produtos = produtos;
            buscaProdutoViewModel.ResultadoBusca = string.Format("Você buscou:{0}", palavrachave);
            return View("BuscarProduto", buscaProdutoViewModel);
        }

        public async Task<IActionResult> CadastrarProduto()
        {
            var cadastroProdutoViewModel = new CadastroProdutoViewModel(); //instanciando objeto Cadatro de Produto
            var categorias = await _context.Categorias.ToListAsync(); //listar as categorias cadastradas no banco de dados oara seleção
            cadastroProdutoViewModel.Categorias = categorias;

            return View("CadastrarProduto", cadastroProdutoViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SalvarProduto(Produto produto)
        {
            var fileName = $"{Guid.NewGuid().ToString()}{System.IO.Path.GetExtension(produto.File.FileName)}";

            produto.FotoProduto = $"../img/Produto/{fileName}";

            _context.Produtos.Add(produto); //adicionar banco de dados
            await _context.SaveChangesAsync(); //salvar no banco de dados

            produto.File.CopyTo(new FileStream($"{_rootPath}/img/Produto/{fileName}", FileMode.Create)); // pegar imagem no arquivo do site e salvar no banco de dados 

            return RedirectToAction("Index");
        }

    }
}
