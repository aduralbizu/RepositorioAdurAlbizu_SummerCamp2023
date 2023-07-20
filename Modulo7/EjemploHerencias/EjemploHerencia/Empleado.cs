using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    public partial class Empleado
    {
        public String? Telefono { get; set; }


        protected double diasVacaciones;

        public override string ToString()
        {
            return $"[ Empleado.Nombre: {Nombre}" + 
                $" Dias Vacaciones: {diasVacaciones}" +
                $" Tipo: Empleado ]";
        }
    } 
}
