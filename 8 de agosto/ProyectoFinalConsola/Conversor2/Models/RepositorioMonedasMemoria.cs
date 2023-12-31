﻿
namespace Conversor2.Models
{
    public class RepositorioMonedasMemoria:IRepositorioMonedas
    {
        
        public List<Moneda> Lista { get; set; }

        public RepositorioMonedasMemoria()
        {
            Lista = new List<Moneda>() {
            new Moneda { Id = 1, CodigoMoneda = "EUR", Descripcion = "Euro" },
            new Moneda {  Id=2, CodigoMoneda = "USD", Descripcion = "Dolar"},
            new Moneda {  Id=3, CodigoMoneda = "GBP", Descripcion = "Libra"},
            };
        }

        public Moneda ObtenerMoneda(int id)
        {
            return Lista.FirstOrDefault(m=> m.Id == id); //Recuperar el primero que coincida
        }

        public IEnumerable<Moneda> ObtenerMonedas()
        {
            return Lista;
        }
    }
}
