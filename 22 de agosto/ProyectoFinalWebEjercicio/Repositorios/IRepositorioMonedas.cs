﻿using Entities;

namespace Repositorios
{
    public interface IRepositorioMonedas
    {
        Task AgregarMoneda(Moneda moneda);

        Task AgregarMonedas();

        Task BorrarMoneda(Moneda moneda);

        Task<Moneda> ObtenerMonedaAsync(string codigo);

        Task<IEnumerable<Moneda>> ObtenerMonedasAsync();

        Task<bool> SaveAsync();
    }
}
