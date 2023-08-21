using prueba.Models;

namespace prueba.servicios
{
    public class ServicioMonedas : IServicioMonedas
    {

        public List<Moneda> Monedas { get; set; }


        public List<Moneda> ObtenerMonedas()
        {
            return Monedas;
        }


    }
}
