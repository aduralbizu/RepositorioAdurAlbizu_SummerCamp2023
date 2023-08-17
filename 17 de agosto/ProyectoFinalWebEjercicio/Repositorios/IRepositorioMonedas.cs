using Models;

namespace Repositorios
{
    public interface IRepositorioMonedas
    {
        IEnumerable<Moneda> ObtenerMonedas();

        Moneda ObtenerMoneda(string codigo);
        void AgregarMoneda(Moneda moneda);

        void AgregarMonedas();
    }
}
