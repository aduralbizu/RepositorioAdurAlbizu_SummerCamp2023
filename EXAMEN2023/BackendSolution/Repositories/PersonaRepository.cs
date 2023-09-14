using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Entities;
using Repositories.Interfaces;

namespace Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Persona>> GetPersonasOrdenadas()
        {
            DateTime fechaLimite = DateTime.Now.AddYears(-21);
            return await _context.Personas
                .Where(persona => persona.FechaNacimiento <= fechaLimite)
                .Take(10).OrderBy(persona => persona.Nombre).ToListAsync();
        }

        public async Task CrearPersona(Persona persona)
        {
            _context.Add(persona);
            await _context.SaveChangesAsync();
        }

        public async Task<Persona?> GetPersonaPorNombre(string nombre)
        {
            return await _context.Personas
                .Where(persona => persona.Nombre.ToUpper().Equals(nombre.ToUpper()))
                .FirstOrDefaultAsync();
        }
    }
}
