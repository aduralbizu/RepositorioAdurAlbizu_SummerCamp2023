

using System.Diagnostics;

namespace Entidades2
{
      public class Vehiculo
    {
        public enum Etiqueta
        {
            sinEtiqueta,
            B,
            C,
            ECO,
            CERO
        }


        public double Valor { get; set; }
        public double ValorBase { get; set; }
        public int Antiguedad { get; set; }
        private Etiqueta _etiqueta { get; set; }


        public void fijarEtiqueta(Etiqueta etiqueta)
        {
            this._etiqueta = etiqueta;
        }

        public Vehiculo(double valorbase, int antiguedad)
        {
            ValorBase = valorbase;
            Valor = valorbase;
            Antiguedad = antiguedad;
        }

        public void calcularValor() 
        {
            Console.WriteLine("Antiguedad: " + Antiguedad);
            var factor = 0.01*Antiguedad;
            Console.WriteLine("Sumamos:0.01 * " + Antiguedad + " * "+ Valor);
            Valor += factor * ValorBase;
            Console.WriteLine("Resultado suma: " + Valor);

            Console.WriteLine("La etiqueta del vehículo es " + _etiqueta);

            switch (_etiqueta)
            {
                case Etiqueta.sinEtiqueta:
                    Valor += ValorBase * 0.25;
                    Console.WriteLine("Se suma 0.25 del valor base: "+ ValorBase+" * 0.25"+ "= + "+ ValorBase*0.25);
                    break;
                case Etiqueta.B:
                    Valor += ValorBase * 0.15;
                    Console.WriteLine("Se suma 0.15 del valor base: "+ ValorBase+" * 0.15"+ "= + "+ ValorBase*0.15);
                    break;
                case Etiqueta.C:
                    Valor += ValorBase * 0.10;
                    Console.WriteLine("Se suma 0.10 del valor base: "+ ValorBase+" * 0.10"+ "= + "+ ValorBase*0.10);
                    break;
                case Etiqueta.ECO:
                    Valor += ValorBase * 0.05;
                    Console.WriteLine("Se suma 0.05 del valor base: "+ ValorBase+" * 0.05"+ "= + "+ ValorBase*0.05);
                    break;
                case Etiqueta.CERO:
                    Console.WriteLine("No se suma nada");
                    break;
            }

            Console.WriteLine("El valor final es: "+Valor);
            Console.WriteLine();

        }
    }


    
}

