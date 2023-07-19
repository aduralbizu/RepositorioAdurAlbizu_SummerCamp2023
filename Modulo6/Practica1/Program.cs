using static Practica1.Vehiculo;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coche1 = new Vehiculo(new DateTime(2006,01,06),"Azul");
            var coche2 = new Vehiculo( "Wolskwagen","Polo");
            var coche3 = new Vehiculo(new DateTime(2020,01,06), "Opel","Corsa","Negro");
            var coche4 = new Vehiculo(new DateTime(2022,01,06), "Nissan","X-trail","Naranja");

            var lista = new List<Vehiculo>();

            lista.Add(coche1);
            lista.Add(coche2);
            lista.Add(coche3);
            lista.Add(coche4);

            var index = 0;
            foreach (var coche in lista) {
                Console.WriteLine("Coche no."+ ++index );
                coche.imprimirCoche();
                
            }


        }
    }
}