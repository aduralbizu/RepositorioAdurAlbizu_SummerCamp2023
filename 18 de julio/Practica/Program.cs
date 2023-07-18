using Entidades2;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coche1 = new Vehiculo(1000, 6);
            var coche2 = new Vehiculo(1000, 9);
            var coche3 = new Vehiculo(1000, 36);
            var coche4 = new Vehiculo(1000, 36);

            coche1.fijarEtiqueta(Vehiculo.Etiqueta.B);
            coche2.fijarEtiqueta(Vehiculo.Etiqueta.C);
            coche3.fijarEtiqueta(Vehiculo.Etiqueta.CERO);
            coche4.fijarEtiqueta(Vehiculo.Etiqueta.ECO);

            var lista = new List<Vehiculo>();

            lista.Add(coche1);
            lista.Add(coche2);
            lista.Add(coche3);
            lista.Add(coche4);
            

            foreach (var coche in lista)
            {
                coche.calcularValor();
            }

        }
    }
}