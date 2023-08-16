using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioAPI.Controllers
{
    //Todo controlador 3 cosas caracteristicas de inicio
    //+1-Ruta
    //[Route("api/[controller]")] No dejes que lo decida él
    [Route("api/Monedas")] //Que no cambie nunca

    //+2-Indicar que es controlador API
    [ApiController]
    public class MonedasController : ControllerBase //+3-Hereda de controlador API
    {


        
    }//No devuelve vistas
}
