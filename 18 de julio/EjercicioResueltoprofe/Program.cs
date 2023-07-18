
using Entidades;
using System.Text.Json.Serialization;

namespace EjercicioResueltoprofe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear y asignar propiedades mediante la instancia - FORMA 1
            var jose = new Empleado();
            jose.Nombre = "Jose";
            jose.FechaAlta = new DateTime(2021, 01, 10); //Pasas fecha
            jose.Salario = 20000;
            jose.Alta = true;
            jose.fijarNivel(Empleado.Nivel.excelente);

            // FORMA 2
            var maria = new Empleado()
            {
                Nombre = "Maria",
                FechaAlta = new DateTime(2021, 01, 10),
                Salario = 20000,
                Alta = true
            };
            maria.fijarNivel(Empleado.Nivel.excelente);

            // Con constructores. Crear instancia y pasar par. al constructor - FORMA 3
            var juan = new Empleado("Juan", 2000, new DateTime(2023, 01, 15), true);


            //Listas son genéricas
            var numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            numeros.Add(9);

            var lista = new List<Empleado>();
            lista.Add(maria);
            lista.Add(jose);
            lista.Add(juan);

            juan.fijarNivel(Empleado.Nivel.excelente);
            
            //recorre la lista:

            foreach (var empleado in lista) {

               // empleado.CalcularAumentoSalario();
            }

        }
    }
}