using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EjemploMvcConversor.Models
{

    // 1-Desde la consola del administrador de paquetes NuGet escribimos
    //        add-migration "inicial"
    // 2-Crear la BBDD mediante el siguiente comando (Tambien desde la consola)
    //        update-database



    public class ContextoConversor :DbContext
    {

        public ContextoConversor(DbContextOptions<ContextoConversor> opciones) : base(opciones)
        {
            
        }

        public DbSet<Moneda> Monedas { get; set; }
        public DbSet <Pais> pais { get; set; }

    }

    //1- Desde lla concsola del administrados de paquetes nuget
    //escribimos add-migration "inicial"
    //2- Crear la bbd mediante el diguiente comanfdo (tambien desddee consola)
    //update-database

    //herramientas>administrador de pauetes nugget>consola
    //add-migration inicial. Se creara migration

    //update-database
}
