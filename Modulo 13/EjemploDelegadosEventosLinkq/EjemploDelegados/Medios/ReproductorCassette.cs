using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class ReproductorCassette
    { 

        public bool ProbarCassete()
        {
            Console.WriteLine("Por favor, ponga el cassette en el reproductor");
            Console.WriteLine("Indique a continuación si ha escuchado algo S/N");

            var result = Console.ReadLine();

            //Equivale a if (result=="S")/else
            return result == "S";

        }

        public string ObtenerinfoCassette(string codigoBarras)
        {
            return "Info cassette la tienes aquí: blablabla...";
        }
    }
}
