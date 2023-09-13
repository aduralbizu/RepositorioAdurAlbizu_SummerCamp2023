
using Contexto;
using Entidades;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Repositorios
{
    internal class RepositorioPersonas
    {

        private ContextoPersonas context;

        public RepositorioPersonas( ContextoPersonas _contexto)
        {
            context = _contexto;
        }

        public async Task<bool> AgregarPersonaAsync(Persona persona)
        {

            var exists = await UsuarioExistsAsync(persona.Nombre);

            if (!exists)
            {
                context.Usuario.Add(usuario);
                return true;
            }
            return false;

        }


    }
}
