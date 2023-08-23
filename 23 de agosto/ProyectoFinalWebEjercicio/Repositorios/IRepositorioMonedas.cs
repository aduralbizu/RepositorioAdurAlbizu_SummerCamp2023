using Entities;

namespace Repositorios
{
    public interface IRepositorioMonedas
    {
        Task<bool> AgregarMoneda(Moneda moneda);

        Task AgregarMonedas();

        Task BorrarMoneda(Moneda moneda);

        Task<Moneda> ObtenerMonedaAsync(string codigo);

        Task<IEnumerable<Moneda>> ObtenerMonedasAsync();

        Task<bool> ExisteMonedaAsync(String codigo);

        Task<bool> SaveAsync();
    }
}
