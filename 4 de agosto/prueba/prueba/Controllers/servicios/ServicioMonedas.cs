
using prueba.Controllers.servicios;
using prueba.Models;

namespace EjemploMvcConversor.Servicios
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
