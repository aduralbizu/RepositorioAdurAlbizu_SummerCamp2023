﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        //+ A Verbo/accion http
        [HttpGet]
        //+B-Devuelve ActionResult<Tipo>
        public ActionResult<IEnumerable <Moneda>> ObtenerMonedas()
        {
            var lista = new List<Moneda>()
            {
                new Moneda {Nombre="Euro"}
            };

            //+C- Devolver resultado y codigo de estado

            return Ok(lista);//Esto es como la vista

        }
        
    }//No devuelve vistas
}
