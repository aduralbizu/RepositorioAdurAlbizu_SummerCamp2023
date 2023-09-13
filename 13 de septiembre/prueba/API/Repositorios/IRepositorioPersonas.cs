
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public interface IRepositorioPersonas
    {

        Task<bool> AgregarPersonaAsync(Persona persona);


    }
}
