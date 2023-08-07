
using prueba.Controllers.servicios;
using prueba.Models;

namespace EjemploMvcConversor.Servicios
{
    public class ServicioMonedas : IServicioMonedas
    {
        private readonly ILogger<ServicioMonedas> logger; //La inyección de dependencias se usa en muchos iguales
        public ServicioMonedas(ILogger<ServicioMonedas> logger)
        {
            this.logger = logger;
        }
        public List<Moneda> Monedas { get; set; }


        public List<Moneda> ObtenerMonedas()
        {
            return Monedas;
        }


    }
}
