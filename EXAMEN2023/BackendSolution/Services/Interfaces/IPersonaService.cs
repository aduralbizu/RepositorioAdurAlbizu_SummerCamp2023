using Persistence.Entities;

namespace Services.Interfaces
{
    public interface IPersonaService
    {
        Task<IEnumerable<Persona>> GetPersonasOrdenadas();
        Task CrearPersona(Persona persona);
        Task<Persona?> GetPersonaPorNombre(string nombre);
    }
}
