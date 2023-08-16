﻿
namespace ConversorWeb.Models
{
    public interface IRepositorioMonedas
    {
        IEnumerable<Moneda> ObtenerMonedas();

        Moneda ObtenerMoneda(string codigo);
        void AgregarMoneda(Moneda moneda);
    }
}
