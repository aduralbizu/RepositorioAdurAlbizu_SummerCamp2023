using EjemploDelegados.Medios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class InventarioMedios
    {

        //          1                    2
        //        bool ProbarCd         ()
        // public bool ProbarVinilo     ()
        //  public bool ProbarVhs        ()

        //Declaarar el delegado probar medios
        //               1                        2
        public delegate bool ProbarMediosDelegado();

        // Delegado para mostrar info del medio:
        public delegate string InfoMedioDelegado(string id); //Se le pasa codigo de barras o lo que sea


        /* Ejemplo fallido:
         
           var tipo = medio.GetType().FullName; //por reflexión


           if (tipo == "Tocadiscos")
           {
               var objeto = (Tocadiscos)medio;

               if (objeto.ProbarVinilo())
               {
                   Console.WriteLine("instrucciones para almacenar vinilo");
               }
               //Si tuvieramos 200 clases, situacion problemática. ¿Cómo resolvemos?
           }
           */



        public void ResultadoProbarMedios(ProbarMediosDelegado probarMediosDelegado) { //No llega clase entera, sino solo el metodo

            //1-Recibir el medio a probar 
            //2-Probar el medio
            //3-Si el medio se ha podido reproducir indicar cómo archivarlo
            //

            var resultadoPrueba = probarMediosDelegado();
            if (resultadoPrueba)
            {
                Console.WriteLine("El medio funciona, " + "hay que agregarlo al inventario");

            }
            else
            {
                Console.WriteLine("El medio no funciona, hay que destruirlo");
            }

        }
            
        


    }
}
