using Microsoft.AspNetCore.Mvc;
using prueba.Models;
using prueba.servicios;
using System.Diagnostics;


namespace EjemploMvcConversor.Controllers
{
    public class HomeController : Controller
    { // controller determines what response to send back to a user when a user makes a browser request.
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioMonedas servicioMonedas;

        //Tarea:
        private readonly IEmail email;

        public HomeController(ILogger<HomeController> logger, IServicioMonedas servicioMonedas, IEmail email)
        {
            _logger = logger;
            this.servicioMonedas = servicioMonedas;
            this.email = email;
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
            //var lista = this.servicioMonedas.ObtenerMonedas();

            ViewBag.string_mensaje1 = this.email.EscribirEmail();
            
            return View();

            //Tarea:

            

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}