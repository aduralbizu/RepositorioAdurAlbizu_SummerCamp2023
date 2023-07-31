using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFuncAction
{
    internal class Ejemplo
    {
        internal void EjemploDelegados1()
        {
            // Expresion Lambda mediante Expresion func<>

            Func<string> holaMundoExpresion =
                //Parametros:
                ()
                //operador lamda:
                =>
                //Delegado / Método anónimo / Expresión:
                "Hola Mundo !!!!!!!!";


            Console.WriteLine(holaMundoExpresion); //Son diferentes
            Console.WriteLine(holaMundoExpresion());

            //Extension lambda mediante bloque func<>

            Func<string> holaMundoBloque =
                //Parametros:
                ()
                //operador lamda:
                =>
                //Delegado / Método anónimo : No es una expresion!!
                { 
                    var cadena = "hola Mundo";
                    return cadena;

                 };

            Console.WriteLine(holaMundoBloque());

            //ejercicio (calculadora sencilla):
            //Crear una expresion lambda que sume dos numeros

            //Funcion:

            Func<int,int,string> sumar =
                //Parametros:
                (x,y)
                //operador lamda:
                =>
                //Delegado / Método anónimo / Expresión:
                (x+y).ToString();


            Console.WriteLine(sumar(10, 20));





        }


    }
}
