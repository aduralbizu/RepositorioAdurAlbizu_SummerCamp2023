using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public partial class Empleado
    {
        public string Nombre
        {
            get;
            set;

        }
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public Empleado Jefe { get; set; }

        //public Empleado()
        // {
        //  Nombre = "";
        // }

    }
}