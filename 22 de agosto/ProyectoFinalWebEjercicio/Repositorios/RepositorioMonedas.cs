using Contexto;
using Entities;
using Microsoft.EntityFrameworkCore;
using Utilidades;

namespace Repositorios
{
    public class RepositorioMonedas : IRepositorioMonedas
    {

        private ContextoConversor _context;
        private readonly IDataCollector _colector;

        public RepositorioMonedas(ContextoConversor context, IDataCollector colector)
        {
            _context = context;
            _colector = colector;
        }

        public async Task<bool> AgregarMoneda(Moneda moneda)
        {
            if (await ObtenerMonedaAsync(moneda.Code) == null)
            {
                _context.Moneda.Add(moneda);
                await SaveAsync();
                return false;
            }
            return true;

        }

        public async Task AgregarMonedas()
        {
            var listaMonedas = _colector.LeerMonedas();

            //Rellenamos BBDD
            foreach (var moneda in listaMonedas)
            {
                // Añade en la base de datos las monedas que obtiene de la API
                await AgregarMoneda(moneda);


            }


        }
        public async Task BorrarMoneda(Moneda moneda)
        {
            _context.Moneda.Remove(moneda);
        }
        public async Task<Moneda> ObtenerMonedaAsync(string codigo)
        {
            return await _context.Moneda.FirstOrDefaultAsync(x => x.Code == codigo);

        }

        public async Task<IEnumerable<Moneda>> ObtenerMonedasAsync()
        {
            var proba = await _context.Moneda.ToListAsync();
            return proba;

        }


        public async Task<bool> ExisteMonedaAsync(String codigo)
        {
            if (codigo == null)
            {
                throw new ArgumentNullException(codigo);
            }

            var pro =  await _context.Moneda.AnyAsync(m => m.Code == codigo);

            return pro;
        }

        public async Task<bool> SaveAsync() //Para guardar cambios
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
