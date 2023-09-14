using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones) { }

        public DbSet<Persona> Personas { get; set; }
    }

}
