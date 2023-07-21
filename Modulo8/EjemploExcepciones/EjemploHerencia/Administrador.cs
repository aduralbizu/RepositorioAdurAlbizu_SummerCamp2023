using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjemploHerencia;

namespace EjemploHerencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, bool tieneParking) : base(nombre)
        {
            TieneParking = tieneParking;
            
        }

        public bool TieneParking { get; }

        public override string ToString()
        {
            return $"[ Empleado.Nombre: {Nombre}" +
                $" Dias Vacaciones: {diasVacaciones}" +
                $" Tipo: Administrativo ]";
        }

        public String plazaParking()
        {
            return TieneParking ? "Plaza A-1" : "No tiene Plaza";
        }
        public virtual void CalculoVacaciones() //Virtual porque puede ocurrir que en padre no defina nada
        {
            diasVacaciones += 9; //no lllamamos a base!!!!
        }


    }
}