using Extensiones;

namespace EjemploMetodoExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string juan = "JuAn lOpEz".ConvertirCadena();
            string luis = "lUis MaRtinEz".ConvertirCadena();

            var saludo = "hola Mundo!!!";
            var convertir = saludo.ConvertirCadena();


            // Mostrar año de fecha:

            var fecha = DateTime.Now;
            var año = fecha.ObtenerAño();

            //Agregar metodos de extension para comparar dps enteros.

            int a = 1;
            int b = 2;

            //bool esmayorAB = a>b

            if (a.Equals(b)) {

                Console.WriteLine("Es mayor");
            }
            else
            {
                Console.WriteLine("Es menor");
            }

            //obtener el prier element de la lista

            var lista = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var primero = lista.Primero();
        }

       //Linq crea metodos sobre tipos que están cerrados
    }
}