using Conversor2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Conversor2.Controllers
{
    public class HomeController : Controller
    { //no ve nada del api o json en el proyecto
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioMonedas repositorioMonedas;

        public HomeController(ILogger<HomeController> logger, IRepositorioMonedas repositorioMonedas)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
        }

        public IActionResult Index() //Iactionresult interfaz de action euslt
        {


            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();
           


            return View(lista); //Ya no mas newbag, a partir de ahora devolver en view explicitamente
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