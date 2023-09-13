using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Contexto
{
    public class ContextoPersonas : DbContext
    {

        public ContextoPersonas(DbContextOptions<ContextoPersonas> opciones) : base(opciones)
        {

        }
        public DbSet<Persona> Persona { get; set; }


    }
}