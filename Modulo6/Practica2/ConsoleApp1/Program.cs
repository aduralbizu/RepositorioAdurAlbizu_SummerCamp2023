

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection = String.Empty;

            while (selection != "q" && selection != "Q")
            {

                Console.WriteLine("\nChoose one of the following options:" );

                Console.WriteLine("A) Euro to Libra" );
                Console.WriteLine("B) Euro to Dolar" );
                Console.WriteLine("C) Libra to Euro" );
                Console.WriteLine("D) Libra to Dolar" );
                Console.WriteLine("E) Dolar to Euro" );
                Console.WriteLine("F) Dolar to Libra" );


                selection = Console.ReadLine();
                double euro, dolar, libra = 0;

                switch (selection)
                {
                    case "A":
                    case "a":
                        Console.Write("Please enter Euros: ");
                        libra = CurrencyConverter.Euro2Libra(Console.ReadLine());
                        Console.WriteLine($"In libras: {libra:f2}");
                        break;

                    case "B":
                    case "b":
                        Console.Write("Please enter Euros: ");
                        dolar = CurrencyConverter.Euro2Dolar(Console.ReadLine());
                        Console.WriteLine($"In dolars: {dolar:f2}");
                        break;

                    case "C":
                    case "c":
                        Console.Write("Please enter libras: ");
                        euro = CurrencyConverter.Libra2Euro(Console.ReadLine());
                        Console.WriteLine($"In euros: {euro:f2}");
                        break;

                    case "D":
                    case "d":
                        Console.Write("Please enter libras: ");
                        dolar = CurrencyConverter.Libra2Dolar(Console.ReadLine());
                        Console.WriteLine($"In dolars: {dolar:f2}");
                        break;

                    case "E":
                    case "e":
                        Console.Write("Please enter dolars: ");
                        euro = CurrencyConverter.Dolar2Euro(Console.ReadLine());
                        Console.WriteLine($"In euros: {euro:f2}");
                        break;

                    case "F":
                    case "f":
                        Console.Write("Please enter dolars: ");
                        libra = CurrencyConverter.Dolar2Libra(Console.ReadLine());
                        Console.WriteLine($"In libras: {libra:f2}");
                        break;

                    default:
                        Console.WriteLine("Please try again.");
                        break;

                }


            }
        }
    }
}