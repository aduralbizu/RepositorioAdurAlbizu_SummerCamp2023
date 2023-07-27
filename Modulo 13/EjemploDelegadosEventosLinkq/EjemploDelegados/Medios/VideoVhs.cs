using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class VideoVhs
    {
        //Firma: bool     nada

        public bool ProbarVhs()
        {
            Console.WriteLine("Por favor, ponga la cinta ene el reproductor");
            Console.WriteLine("Indique a continuación si ha escuchado algo S/N");

            var result = Console.ReadLine();


            //Equivale a if (result=="S")/else
            return result == "S";
        }

        public string ObtenerinfoPeli(string codigoBarras)
        {
            return "Info peli la tienes aquí: blablabla...";
        }
    }
}
