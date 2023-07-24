
namespace EjemploHerencia

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Object juan = new Empleado("Juan");
            Console.WriteLine(juan.ToString());

            Administrador maria = new Administrador("Maria", true);

            ((Trabajador)juan).Jefe = maria;

            Empleado jose = new Trabajador("jose", "Tarde");
            jose.Jefe = maria;


            Empleado luis = new Externo("Luis", new Empresa { Nombre = "ACME", Telefono = "555-123123" });

            var lista = new List<Empleado>() {
                    (Trabajador) juan,
                    jose,
                    maria,
                    new Trabajador("luis","Mañana"),
                    luis
            };


            foreach (var empleado in lista)
            {
                if (empleado.Nombre.StartsWith("J"))
                {
                    empleado.CalculoVacaciones();

                    
                }

            }

            // SELECT * FROM empleados where empleados.Nombre.StartsWith("J")

            IEnumerable<Empleado> listaEmpleadosJ = from empleado in lista
                               where empleado.Nombre.StartsWith("J")
                               orderby empleado.Nombre
                               select empleado;


            foreach (var empleado in lista)
            {
               
             
                   var tipo = empleado.GetType().Name;


                switch (tipo)
                {
                    case "Trabajador":
                        // TODO: Mostrar turno
                        var trabajador = (Trabajador)empleado;
                        Console.WriteLine(trabajador.Turno);
                        break;
                    case "Administrador":
                        // TODO: Mostrar plaza de parking 
                        var administrador = (Administrador)empleado;
                        if (administrador.TieneParking)
                        {
                            Console.WriteLine(administrador.PlazaParking());
                        }
                        break;

                    case "Externo":
                        // TODO: Mostrar nombre de empresa
                        var externo = (Externo)empleado;
                        Console.WriteLine(externo.Empresa.Nombre);
                        break;
                    default:
                        break;
                }

                empleado.CalculoVacaciones();




            }



            try
            {
                if (maria.TieneParking)
                {
                    Console.WriteLine(maria.PlazaParking());
                }
            }
            catch (Exception ex)
            {

                //throw;
            }






        }
    }
}