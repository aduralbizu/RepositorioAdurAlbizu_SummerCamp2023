using System.Security.Cryptography;

namespace EjemploLinq
{
    public class EjemploOperador1
    {
        public EjemploOperador1()
        {
        }

        public void Ejecutar()
        {
            // Lista de empleados
            IEnumerable<Empleado> Empleados = new List<Empleado>()
         {

             new Empleado
             {
                 Nombre = "Jose",
                 Apellidos = "Conde",
                 Ciudad = "Madrid",
                 Telefono = "123456789",
                 Departamento = Departamento.Desarrollo
             },
             new Empleado
             {
                 Nombre = "Luis",
                 Apellidos = "Castillo",
                 Ciudad = "Madrid",
                 Telefono = "423456789",
                 Departamento = Departamento.Soporte
             },
             new Empleado
             {
                 Nombre = "Juan",
                 Apellidos = "Nuñez",
                 Ciudad = "Barcelona",
                 Telefono = "9123456789",
                 Departamento = Departamento.RH
             },
             new Empleado
             {
                 Nombre = "Maria",
                 Apellidos = "Garcia",
                 Ciudad = "Valencia",
                 Telefono = "8123456789",
                 Departamento = Departamento.Admin
             }

          };
          

            // Define una list consulta LINQ con los empleados definidos anteriormente donde:
            // El Departamento sea Desarrollo o Soporte
            // El apellido empiece por C
            // Devuelve el resultado en orden descendente por nombre en una lista

            List<Empleado> empleadosDesarrolloSoporte = Empleados
                                             .Where(empleado =>
                                                       (empleado.Departamento == Departamento.Desarrollo ||
                                                       empleado.Departamento == Departamento.Soporte)
                                                        && empleado.Apellidos.StartsWith("C")
                                                    )
                                             .OrderByDescending(empleado => empleado.Nombre)
                                             .Select(empleado => empleado)
                                             .ToList();

            List<Empleado> empleadosDesarrolloSoporteConsulta = (from empleado in Empleados
                                                                 where (empleado.Departamento == Departamento.Desarrollo ||
                                                                   empleado.Departamento == Departamento.Soporte)
                                                                   && empleado.Apellidos.StartsWith("C")
                                                                 orderby empleado.Nombre descending
                                                                 select empleado).ToList(); //La otra forma


            // Listado de los  telefonos de los empleados de Madrid
            // que contengan en su apellido una "a"
            // ordenado por nombre

           var empleadosTelefonoMadrid = Empleados.Where(e => e.Apellidos.Contains("a"))
                                             .OrderBy(e => e.Nombre)
                                             .Select(e => e.Telefono)
                                             .ToList();
           
           var Empleadosportelefono = (from empleado in Empleados 
                                       where (empleado.Apellidos.StartsWith("C")) 
                                       orderby empleado.Nombre 
                                       ascending select empleado.Telefono).ToList();

            // Proyecciones: Listado de los  telefonos y ciudades de los empleados de Madrid
            // que contengan en su apellido una "a"
            // ordenado por nombre

           var Empleadosportelefono1 = (from empleado in Empleados
                                        where (empleado.Apellidos.StartsWith("C"))
                                        orderby empleado.Nombre ascending
                                        select new {telefono = empleado.Telefono,
                                            Ciudad = empleado.Ciudad
                                        }).ToList(); /*{telefono = empleado.Telefono,
                                                    ciudad = empleado.Ciudad}* A esto se le llama tipo anónimo*/

            foreach(var resultado in Empleadosportelefono1)
            {
                Console.WriteLine(resultado.Ciudad);
                
            }

            //Agregar esta lista a los antiguos empleados
            //No se permite el uso de lista.ad
            //se agregan todos de una vez

            var empleadosNuevos = new List<Empleado>            {                new Empleado                {                    Nombre = "Fabricio",                    Apellidos = "Cordero",                    Departamento = Departamento.Desarrollo                },                new Empleado                {                    Nombre = "Julia",                    Apellidos = "Lombardo",                    Departamento = Departamento.Admin                },            };

            List<Empleado> empleadosAntiguos = Empleados.Select(empleado => empleado).ToList();
            empleadosAntiguos.AddRange(empleadosNuevos);

                                                   
            
            

            

        }
    }
}