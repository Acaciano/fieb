using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SouFieb.DB;
using SouFieb.Models;

namespace SouFieb.Controllers
{
    public class PessoaController : Controller
    {
        private PessoaDB pessoaDB;

        public PessoaController(IConfiguration configuration)
        {
            pessoaDB = new PessoaDB(configuration);
        }

        public IActionResult Nova()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            var pessoa = pessoaDB.BuscarPorId(id);

            return View(pessoa);
        }

        public IActionResult ConfirmarExclusao(int id)
        {
            var pessoa = pessoaDB.BuscarPorId(id);

            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Cadastrar(Pessoa pessoa)
        {
            pessoaDB.Salvar(pessoa);

            return RedirectToAction("Index", "Home", new { mensagem = "Pessoa cadastrada com sucesso!" });
        }

        [HttpPost]
        public IActionResult Atualizar(Pessoa pessoa)
        {
            pessoaDB.Atualizar(pessoa);

            return RedirectToAction("Index", "Home", new { mensagem = "Pessoa alterada com sucesso!" });
        }

        [HttpPost]
        public IActionResult Deletar(Pessoa pessoa)
        {
            pessoaDB.Deletar(pessoa);

            return RedirectToAction("Index", "Home", new { mensagem = "Pessoa deletada com sucesso!" });
        }
    }
}
