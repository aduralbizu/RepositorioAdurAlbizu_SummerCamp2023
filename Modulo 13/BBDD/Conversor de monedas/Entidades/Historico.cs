using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Historico
    {
        //Moneda origen
        //Moneda destino
        //Factor de conversion //Entre moneda origen y destino!! No respecto a dólar!!
        //Cantidad
        //Resultado
        //Fecha
        //Usuario

        public int MonedaOrigenId { get; set; }
        public int MonedaDestinoId { get; set; }
        public double Factor { get; set; }
        public double Cantidad { get; set; }
        public double Resultado { get; set; } //podria calcularse en el momento... (Esta info necesaria ya está en la tabla!)

        public DateTime FechaConversion { get; set; }
        public int UsuarioId { get; set; }




    }
}