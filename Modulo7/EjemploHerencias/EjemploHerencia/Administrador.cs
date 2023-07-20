using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjemploHerencia;

namespace EjemploHerencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre) : base(nombre)
        {
        }

        public override string ToString()
        {
            return $"[ Empleado.Nombre: {Nombre}" +
                $" Dias Vacaciones: {diasVacaciones}" +
                $" Tipo: Administrativo ]";
        }
    }
}