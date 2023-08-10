using EjemploMvcConversor.Models;
using EjemploMvcConversor.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploMvcConversor.Controllers
{

    // 1-Crear IRepositorio
    // 2-Crear Repositorio
    // 3-Agregar AddScoped<IRepositorio,Repositorio>
    // 4-Modificar constructor de HomeController para incluir IRepositorio
    // 5-Crear campo repositorio en HomeController
    // 6-Eliminar dependencia de proyecto lectura JSON Monedas
    // 7-Modificar metodo ObtenerMonedas en Repositorio para llamar al metodo libreria JSON
    // 8-En el metodo Index() llamar a repositorio.ObtenerMonedas, guardar en lista
    // 9-Pasar lista a la vista en return View(lista)
    // 10-Modificar vista @model IEnumerable<Moneda>
    // 11-Mostrar lista de monedas en la vista con un @foreach


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioMonedas repositorioMonedas;

        public HomeController(ILogger<HomeController> logger, IRepositorioMonedas repositorioMonedas)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
        }

        public IActionResult Index()
        {

            _logger.LogInformation("Estoy en el index");
            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();    

            return View(lista);
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