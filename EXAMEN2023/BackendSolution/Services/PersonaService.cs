using Persistence.Entities;
using Repositories.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }
        public async Task<IEnumerable<Persona>> GetPersonasOrdenadas()
        {
            return await _personaRepository.GetPersonasOrdenadas(); 
        }
        public async Task CrearPersona(Persona persona)
        {
            if (persona == null)
            {
                throw new ArgumentNullException(nameof(persona));
            }
            await _personaRepository.CrearPersona(persona);
        }

        public async Task<Persona?> GetPersonaPorNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentNullException(nameof(nombre));
            }
            return await _personaRepository.GetPersonaPorNombre(nombre);
        }
    }
}
