namespace EjemploMvcConversor.Models
{
    public interface IRepositorioMonedas
    {
        IEnumerable<Moneda> ObtenerMonedas();
        Moneda ObtenerMoneda(int id);

        //va a dar de allta a  monedas:

        void AgregarMoneda(Moneda moneda);



    }
}
