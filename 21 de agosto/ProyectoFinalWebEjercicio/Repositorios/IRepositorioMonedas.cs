using Entities;

namespace Repositorios
{
    public interface IRepositorioMonedas
    {
        Task<Moneda> ObtenerMonedaAsync(string codigo);

        Task<IEnumerable<Moneda>> ObtenerMonedasAsync();
        Task AgregarMoneda(Moneda moneda);

        Task AgregarMonedas();
    }
}
