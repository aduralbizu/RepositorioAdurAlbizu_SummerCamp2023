using Conversor2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conversor2.Controllers
{
    public class MonedasController : Controller
    {


        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioMonedas repositorioMonedas;

        public MonedasController(ILogger<HomeController> logger, IRepositorioMonedas repositorioMonedas)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
        }

        public IActionResult Index()
        {
            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();

            return View(lista);
        }
    }
}
