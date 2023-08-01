using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLinq
{
    public class EjemploBasico
    {
        public EjemploBasico()
        {
        }

        public void Ejecutar()
        {

            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            int nc = niveles.Count();

            //Selecciona todos los niveles cuya longitud
            //de caracteres sea mayo0r que 6, ordenado por nivel

            //+Version sin linq:

            var listaConsultaForEach = new List<string>();

            foreach (string nivel in niveles) { 
            
                if (nivel.Length > 6)
                {
                    listaConsultaForEach.Add(nivel);
                }
                //Y luego harias algún sorting alorithm
            }

            //+Version con linq:
            //sintaxis sql:
            //Select nivel from niveles where nivel.lengthh > 6 order by nivel

            //1-Preparación
            var Consultalinq = from nivel in niveles //en realidad no var, iorderedenumerable. De momento no poner así
                                     where nivel.Length > 6
                                     orderby nivel
                                     select nivel;


            //2- Obtener resultados

            List <string> listaResultados = Consultalinq.ToList();

            //Sintaxis de métodos:
            //1- Preparación:
            // Func<string, bool> predicado = nivel => nivel.Length > 6;
            // var consultaLinqMetodos = niveles.Where(predicado);     Esto era solo un ejemplo

            var consultaLinqMetodos = niveles.Where(nivel => nivel.Length > 6)
                                             .OrderBy(nivel => nivel)
                                             .Select(nivel => nivel); //Cubo: Método de extensión | Método es fluido: resultado de nivel->where
            //2-Resultados:
            List<string> listaResultadosLinqMetodos = consultaLinqMetodos.ToList();

            


        }
    }
}