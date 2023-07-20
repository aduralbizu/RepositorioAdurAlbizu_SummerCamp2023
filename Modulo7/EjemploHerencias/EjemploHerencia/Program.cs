

namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Esto es el ejemplo:

            Empleado juan = new Empleado("Juan");
            Console.WriteLine(juan.ToString());

            Administrador maria = new Administrador("Maria");

            juan.Jefe = maria; //El jefe de juan es maria;

            Object jose = new Trabajador("jose");
            Console.WriteLine(jose.ToString());

            */

            //Ahora el ejercicio:

            Empleado juan = new Empleado("Juan");
            Administrador jose = new Administrador("Jose");
            Trabajador laura = new Trabajador("Laura");

            Console.WriteLine(juan.ToString());
            Console.WriteLine(jose.ToString());
            Console.WriteLine(laura.ToString());




        }
    }
}