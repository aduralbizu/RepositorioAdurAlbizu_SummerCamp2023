using APIJsonBiblioteca;
using AutoMapper;
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
        private readonly IMapper mapper;

        public HomeController(ILogger<HomeController> logger, IRepositorioMonedas repositorioMonedas,
                               IMapper mapper)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
            this.mapper = mapper;
            //cualquier cosa que quieres que sea un servicio de los referido desde program se pone en el constructor
        }

        public IActionResult Index()
        {

            var apiMonedas = new ApiMonedas();
            List<MonedaJson> listaMonedasApi = apiMonedas.ObtenerMonedas();


            foreach (MonedaJson monedaJson in listaMonedasApi)
            {
                //var moneda = new Moneda
                //{
                //    CodigoMoneda = monedaJson.CodigoMoneda
                //};

                //Moneda moneda = monedaJson; NoContent podemos hacer esto

                Moneda moneda = mapper.Map<Moneda>(monedaJson);
                //<origen>(destino)
                //Mtachea campos que coinciden. De esta forma
                //agregamos de forma automatica las monedas

                repositorioMonedas.AgregarMoneda(moneda);
            }
            //new stuff 

            //_logger.LogInformation("Estoy en el index");
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