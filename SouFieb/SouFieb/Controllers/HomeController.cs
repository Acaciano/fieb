using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SouFieb.DB;
using SouFieb.Models;
using System.Diagnostics;

namespace SouFieb.Controllers
{
    public class HomeController : Controller
    {
        private PessoaDB pessoaDB;

        public HomeController(IConfiguration configuration)
        {
            pessoaDB = new PessoaDB(configuration);
        }

        public IActionResult Index(string mensagem)
        {
            var pessoas = pessoaDB.BuscarTodos();

            if (!string.IsNullOrEmpty(mensagem))
                ViewBag.Mensagem = mensagem;

            return View(pessoas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
