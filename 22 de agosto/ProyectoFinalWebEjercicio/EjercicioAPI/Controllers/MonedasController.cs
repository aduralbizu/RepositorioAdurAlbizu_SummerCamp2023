using AutoMapper;
using DTOs;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositorios;

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

        private readonly IRepositorioMonedas repositorioMonedas;
        private readonly IMapper mapper;

        public MonedasController(IRepositorioMonedas repositorioMonedas, IMapper mapper)
        {

            this.repositorioMonedas = repositorioMonedas;
            this.mapper = mapper;
        }


        //+ A Verbo/accion http
        [HttpGet]
        //+B-Devuelve ActionResult<Tipo>
        //api/Monedas 
        public async Task<ActionResult<IEnumerable<Moneda>>> ObtenerMonedas()
        {
            await repositorioMonedas.AgregarMonedas();

            var lista = await repositorioMonedas.ObtenerMonedasAsync();

            //+C- Devolver resultado y codigo de estado

            return Ok(lista);//Esto es como la vista

        }

        //api/Monedas/{Codigomoneda}
        [HttpGet("{CodigoMoneda}", Name = "ObtenerMoneda")]
        public async Task<ActionResult<MonedaDTO>> ObtenerMoneda([FromRoute] string CodigoMoneda)
        {

            Moneda moneda = await repositorioMonedas.ObtenerMonedaAsync(CodigoMoneda);

            if (moneda == null)
            {
                //! STATUS = 404
                return NotFound();
            }

            //+C- Devolver resultado y codigo de estado

            return Ok(mapper.Map<MonedaDTO>(moneda));//Esto es como la vista


        }//No devuelve vistas


        //api/Monedas
        [HttpPost]
        public async Task<ActionResult<MonedaDTO>> CrearMoneda(
            MonedaForCreationDto moneda)
        {

            var monedaEntidad = mapper.Map<Entities.Moneda>(moneda);

            bool fail = await repositorioMonedas.AgregarMoneda(monedaEntidad);

            if (fail) return BadRequest("The object already exists.");

            var monedaToReturn = mapper.Map<MonedaDTO>(monedaEntidad);

            return CreatedAtRoute("ObtenerMoneda",
                new { CodigoMoneda = monedaToReturn.Code },
                monedaToReturn);
        }

        //api/Monedas/{Codigomoneda}
        [HttpDelete("{CodigoMoneda}")]
        public async Task<ActionResult> DeleteCourseForAuthor(
      string CodigoMoneda)
        {

            var moneda = await repositorioMonedas
                .ObtenerMonedaAsync(CodigoMoneda);

            if (moneda == null)
            {
                return NotFound();
            }

            await repositorioMonedas.BorrarMoneda(moneda);
            await repositorioMonedas.SaveAsync();

            return Ok();
        }

        ///api/Monedas/{CodigoMoneda}
        [HttpPut("{CodigoMoneda}")]
        public async Task<IActionResult> ActualizarMoneda(String CodigoMoneda, MonedaParaActualizarDto monedaParaActualizarDto)
        {
            //comprobar que la request es correcta
            if (CodigoMoneda.ToLower() != monedaParaActualizarDto.Code.ToLower())
            {
                return BadRequest();
            }

            //+1-Comprobar si existe regstro (await)
            if (!await repositorioMonedas.ExisteMonedaAsync(CodigoMoneda))
            {
                return NotFound();
            }


            //+2-Obtener registro (await)

            Moneda monedaDelRepo = await repositorioMonedas
                .ObtenerMonedaAsync(CodigoMoneda);


            //+3 Mapear de DTO que entra a entidad

            mapper.Map(monedaParaActualizarDto, monedaDelRepo);

            //+4- Actualizar mediante repos
            //repositorioMonedas.UpdateCourse(courseForAuthorFromRepo); No hace falta

            //+5-Guardar cambios (await)
            await repositorioMonedas.SaveAsync();

            //+6-Devolver no content 
            //También se podría devolver ok
            return Ok();
        }
    }
}
