using Conversor2.Models;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinalConsola;
using System.Diagnostics;

namespace Conversor2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.saludo = "Hola mundo desde c#"; //VIEWBAG es un objeto de tipo dinámico
            ViewBag.fecha = DateTime.Now;

            ViewBag.Euro = new Moneda("New euro", "EUR_NEW", 0.5);

            //Traer lista de monedas y mostrar primera moneda (ejercicio)

            //Del JSON:
            LectorJSON lectorJSON = new LectorJSON();
            ViewBag.listaMonedas = lectorJSON.LeerMonedas();


           


            return View();
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