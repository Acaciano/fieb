using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SouFieb.DB;
using SouFieb.Models;

namespace SouFieb.Controllers
{
    public class EventoController : Controller
    {
        private EventoDB eventoDB;

        public EventoController(IConfiguration configuration)
        {
            eventoDB = new EventoDB(configuration);
        }

        public IActionResult Index(string mensagem)
        {
            if (!string.IsNullOrEmpty(mensagem))
                ViewBag.Mensagem = mensagem;

            var eventos = eventoDB.BuscarTodos();

            return View(eventos);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Evento evento)
        {
            eventoDB.Salvar(evento);

            return RedirectToAction("Index", "Evento", new { mensagem = "Evento cadastrada com sucesso!" });
        }
    }
}
