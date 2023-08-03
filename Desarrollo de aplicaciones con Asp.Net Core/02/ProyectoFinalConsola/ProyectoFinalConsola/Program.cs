using Entidades;

namespace ProyectoFinalConsola
{
    public class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.Ejecutar();

            ProbadorApi.Run().Wait();

            
 
        }
    }
}