
using DataProcessor;
using Newtonsoft.Json;

namespace ImportarJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string json = @"{
             'Name': 'Bad Boys',
             'ReleaseDate': '1995-4-7T00:00:00',
             'Genres': [
                'Action',
                'Comedy'
              ]
             }";

            Movie m = JsonConvert.DeserializeObject<Movie>(json);

            string name = m.Name;

            Console.WriteLine(name);
            */
            // Bad Boys


           //Ejercicio de hoy:
           string json = File.ReadAllText(@"C:\prueba2\Modulo 81\04-demos\before\02TextFileLines\ImportarJson\Monedas.json");

           List <Moneda> monedas = JsonConvert.DeserializeObject< List <Moneda>>(json);

           Console.WriteLine("LISTA MONEDAS: \n");

           foreach (Moneda moneda in monedas)
           {
                
               string name = moneda.nombre;
               string codigo = moneda.codigo;
               float valorEnDolares = moneda.valorEnDolares;
               Console.WriteLine($"Name: {name}");
               Console.WriteLine($"Codigo: {codigo}");
               Console.WriteLine($"Valor en dólares: {valorEnDolares}");
               Console.WriteLine();
                            
           }


        }
    }
}