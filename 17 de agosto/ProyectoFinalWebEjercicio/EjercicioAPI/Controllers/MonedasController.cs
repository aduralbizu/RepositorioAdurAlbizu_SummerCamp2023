using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositorios;

namespace EjercicioAPI.Controllers
{

    public class Moneda
    {
        public string Nombre { get; set; }
    }
    //Todo controlador 3 cosas caracteristicas de inicio
    //+1-Ruta
    //[Route("api/[controller]")] No dejes que lo decida él
    [Route("api/Monedas")] //Que no cambie nunca

    //+2-Indicar que es controlador API
    [ApiController]
    public class MonedasController : ControllerBase //+3-Hereda de controlador API
    {

        private readonly IRepositorioMonedas repositorioMonedas;

        public MonedasController(IRepositorioMonedas repositorioMonedas)
        {

            this.repositorioMonedas = repositorioMonedas;

        }

        //+ A Verbo/accion http
        //[HttpGet]
        //+B-Devuelve ActionResult<Tipo>
        //public ActionResult<IEnumerable <Moneda>> ObtenerMonedas()
        //{

        //    var lista = new List<Moneda>()
        //    {
        //        new Moneda {Nombre="Euro"}
        //    };

        //    //+C- Devolver resultado y codigo de estado

        //    return Ok(lista);//Esto es como la vista

        //}

        //+ A Verbo/accion http
        [HttpGet]
        //+B-Devuelve ActionResult<Tipo>
        //api/Monedas 
        public ActionResult<List<Moneda>> ObtenerMonedas()
        {
            repositorioMonedas.AgregarMonedas();

            var lista = repositorioMonedas.ObtenerMonedas().ToList();

            //+C- Devolver resultado y codigo de estado

            return Ok(lista);//Esto es como la vista

        }

        //api/Monedas/{Codigomoneda}
        [HttpGet("{CodigoMoneda}")]
        public ActionResult<MonedaDTO> ObtenerMoneda(string CodigoMoneda)
        {
            var moneda = repositorioMonedas.ObtenerMoneda(CodigoMoneda);

            MonedaDTO monedaDTO = new MonedaDTO()
            {
                Code = moneda.Code,
                Name = moneda.Name,
                Symbol = moneda.Symbol,
                Descripcion = $"{moneda.Code} {moneda.Symbol} {moneda.Name}"
            };

            //+C- Devolver resultado y codigo de estado

            return Ok(monedaDTO);//Esto es como la vista

        }//No devuelve vistas
    }
}
