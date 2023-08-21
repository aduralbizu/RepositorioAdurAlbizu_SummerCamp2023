

namespace Conversor2.Models
{
    public interface IRepositorioMonedas
    {

        IEnumerable<Moneda> ObtenerMonedas();

        Moneda ObtenerMoneda(int id);


    }
}
