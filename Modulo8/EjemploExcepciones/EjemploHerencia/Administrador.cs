using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjemploHerencia;

namespace EjemploHerencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, bool plaza, int numplaza) : base(nombre)
        {
            Plaza = plaza;
            Numplaza = numplaza;
        }

        public bool Plaza { get; }
        public int Numplaza { get; }

        public override string ToString()
        {
            return $"[ Empleado.Nombre: {Nombre}" +
                $" Dias Vacaciones: {diasVacaciones}" +
                $" Tipo: Administrativo ]";
        }
    }
}