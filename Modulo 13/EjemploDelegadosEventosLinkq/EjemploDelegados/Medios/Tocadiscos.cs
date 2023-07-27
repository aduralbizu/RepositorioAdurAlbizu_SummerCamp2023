using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class Tocadiscos
    {
        //Firma: bool     nada
        public Tocadiscos() { }
        public bool ProbarVinilo()
        {
            Console.WriteLine("Por favor, mete el vinilo en el tocadiscos");
            Console.WriteLine("Indique a continuación si ha escuchado algo S/N");

            var result = Console.ReadLine();


            //Equivale a if (result=="S")/else
            return result == "S";
        }

        public string ObtenerCancionesDisco (string codigoBarras)
        {

            //buscar en BBDD codigo de barras
            //devolver el resultado

            return "lista de canciones está en la contraportada";
        }
    }
}

//Para que todo el mundo lo haga mas o menos igual: 