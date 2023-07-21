

namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

       

            Empleado juan = new Empleado("Juan");
            //Console.WriteLine(juan.ToString());

            Administrador maria = new Administrador("Maria",true);

            juan.Jefe = maria; //El jefe de juan es maria;

            Empleado jose = new Trabajador("jose","tarde");
            jose.Jefe = maria;

            Empleado luis = new Externo("Luis", new Empresa { Nombre = "ACME", Telefono = 94398348 });

            var lista = new List<Empleado>()
            {
                juan, //Casting: convertir de un tipo a otro. Esto es una conversión temporal
                jose,
                maria,
                new Trabajador("Luis", "Mañana"),
                luis

            };

            foreach (var empleado in lista)
            {

                if (empleado.Nombre.ToLower().StartsWith('j'))
                {
                    empleado.CalculoVacaciones();
                    Console.WriteLine(empleado.ToString());
                } 

            }





            /* Esto era el ejercicio de ayer: :

            Empleado juan = new Empleado("Juan");
            Administrador jose = new Administrador("Jose");
            Trabajador laura = new Trabajador("Laura");

            Console.WriteLine(juan.ToString());
            Console.WriteLine(jose.ToString());
            Console.WriteLine(laura.ToString());


            */





        }
    }
}