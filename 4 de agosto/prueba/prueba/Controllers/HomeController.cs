using EjemploMvcConversor.Servicios;
using Microsoft.AspNetCore.Mvc;
using prueba.Controllers.servicios;
using prueba.Models;
using System.Diagnostics;


namespace EjemploMvcConversor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioMonedas servicioMonedas;

        public HomeController(ILogger<HomeController> logger, IServicioMonedas servicioMonedas)
        {
            _logger = logger;
            this.servicioMonedas = servicioMonedas;
        }

        public IActionResult Index()
        {
            //var serviciomonedas = new ServicioMonedas();

            _logger.LogInformation("LKJIJFD"); //para sacar pro consola
            var lista = this.servicioMonedas.ObtenerMonedas(); //para no instanciar

            return View();



        }

        public IActionResult Privacy()
        {

            //var serviciomonedas = new ServicioMonedas();
            var lista = this.servicioMonedas.ObtenerMonedas();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}