﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjemploHerencia;

namespace EjemploHerencia
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre, string turno) : base(nombre)
        {
            Turno = turno;
        }

        public string Turno { get; }

        public override string ToString()
        {
            return $"[ Empleado.Nombre: {Nombre}" +
                $" Dias Vacaciones: {diasVacaciones}" +
                $" Tipo: Trabajador ]";
        }
    }
}