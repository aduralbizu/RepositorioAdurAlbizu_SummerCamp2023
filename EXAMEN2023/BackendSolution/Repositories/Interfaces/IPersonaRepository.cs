using Persistence.Entities;

namespace Repositories.Interfaces
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetPersonasOrdenadas();
        Task CrearPersona(Persona persona);
        Task<Persona?> GetPersonaPorNombre(string nombre);

    }
}
