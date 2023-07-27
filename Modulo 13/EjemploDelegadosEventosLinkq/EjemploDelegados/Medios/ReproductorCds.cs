using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class ReproductorCds
    {
        //Firma: bool     nada
        public bool ProbarCd()
        {
            Console.WriteLine("Por favor, ponga el CD en el reproductor");
            Console.WriteLine("Pulsa el botón de reproducción");
            Console.WriteLine("Indique a continuación si ha escuchado algo S/N");

            var result = Console.ReadLine();

            //Equivale a if (result=="S")/else
            return result == "S";

        }

        public string ObtenerCancionesCD(string codigoBarras)
        {
            return "lista de canciones es esta: ...";
        }
    }
}
