using AutoMapper;
using DTO.Persona;
using Microsoft.AspNetCore.Mvc;
using Persistence.Entities;
using Services.Interfaces;
using Utils;

namespace WebAPI.Controllers
{
    [Route("api/persona")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;
        private readonly IMapper _mapper;
        public PersonaController(IPersonaService personaService, IMapper mapper)
        {
            _personaService = personaService;
            _mapper = mapper;
        }

        [HttpGet("GetPersonasPorOrden")]
        public async Task<ActionResult<IEnumerable<PersonaGetDTO>>> GetPersonasPorOrden()
        {
            try
            {
                var listPersonas = await _personaService.GetPersonasOrdenadas();

                if (listPersonas == null)
                    return Ok(null);

                return Ok(_mapper.Map<IEnumerable<PersonaGetDTO>>(listPersonas));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetType() + " - ERROR DE SERVIDOR " });
            }
        }

        [HttpPost]
        public async Task<ActionResult> CrearPersona([FromBody] PersonaForCreationDTO personaDTO)
        {
            try
            {
                if (personaDTO == null || string.IsNullOrWhiteSpace(personaDTO.Nombre) || personaDTO.FechaNacimiento == null)
                {
                    return BadRequest(new { message = "Formato invalido" });
                }

                if (personaDTO.FechaNacimiento > DateTime.Now)
                {
                    return BadRequest(new { message = "Fecha de nacimiento invalida" });
                }

                if (!string.IsNullOrWhiteSpace(personaDTO.Telefono) && !PersonaUtils.EsTelefonoValido(personaDTO.Telefono))
                {
                    return BadRequest(new { message = "Telefono con formato incorrecto" });
                }

                //persona con dicho nombre ya existe
                if (await _personaService.GetPersonaPorNombre(personaDTO.Nombre) != null)
                {
                    return BadRequest(new { message = "Ya existe una persona con este nombre, elige otro" });
                }

                var personaBD = _mapper.Map<Persona>(personaDTO);
                //verificar que fechaNacimiento sea menor que datetime.now
                await _personaService.CrearPersona(personaBD);
                return Ok(new { message = "Persona creada con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetType() + " - ERROR DE SERVIDOR " });
            }
        }

    }



}
