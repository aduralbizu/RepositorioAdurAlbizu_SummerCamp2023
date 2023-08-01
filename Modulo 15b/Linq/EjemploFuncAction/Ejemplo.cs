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
        internal void EjemploAction()
        {
            //Llamar a TestAcction pasandole metodo como parametro
            TestAction(Accion, 1);

            //Llamat a testaction escribiendo la expresion lambda
            //como parametro entre las dos parentesis

            TestAction((x) => Console.WriteLine($"En el metodo Accion {x}")
                            , 1); //Definido el tipo en testaction no en estas líneas

            //Se puede poner bloque

            //1- Crear una variable que almacene la accion
            //2-Llamar a Testacion pasandole la variable y el valor 1

            Action <int> accion = (y) => {


             Console.WriteLine($"En el metodo Accion {y}");
                    
             
             };

            TestAction(accion, 1);

            //lista de acciones:

            List <Action<int>> listaAcciones = new List <Action<int>>();

            listaAcciones.Add( accion );
            listaAcciones.Add ( AccionMetodo );

            foreach (var elementoAccion  in listaAcciones)
            {

                elementoAccion(1);
            }


        }

        //metodo que recibe un Action<int> y un int
        //Dentro ha de llamar al Action pasado como parametro

        public void TestAction(Action<int> accion, int numero)
        {
            accion(numero);
        }

        public void Accion(int numero)
        {
            Console.WriteLine($"En el metodo Accion { numero}");
        }
            
            //void porque acciones no devuelvenm nada, funciones si
        internal void EjemploFunc()
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

            Func<int,int,int> sumar =
                //Parametros:
                (x,y)
                //operador lamda:
                =>
                //Delegado / Método anónimo / Expresión:
                x+y;


            Console.WriteLine(sumar(10, 20));


        }

        public void AccionMetodo(int numero)
        {
            Console.WriteLine($"En el metodo Accion {numero}");

        }


    }
}
