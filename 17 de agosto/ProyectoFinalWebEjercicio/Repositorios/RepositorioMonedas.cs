using Contexto;
using Models;
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

        public void AgregarMoneda(Moneda moneda)
        {

            if (ObtenerMoneda(moneda.Code) == null)
            {
                _context.Moneda.Add(moneda);
                _context.SaveChanges();
            }

        }

        public void AgregarMonedas()
        {
            var listaMonedas = _colector.LeerMonedas();

            //Rellenamos BBDD
            foreach (var moneda in listaMonedas)
            {
                // Añade en la base de datos las monedas que obtiene de la API
                AgregarMoneda(moneda);

            }

        }
        public Moneda ObtenerMoneda(string codigo)
        {
            var moneda = _context.Moneda.FirstOrDefault(x => x.Code == codigo);
            return moneda;
        }

        public IEnumerable<Moneda> ObtenerMonedas()
        {
            return _context.Moneda;
        }
    }
}
